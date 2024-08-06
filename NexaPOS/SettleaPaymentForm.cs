using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexaPOS
{
    public partial class SettleaPaymentForm : Form
    {
        private decimal totalPrice;
        public decimal PaidAmount { get; private set; }
        public bool IsPaymentConfirmed { get; private set; }

        public SettleaPaymentForm(decimal totalPrice)
        {
            InitializeComponent();
            this.totalPrice = totalPrice;
            lblTotalPrice.Text = $"Total Price: Rs. {totalPrice:N2}";
        }

        

        private void labelPaid_Click(object sender, EventArgs e)
        {

        }

        private void SettleaPaymentForm_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Text = $"Total Price: Rs. {totalPrice:F2}";
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPaidAmount.Text, out decimal paidAmount) && paidAmount >= totalPrice)
            {
                PaidAmount = paidAmount;
                IsPaymentConfirmed = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid paid amount (should be greater than or equal to total price).");
            }
        }
    }
}
