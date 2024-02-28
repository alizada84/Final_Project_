namespace Final_Project.Views
{
    partial class Form2
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
            btn_register = new Button();
            btn_product = new Button();
            SuspendLayout();
            // 
            // btn_register
            // 
            btn_register.Location = new Point(12, 12);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(156, 80);
            btn_register.TabIndex = 0;
            btn_register.Text = "Registration";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_product
            // 
            btn_product.Location = new Point(314, 12);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(156, 84);
            btn_product.TabIndex = 1;
            btn_product.Text = "Products";
            btn_product.UseVisualStyleBackColor = true;
            btn_product.Click += btn_product_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(btn_product);
            Controls.Add(btn_register);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_register;
        private Button btn_product;
    }
}