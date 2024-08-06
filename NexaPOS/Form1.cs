
using System;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace NexaPOS


{
    public partial class Form1 : Form
    {
        private decimal rowNumber = 1;

        DBConnect dbconn = new DBConnect();
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;

        public Form1()
        {

            InitializeComponent();
            con = new MySqlConnection(dbconn.myConnection());
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
            buttonDiscount.Click += new EventHandler(this.buttonDiscount_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
            btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            changeqtyBtn.Click += new System.EventHandler(this.changeqtyBtn_Click);

        }

        public void AddProductToCart(string pcode, string productName, decimal price, int quantity)
        {
            // Calculate total price
            decimal total = price * quantity;

            // Add product to cart (dataGridView1)
            dataGridView1.Rows.Add(rowNumber, pcode, productName, price, quantity, 0, total);
            rowNumber++;
            UpdateTotalPrice();
        }
        private void changeqtyBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                // Prompt the user to enter a new quantity
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter new quantity:", "Change Quantity", row.Cells["qty"].Value.ToString());
                if (int.TryParse(input, out int newQuantity) && newQuantity > 0)
                {
                    decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                    decimal total = price * newQuantity;

                    row.Cells["qty"].Value = newQuantity;
                    row.Cells["total"].Value = total;

                    UpdateTotalPrice();
                }
                else
                {
                    MessageBox.Show("Invalid quantity entered. Please enter a positive integer.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product row first.");
            }
        }
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            UpdateTotalPrice();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            decimal totalPrice = CalculateTotalPrice();

            SettleaPaymentForm settlePaymentForm = new SettleaPaymentForm(totalPrice);
            settlePaymentForm.ShowDialog();

            if (settlePaymentForm.IsPaymentConfirmed)
            {
                decimal paidAmount = settlePaymentForm.PaidAmount;
                decimal changeAmount = paidAmount - totalPrice;

                ConfirmPaymentForm paymentConfirmedForm = new ConfirmPaymentForm(totalPrice, paidAmount, changeAmount, dataGridView1);
                paymentConfirmedForm.ShowDialog();

                // Clear the cart after payment is confirmed
                dataGridView1.Rows.Clear();
                UpdateTotalPrice();
            }
        }
        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["total"].Value != null)
                {
                    totalPrice += Convert.ToDecimal(row.Cells["total"].Value);
                }
            }

            return totalPrice;
        }
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            // Calculate total price and get the paid amount and change
            decimal totalPrice = CalculateTotalPrice();
            decimal paidAmount = 0; // Replace with actual paid amount
            decimal changeAmount = 0; // Replace with actual change amount

            // Open the settle payment form to get paid amount
            using (var settlePaymentForm = new SettleaPaymentForm(totalPrice))
            {
                if (settlePaymentForm.ShowDialog() == DialogResult.OK)
                {
                    paidAmount = settlePaymentForm.PaidAmount;
                    changeAmount = paidAmount - totalPrice;
                }
            }

            // Generate the PDF receipt and open it
            GenerateReceiptPDF(totalPrice, paidAmount, changeAmount);
        }
        private void GenerateReceiptPDF(decimal totalPrice, decimal paidAmount, decimal changeAmount)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Receipt.pdf");

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (Document doc = new Document())
                {
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Add title
                    doc.Add(new Paragraph("Receipt", FontFactory.GetFont("Arial", 16.ToString(), Font.Bold)));
                    doc.Add(new Paragraph($"Date: {DateTime.Now}"));
                    doc.Add(new Paragraph(""));

                    // Add items
                    doc.Add(new Paragraph("Items Purchased:", FontFactory.GetFont("Arial", 12.ToString(), Font.Bold)));
                    doc.Add(new Paragraph(""));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["description"].Value != null)
                        {
                            string itemName = row.Cells["description"].Value.ToString();
                            decimal itemPrice = Convert.ToDecimal(row.Cells["price"].Value);
                            doc.Add(new Paragraph($"{itemName}: Rs. {itemPrice:N2}"));
                        }
                    }

                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph($"Total Price: Rs. {totalPrice:N2}"));
                    doc.Add(new Paragraph($"Paid Amount: Rs. {paidAmount:N2}"));
                    doc.Add(new Paragraph($"Change: Rs. {changeAmount:N2}"));

                    doc.Close();
                }
            }

            // Open the PDF file automatically
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // Open with the default application
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}");
            }

            MessageBox.Show($"Receipt has been saved to {filePath}");
        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SearchProducts searchProductsForm = new SearchProducts(this);
            searchProductsForm.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ApplyDiscount(int rowIndex, decimal discount)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            decimal price = Convert.ToDecimal(row.Cells["price"].Value);
            int quantity = Convert.ToInt32(row.Cells["qty"].Value);
            decimal discountAmount = (discount / 100) * price;
            decimal newPrice = price - discountAmount;

            row.Cells["price"].Value = newPrice;
            row.Cells["total"].Value = newPrice * quantity;
            row.Cells["discount"].Value = discount;

            UpdateTotalPrice();
        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                DiscountForm discountForm = new DiscountForm(this, rowIndex);
                discountForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a product row first.");
            }
        }
        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["total"].Value != null)
                {
                    totalPrice += Convert.ToDecimal(row.Cells["total"].Value);
                }
            }
            lblTotalPrice.Text = $"Total Price: Rs. {totalPrice:N2}";

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonNewtransection_Click(object sender, EventArgs e)
        {

        }
    }

}
