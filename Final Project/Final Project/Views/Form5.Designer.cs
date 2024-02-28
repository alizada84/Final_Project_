namespace Final_Project.Views
{
    partial class Form5
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
            btn_shop = new Button();
            btn_balance = new Button();
            SuspendLayout();
            // 
            // btn_shop
            // 
            btn_shop.Location = new Point(314, 12);
            btn_shop.Name = "btn_shop";
            btn_shop.Size = new Size(156, 84);
            btn_shop.TabIndex = 3;
            btn_shop.Text = "Shopping";
            btn_shop.UseVisualStyleBackColor = true;
            // 
            // btn_balance
            // 
            btn_balance.Location = new Point(12, 12);
            btn_balance.Name = "btn_balance";
            btn_balance.Size = new Size(156, 80);
            btn_balance.TabIndex = 2;
            btn_balance.Text = "Add to Balance";
            btn_balance.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(btn_shop);
            Controls.Add(btn_balance);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_shop;
        private Button btn_balance;
    }
}