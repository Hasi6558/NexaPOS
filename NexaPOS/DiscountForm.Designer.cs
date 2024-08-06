namespace NexaPOS
{
    partial class DiscountForm
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
            textDiscount = new TextBox();
            labelPercentage = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textDiscount
            // 
            textDiscount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDiscount.Location = new Point(127, 54);
            textDiscount.Name = "textDiscount";
            textDiscount.Size = new Size(84, 47);
            textDiscount.TabIndex = 0;
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPercentage.Location = new Point(228, 60);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(43, 41);
            labelPercentage.TabIndex = 1;
            labelPercentage.Text = "%";
            labelPercentage.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(96, 132);
            button1.Name = "button1";
            button1.Size = new Size(163, 59);
            button1.TabIndex = 2;
            button1.Text = "Add Discount";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // DiscountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 221);
            Controls.Add(button1);
            Controls.Add(labelPercentage);
            Controls.Add(textDiscount);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DiscountForm";
            Text = "DiscountForm";
            Load += DiscountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDiscount;
        private Label labelPercentage;
        private Button button1;
    }
}