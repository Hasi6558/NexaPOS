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
    public partial class DiscountForm : Form
    {
        private Form1 mainForm;
        private int rowIndex;

        public DiscountForm(Form1 mainForm, int rowIndex)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.rowIndex = rowIndex;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textDiscount.Text, out decimal discount) && discount >= 0 && discount <= 100)
            {
                mainForm.ApplyDiscount(rowIndex, discount);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid discount percentage (0-100).");
            }
        }

        private void DiscountForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textDiscount.Text, out decimal discount) && discount >= 0 && discount <= 100)
            {
                mainForm.ApplyDiscount(rowIndex, discount);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid discount percentage (0-100).");
            }
        }
    }
}
