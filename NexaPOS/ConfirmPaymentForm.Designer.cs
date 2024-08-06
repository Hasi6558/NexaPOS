namespace NexaPOS
{
    partial class ConfirmPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPaymentForm));
            label3 = new Label();
            buttonPrintRecipt = new Button();
            changeLbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(106, 100);
            label3.Name = "label3";
            label3.Size = new Size(62, 27);
            label3.TabIndex = 6;
            label3.Text = "total";
            // 
            // buttonPrintRecipt
            // 
            buttonPrintRecipt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrintRecipt.Location = new Point(116, 305);
            buttonPrintRecipt.Name = "buttonPrintRecipt";
            buttonPrintRecipt.Size = new Size(152, 80);
            buttonPrintRecipt.TabIndex = 9;
            buttonPrintRecipt.Text = "Print Reciept";
            buttonPrintRecipt.UseVisualStyleBackColor = true;
            buttonPrintRecipt.Click += buttonPrintRecipt_Click;
            // 
            // changeLbl
            // 
            changeLbl.AutoSize = true;
            changeLbl.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeLbl.ForeColor = SystemColors.ActiveCaptionText;
            changeLbl.Location = new Point(55, 203);
            changeLbl.Name = "changeLbl";
            changeLbl.Size = new Size(74, 34);
            changeLbl.TabIndex = 10;
            changeLbl.Text = "total";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 50);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ConfirmPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 454);
            Controls.Add(pictureBox1);
            Controls.Add(changeLbl);
            Controls.Add(buttonPrintRecipt);
            Controls.Add(label3);
            Name = "ConfirmPaymentForm";
            Text = "ConfirmPaymentForm";
            Load += ConfirmPaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalPrice;
        private Label changeLbl;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonPrintRecipt;
        private PictureBox pictureBox1;
    }
}