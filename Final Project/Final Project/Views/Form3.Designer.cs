﻿namespace Final_Project.Views
{
    partial class Form3
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
            btn_delete1 = new Button();
            dataProducts = new DataGridView();
            btn_Update1 = new Button();
            btn_Add1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataProducts).BeginInit();
            SuspendLayout();
            // 
            // btn_delete1
            // 
            btn_delete1.Location = new Point(559, 289);
            btn_delete1.Name = "btn_delete1";
            btn_delete1.Size = new Size(131, 50);
            btn_delete1.TabIndex = 2;
            btn_delete1.Text = "Delete";
            btn_delete1.UseVisualStyleBackColor = true;
            btn_delete1.Click += btn_delete1_Click;
            // 
            // dataProducts
            // 
            dataProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProducts.Location = new Point(12, 12);
            dataProducts.Name = "dataProducts";
            dataProducts.RowHeadersWidth = 51;
            dataProducts.RowTemplate.Height = 29;
            dataProducts.Size = new Size(678, 203);
            dataProducts.TabIndex = 3;
            // 
            // btn_Update1
            // 
            btn_Update1.Location = new Point(272, 289);
            btn_Update1.Name = "btn_Update1";
            btn_Update1.Size = new Size(131, 50);
            btn_Update1.TabIndex = 1;
            btn_Update1.Text = "Update";
            btn_Update1.UseVisualStyleBackColor = true;
            btn_Update1.Click += btn_Update1_Click;
            // 
            // btn_Add1
            // 
            btn_Add1.Location = new Point(12, 291);
            btn_Add1.Name = "btn_Add1";
            btn_Add1.Size = new Size(131, 50);
            btn_Add1.TabIndex = 4;
            btn_Add1.Text = "Add";
            btn_Add1.UseVisualStyleBackColor = true;
            btn_Add1.Click += btn_Add1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 395);
            Controls.Add(btn_Add1);
            Controls.Add(dataProducts);
            Controls.Add(btn_delete1);
            Controls.Add(btn_Update1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btn_delete1;
        private DataGridView dataProducts;
        private Button btn_Update1;
        private Button btn_Add1;
    }
}