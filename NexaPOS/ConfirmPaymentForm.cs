using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace NexaPOS
{
    public partial class ConfirmPaymentForm : Form
    {
        public decimal Change { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal PaidAmount { get; set; }
        private DataGridView _dataGridView;

        public ConfirmPaymentForm(decimal totalPrice, decimal paidAmount, decimal changeAmount, DataGridView dataGridView)
        {
            InitializeComponent();
            TotalPrice = totalPrice;
            PaidAmount = paidAmount;
            Change = changeAmount;
            _dataGridView = dataGridView;
            
        }

        private void ConfirmPaymentForm_Load(object sender, EventArgs e)
        {
            // Display the confirmation message and the change amount
            label3.Text = $"Payment confirmed !";
            changeLbl.Text = $"Change: Rs. {Change:F2}";
        }

        private void buttonPrintRecipt_Click(object sender, EventArgs e)
        {
            GenerateReceiptPDF();
        }

        private void GenerateReceiptPDF()
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

                    // Add items from DataGridView
                    foreach (DataGridViewRow row in _dataGridView.Rows)
                    {
                        if (row.Cells["description"].Value != null)
                        {
                            string itemName = row.Cells["description"].Value.ToString();
                            decimal itemPrice = Convert.ToDecimal(row.Cells["price"].Value);
                            doc.Add(new Paragraph($"{itemName}: Rs. {itemPrice:N2}"));
                        }
                    }

                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph($"Total Price: Rs. {TotalPrice:N2}"));
                    doc.Add(new Paragraph($"Paid Amount: Rs. {PaidAmount:N2}"));
                    doc.Add(new Paragraph($"Change: Rs. {Change:N2}"));

                    doc.Close();
                }
            }

            MessageBox.Show($"Receipt has been saved to {filePath}");
        }
    }
}
