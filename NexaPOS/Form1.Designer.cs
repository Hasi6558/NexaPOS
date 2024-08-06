using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace NexaPOS
{
    partial class Form1 
    {
       
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelside = new Panel();
            button5 = new Button();
            button1 = new Button();
            btnSettlePayment = new Button();
            btnClearCart = new Button();
            buttonDiscount = new Button();
            buttonSearch = new Button();
            changeqtyBtn = new Button();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            lblTotalPrice = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            productcode = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            panelside.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelside
            // 
            panelside.Controls.Add(button5);
            panelside.Controls.Add(button1);
            panelside.Controls.Add(btnSettlePayment);
            panelside.Controls.Add(btnClearCart);
            panelside.Controls.Add(buttonDiscount);
            panelside.Controls.Add(buttonSearch);
            panelside.Controls.Add(changeqtyBtn);
            panelside.Controls.Add(panel3);
            panelside.Controls.Add(panel2);
            panelside.Dock = DockStyle.Right;
            panelside.Location = new Point(865, 0);
            panelside.Name = "panelside";
            panelside.Size = new Size(317, 653);
            panelside.TabIndex = 0;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(174, 561);
            button5.Name = "button5";
            button5.Size = new Size(105, 57);
            button5.TabIndex = 8;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(41, 561);
            button1.Name = "button1";
            button1.Size = new Size(113, 57);
            button1.TabIndex = 7;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSettlePayment
            // 
            btnSettlePayment.BackColor = Color.FromArgb(34, 130, 59);
            btnSettlePayment.FlatStyle = FlatStyle.Flat;
            btnSettlePayment.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettlePayment.ForeColor = SystemColors.Control;
            btnSettlePayment.Location = new Point(41, 424);
            btnSettlePayment.Margin = new Padding(10);
            btnSettlePayment.Name = "btnSettlePayment";
            btnSettlePayment.Size = new Size(246, 92);
            btnSettlePayment.TabIndex = 6;
            btnSettlePayment.Text = "Settle payment";
            btnSettlePayment.UseVisualStyleBackColor = false;
            // 
            // btnClearCart
            // 
            btnClearCart.AutoEllipsis = true;
            btnClearCart.BackColor = Color.FromArgb(55, 89, 173);
            btnClearCart.FlatStyle = FlatStyle.Popup;
            btnClearCart.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCart.ForeColor = SystemColors.Control;
            btnClearCart.Location = new Point(174, 287);
            btnClearCart.Margin = new Padding(10);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(113, 92);
            btnClearCart.TabIndex = 5;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            // 
            // buttonDiscount
            // 
            buttonDiscount.BackColor = Color.FromArgb(55, 89, 173);
            buttonDiscount.FlatStyle = FlatStyle.Popup;
            buttonDiscount.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDiscount.ForeColor = SystemColors.Control;
            buttonDiscount.Location = new Point(41, 287);
            buttonDiscount.Margin = new Padding(10);
            buttonDiscount.Name = "buttonDiscount";
            buttonDiscount.Size = new Size(113, 92);
            buttonDiscount.TabIndex = 4;
            buttonDiscount.Text = "Add Discount";
            buttonDiscount.UseVisualStyleBackColor = false;
            buttonDiscount.Click += buttonDiscount_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(55, 89, 173);
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = SystemColors.Control;
            buttonSearch.Location = new Point(41, 175);
            buttonSearch.Margin = new Padding(10);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(113, 92);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search Products";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += button1_Click_1;
            // 
            // changeqtyBtn
            // 
            changeqtyBtn.BackColor = Color.FromArgb(55, 89, 173);
            changeqtyBtn.FlatStyle = FlatStyle.Popup;
            changeqtyBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeqtyBtn.ForeColor = SystemColors.Control;
            changeqtyBtn.Location = new Point(174, 175);
            changeqtyBtn.Margin = new Padding(10);
            changeqtyBtn.Name = "changeqtyBtn";
            changeqtyBtn.Size = new Size(113, 92);
            changeqtyBtn.TabIndex = 2;
            changeqtyBtn.Text = "Change Quantity";
            changeqtyBtn.UseVisualStyleBackColor = false;
            changeqtyBtn.Click += buttonNewtransection_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 73);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(74, 25);
            label2.Name = "label2";
            label2.Size = new Size(175, 48);
            label2.TabIndex = 0;
            label2.Text = "NexaPOS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(43, 67, 148);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 40);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalPrice);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 548);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 105);
            panel1.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = SystemColors.ButtonHighlight;
            lblTotalPrice.Location = new Point(62, 36);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 34);
            lblTotalPrice.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(865, 40);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(865, 508);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 47, 47);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, productcode, description, price, qty, discount, total });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(865, 508);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // no
            // 
            no.FillWeight = 56.1497269F;
            no.HeaderText = "No";
            no.MinimumWidth = 6;
            no.Name = "no";
            no.ReadOnly = true;
            // 
            // productcode
            // 
            productcode.FillWeight = 107.308388F;
            productcode.HeaderText = "PCode";
            productcode.MinimumWidth = 6;
            productcode.Name = "productcode";
            productcode.ReadOnly = true;
            // 
            // description
            // 
            description.FillWeight = 107.308388F;
            description.HeaderText = "Product Name";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // price
            // 
            price.FillWeight = 107.308388F;
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // qty
            // 
            qty.FillWeight = 107.308388F;
            qty.HeaderText = "Qty";
            qty.MinimumWidth = 6;
            qty.Name = "qty";
            qty.ReadOnly = true;
            // 
            // discount
            // 
            discount.FillWeight = 107.308388F;
            discount.HeaderText = "Discount %";
            discount.MinimumWidth = 6;
            discount.Name = "discount";
            discount.ReadOnly = true;
            // 
            // total
            // 
            total.FillWeight = 107.308388F;
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 67, 148);
            ClientSize = new Size(1182, 653);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panelside);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NexaPOS";
            Load += Form1_Load_1;
            panelside.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelside;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button changeqtyBtn;
        private Button buttonSearch;
        private Button btnSettlePayment;
        private Button btnClearCart;
        private Button buttonDiscount;
        private Button button5;
        private Button button1;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label lblTotalPrice;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn productcode;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn total;
    }
}