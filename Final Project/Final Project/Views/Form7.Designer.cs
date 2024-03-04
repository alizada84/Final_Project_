namespace Final_Project.Views
{
    partial class Form7
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
            dataProducts = new DataGridView();
            btn_Buy = new Button();
            btn_AddBasket = new Button();
            ((System.ComponentModel.ISupportInitialize)dataProducts).BeginInit();
            SuspendLayout();
            // 
            // dataProducts
            // 
            dataProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProducts.Location = new Point(12, 12);
            dataProducts.Name = "dataProducts";
            dataProducts.RowHeadersWidth = 51;
            dataProducts.RowTemplate.Height = 29;
            dataProducts.Size = new Size(652, 188);
            dataProducts.TabIndex = 0;
            // 
            // btn_Buy
            // 
            btn_Buy.Location = new Point(12, 245);
            btn_Buy.Name = "btn_Buy";
            btn_Buy.Size = new Size(131, 57);
            btn_Buy.TabIndex = 1;
            btn_Buy.Text = "Buy the Product";
            btn_Buy.UseVisualStyleBackColor = true;
            // 
            // btn_AddBasket
            // 
            btn_AddBasket.Location = new Point(533, 245);
            btn_AddBasket.Name = "btn_AddBasket";
            btn_AddBasket.Size = new Size(131, 57);
            btn_AddBasket.TabIndex = 2;
            btn_AddBasket.Text = "Add to basket";
            btn_AddBasket.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 363);
            Controls.Add(btn_AddBasket);
            Controls.Add(btn_Buy);
            Controls.Add(dataProducts);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dataProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataProducts;
        private Button btn_Buy;
        private Button btn_AddBasket;
    }
}