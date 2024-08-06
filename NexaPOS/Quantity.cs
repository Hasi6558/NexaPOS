using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace NexaPOS
{
    public partial class Quantity : Form
    {
        private int no;
        private string pcode;
        private string barcode;
        private string description;
        private string brand;
        private string category;
        private decimal price;

        private Form1 mainForm;

        public Quantity(int no, string pcode, string barcode, string description, string brand, string category, decimal price, Form1 mainForm)
        {
            InitializeComponent();
            this.no = no;
            this.pcode = pcode;
            this.barcode = barcode;
            this.description = description;
            this.brand = brand;
            this.category = category;
            this.price = price;
            this.mainForm = mainForm;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            textQuantity.KeyDown += new KeyEventHandler(this.textQuantity_KeyDown);


        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(textQuantity.Text, out quantity) && quantity > 0)
            {
                // Debug statement
                MessageBox.Show($"Adding product to cart: {no}, {pcode}, {barcode}, {description}, {brand}, {category}, {price}, {quantity}");

                mainForm.AddProductToCart(pcode,description,price, quantity);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }

        private void textQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound on Enter key press
                e.SuppressKeyPress = true;

                // Call the button's click event handler
                btnAddToCart.PerformClick();
            }
        }
        private void textQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevent the beep sound on Enter key press
                e.Handled = true;

                // Call the button's click event handler
                btnAddToCart.PerformClick();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This can be left empty or removed if not needed
        }

        private void Quantity_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }
    }
}
