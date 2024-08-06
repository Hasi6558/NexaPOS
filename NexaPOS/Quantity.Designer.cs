namespace NexaPOS
{
    partial class Quantity
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
            textQuantity = new TextBox();
            btnAddToCart = new Button();
            SuspendLayout();
            // 
            // textQuantity
            // 
            textQuantity.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textQuantity.Location = new Point(34, 12);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(125, 57);
            textQuantity.TabIndex = 0;
            textQuantity.TextAlign = HorizontalAlignment.Center;
            textQuantity.TextChanged += textBox1_TextChanged;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.Location = new Point(45, 94);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(94, 63);
            btnAddToCart.TabIndex = 1;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // Quantity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(191, 169);
            Controls.Add(btnAddToCart);
            Controls.Add(textQuantity);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Quantity";
            Text = "Quantity";
            Load += Quantity_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textQuantity;
        private Button btnAddToCart;
    }
}