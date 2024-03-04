namespace Final_Project.Views
{
    partial class Form6
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
            dataBalance = new DataGridView();
            btn_adddToBalance = new Button();
            txt_balance = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataBalance).BeginInit();
            SuspendLayout();
            // 
            // dataBalance
            // 
            dataBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBalance.Location = new Point(41, 12);
            dataBalance.Name = "dataBalance";
            dataBalance.RowHeadersWidth = 51;
            dataBalance.RowTemplate.Height = 29;
            dataBalance.Size = new Size(300, 188);
            dataBalance.TabIndex = 0;
            // 
            // btn_adddToBalance
            // 
            btn_adddToBalance.Location = new Point(197, 297);
            btn_adddToBalance.Name = "btn_adddToBalance";
            btn_adddToBalance.Size = new Size(144, 47);
            btn_adddToBalance.TabIndex = 1;
            btn_adddToBalance.Text = "Add To Balance";
            btn_adddToBalance.UseVisualStyleBackColor = true;
            btn_adddToBalance.Click += btn_adddToBalance_Click;
            // 
            // txt_balance
            // 
            txt_balance.Location = new Point(41, 229);
            txt_balance.Name = "txt_balance";
            txt_balance.Size = new Size(125, 27);
            txt_balance.TabIndex = 2;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 385);
            Controls.Add(txt_balance);
            Controls.Add(btn_adddToBalance);
            Controls.Add(dataBalance);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataBalance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataBalance;
        private Button btn_adddToBalance;
        private TextBox txt_balance;
    }
}