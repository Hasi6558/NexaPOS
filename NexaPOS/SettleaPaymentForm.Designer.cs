namespace NexaPOS
{
    partial class SettleaPaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblTotalPrice = new Label();
            labelPaid = new Label();
            txtPaidAmount = new TextBox();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Green;
            lblTotalPrice.Location = new Point(36, 90);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(74, 34);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "total";
            // 
            // labelPaid
            // 
            labelPaid.AutoSize = true;
            labelPaid.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPaid.ForeColor = SystemColors.ActiveCaptionText;
            labelPaid.Location = new Point(51, 193);
            labelPaid.Name = "labelPaid";
            labelPaid.Size = new Size(90, 34);
            labelPaid.TabIndex = 3;
            labelPaid.Text = "Paid :";
            labelPaid.Click += labelPaid_Click;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Location = new Point(178, 200);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(140, 27);
            txtPaidAmount.TabIndex = 4;
            // 
            // buttonOk
            // 
            buttonOk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOk.Location = new Point(140, 300);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 49);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click_1;
            // 
            // SettleaPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 454);
            Controls.Add(buttonOk);
            Controls.Add(txtPaidAmount);
            Controls.Add(labelPaid);
            Controls.Add(lblTotalPrice);
            Name = "SettleaPaymentForm";
            Text = "SettleaPaymentForm";
            Load += SettleaPaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblTotalPrice;
        private Label labelPaid;
        private TextBox txtPaidAmount;
        private Button buttonOk;
    }
}