namespace Final_Project
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
            txtBox_username = new TextBox();
            lbl_username = new Label();
            lbl_password = new Label();
            textBox_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txtBox_username
            // 
            txtBox_username.Location = new Point(52, 101);
            txtBox_username.Name = "txtBox_username";
            txtBox_username.Size = new Size(185, 27);
            txtBox_username.TabIndex = 0;
            txtBox_username.TextChanged += txtBox_username_TextChanged;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(52, 61);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(75, 20);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(52, 180);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(70, 20);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Password";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(52, 222);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(185, 27);
            textBox_password.TabIndex = 3;
            textBox_password.TextChanged += textBox_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(52, 311);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(185, 47);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 453);
            Controls.Add(btn_login);
            Controls.Add(textBox_password);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(txtBox_username);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox_username;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox textBox_password;
        private Button btn_login;
    }
}