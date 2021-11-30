namespace StockManagementApp
{
    partial class ProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbBoxProdLoad = new System.Windows.Forms.ComboBox();
            this.dtGrdProduct = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBoxProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.RichTextBox();
            this.txtProdQuantity = new System.Windows.Forms.RichTextBox();
            this.txtProdName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cmbBoxProdLoad);
            this.panel1.Controls.Add(this.dtGrdProduct);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbBoxProduct);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProdPrice);
            this.panel1.Controls.Add(this.txtProdQuantity);
            this.panel1.Controls.Add(this.txtProdName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(167, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 526);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(1350, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 26);
            this.button7.TabIndex = 16;
            this.button7.Text = "REFRESH";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnRefreshClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(670, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnRefreshClick);
            // 
            // cmbBoxProdLoad
            // 
            this.cmbBoxProdLoad.BackColor = System.Drawing.Color.White;
            this.cmbBoxProdLoad.Font = new System.Drawing.Font("Menlo", 9F, System.Drawing.FontStyle.Bold);
            this.cmbBoxProdLoad.ForeColor = System.Drawing.Color.Green;
            this.cmbBoxProdLoad.FormattingEnabled = true;
            this.cmbBoxProdLoad.Items.AddRange(new object[] {
            "FRUIT",
            "VEGETABLE",
            "MEAT",
            "MEAL",
            "RICE",
            "FLOUR",
            "BEVERAGE"});
            this.cmbBoxProdLoad.Location = new System.Drawing.Point(510, 104);
            this.cmbBoxProdLoad.Name = "cmbBoxProdLoad";
            this.cmbBoxProdLoad.Size = new System.Drawing.Size(154, 26);
            this.cmbBoxProdLoad.TabIndex = 15;
            this.cmbBoxProdLoad.Text = "Select Category";
            this.cmbBoxProdLoad.SelectedIndexChanged += new System.EventHandler(this.selectedCategoryIndex);
            // 
            // dtGrdProduct
            // 
            this.dtGrdProduct.AllowUserToOrderColumns = true;
            this.dtGrdProduct.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdProduct.Location = new System.Drawing.Point(330, 130);
            this.dtGrdProduct.Name = "dtGrdProduct";
            this.dtGrdProduct.RowHeadersWidth = 51;
            this.dtGrdProduct.Size = new System.Drawing.Size(432, 209);
            this.dtGrdProduct.TabIndex = 14;
            this.dtGrdProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdProduct_CellClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.Font = new System.Drawing.Font("Menlo", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.PaleGreen;
            this.button4.Location = new System.Drawing.Point(178, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "EDIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnEditProductClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.Font = new System.Drawing.Font("Menlo", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.PaleGreen;
            this.button5.Location = new System.Drawing.Point(117, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 35);
            this.button5.TabIndex = 12;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnAddProductClick);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Green;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Menlo", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnDeleteProduct.Location = new System.Drawing.Point(250, 306);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(74, 35);
            this.btnDeleteProduct.TabIndex = 11;
            this.btnDeleteProduct.Text = "DELETE";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProductClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Menlo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(47, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "CATEGORY";
            // 
            // cmbBoxProduct
            // 
            this.cmbBoxProduct.BackColor = System.Drawing.Color.White;
            this.cmbBoxProduct.Font = new System.Drawing.Font("Menlo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxProduct.ForeColor = System.Drawing.Color.Green;
            this.cmbBoxProduct.FormattingEnabled = true;
            this.cmbBoxProduct.Items.AddRange(new object[] {
            "FRUIT",
            "VEGETABLE",
            "MEAT",
            "MEAL",
            "RICE",
            "FLOUR",
            "BEVERAGE"});
            this.cmbBoxProduct.Location = new System.Drawing.Point(150, 241);
            this.cmbBoxProduct.Name = "cmbBoxProduct";
            this.cmbBoxProduct.Size = new System.Drawing.Size(174, 30);
            this.cmbBoxProduct.TabIndex = 9;
            this.cmbBoxProduct.Text = "Select Category";
            this.cmbBoxProduct.SelectedIndexChanged += new System.EventHandler(this.cmbBoxProducts_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Menlo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(47, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "QUANTITY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Menlo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(47, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Menlo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(47, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "NAME";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.BackColor = System.Drawing.Color.White;
            this.txtProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdPrice.Location = new System.Drawing.Point(150, 203);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(174, 26);
            this.txtProdPrice.TabIndex = 4;
            this.txtProdPrice.Text = "";
            // 
            // txtProdQuantity
            // 
            this.txtProdQuantity.BackColor = System.Drawing.Color.White;
            this.txtProdQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdQuantity.Location = new System.Drawing.Point(150, 168);
            this.txtProdQuantity.Name = "txtProdQuantity";
            this.txtProdQuantity.Size = new System.Drawing.Size(174, 26);
            this.txtProdQuantity.TabIndex = 3;
            this.txtProdQuantity.Text = "";
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.White;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdName.Location = new System.Drawing.Point(150, 132);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(174, 26);
            this.txtProdName.TabIndex = 2;
            this.txtProdName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Menlo", 15F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(298, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(15, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seller";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSellerWinClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(15, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Categories";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnCatWinClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(1788, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(960, -2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "x";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(985, 580);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtProdQuantity;
        private System.Windows.Forms.RichTextBox txtProdName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtProdPrice;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cmbBoxProdLoad;
        private System.Windows.Forms.DataGridView dtGrdProduct;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBoxProduct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
    }
}