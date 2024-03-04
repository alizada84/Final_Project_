namespace Final_Project.Views
{
    partial class Form4
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
            dataUsers = new DataGridView();
            btn_delete = new Button();
            btn_Update = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataUsers).BeginInit();
            SuspendLayout();
            // 
            // dataUsers
            // 
            dataUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsers.Location = new Point(12, 12);
            dataUsers.Name = "dataUsers";
            dataUsers.RowHeadersWidth = 51;
            dataUsers.RowTemplate.Height = 29;
            dataUsers.Size = new Size(678, 203);
            dataUsers.TabIndex = 7;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(559, 289);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(131, 50);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(272, 289);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(131, 50);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(12, 289);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(125, 52);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 353);
            Controls.Add(dataUsers);
            Controls.Add(btn_delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_add);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataUsers;
        private Button btn_delete;
        private Button btn_Update;
        private Button btn_add;
    }
}