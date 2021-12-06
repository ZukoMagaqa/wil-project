using System.Media;
using System.Windows;
using System.Windows.Forms;

namespace StockManagementApp
{
    partial class SellerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtGrdSeller = new System.Windows.Forms.DataGridView();
            this.txtSellerPassword = new System.Windows.Forms.RichTextBox();
            this.btnEditSeller = new System.Windows.Forms.Button();
            this.btnAddSeller = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSellerPhone = new System.Windows.Forms.RichTextBox();
            this.txtSellerAge = new System.Windows.Forms.RichTextBox();
            this.txtSellerName = new System.Windows.Forms.RichTextBox();
            this.txtSellerId = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2404, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(2401, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "x";
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCategory.ForeColor = System.Drawing.Color.Green;
            this.btnCategory.Location = new System.Drawing.Point(37, 108);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(116, 28);
            this.btnCategory.TabIndex = 8;
            this.btnCategory.Text = "Categories";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategoryClick);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnProducts.ForeColor = System.Drawing.Color.Green;
            this.btnProducts.Location = new System.Drawing.Point(37, 177);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(116, 28);
            this.btnProducts.TabIndex = 6;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProductsClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(1281, -5);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "x";
            this.label9.Click += new System.EventHandler(this.sellerCloseClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Menlo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(37, 614);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLogoutClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dtGrdSeller);
            this.panel1.Controls.Add(this.txtSellerPassword);
            this.panel1.Controls.Add(this.btnEditSeller);
            this.panel1.Controls.Add(this.btnAddSeller);
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSellerPhone);
            this.panel1.Controls.Add(this.txtSellerAge);
            this.panel1.Controls.Add(this.txtSellerName);
            this.panel1.Controls.Add(this.txtSellerId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(260, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 591);
            this.panel1.TabIndex = 1;
            // 
            // dtGrdSeller
            // 
            this.dtGrdSeller.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtGrdSeller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrdSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdSeller.Location = new System.Drawing.Point(483, 102);
            this.dtGrdSeller.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdSeller.Name = "dtGrdSeller";
            this.dtGrdSeller.RowHeadersWidth = 51;
            this.dtGrdSeller.Size = new System.Drawing.Size(513, 279);
            this.dtGrdSeller.TabIndex = 18;
            this.dtGrdSeller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickIndexChanged);
            // 
            // txtSellerPassword
            // 
            this.txtSellerPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerPassword.Location = new System.Drawing.Point(225, 293);
            this.txtSellerPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellerPassword.Name = "txtSellerPassword";
            this.txtSellerPassword.Size = new System.Drawing.Size(229, 39);
            this.txtSellerPassword.TabIndex = 17;
            this.txtSellerPassword.Text = "";
            // 
            // btnEditSeller
            // 
            this.btnEditSeller.BackColor = System.Drawing.Color.Green;
            this.btnEditSeller.Font = new System.Drawing.Font("Menlo", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEditSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditSeller.Location = new System.Drawing.Point(294, 346);
            this.btnEditSeller.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSeller.Name = "btnEditSeller";
            this.btnEditSeller.Size = new System.Drawing.Size(70, 36);
            this.btnEditSeller.TabIndex = 13;
            this.btnEditSeller.Text = "EDIT";
            this.btnEditSeller.UseVisualStyleBackColor = false;
            this.btnEditSeller.Click += new System.EventHandler(this.btnEditSeller_Click);
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.BackColor = System.Drawing.Color.Green;
            this.btnAddSeller.Font = new System.Drawing.Font("Menlo", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddSeller.Location = new System.Drawing.Point(217, 346);
            this.btnAddSeller.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(69, 36);
            this.btnAddSeller.TabIndex = 12;
            this.btnAddSeller.Text = "ADD";
            this.btnAddSeller.UseVisualStyleBackColor = false;
            this.btnAddSeller.Click += new System.EventHandler(this.btnAddSeller_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Green;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Menlo", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(372, 346);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(84, 36);
            this.btnDeleteProduct.TabIndex = 11;
            this.btnDeleteProduct.Text = "DELETE";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(65, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "PASSWORD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(65, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "AGE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(65, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "PHONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(65, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(65, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SELLER ID";
            // 
            // txtSellerPhone
            // 
            this.txtSellerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerPhone.Location = new System.Drawing.Point(225, 244);
            this.txtSellerPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellerPhone.Name = "txtSellerPhone";
            this.txtSellerPhone.Size = new System.Drawing.Size(229, 39);
            this.txtSellerPhone.TabIndex = 4;
            this.txtSellerPhone.Text = "";
            // 
            // txtSellerAge
            // 
            this.txtSellerAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerAge.Location = new System.Drawing.Point(225, 196);
            this.txtSellerAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellerAge.Name = "txtSellerAge";
            this.txtSellerAge.Size = new System.Drawing.Size(229, 39);
            this.txtSellerAge.TabIndex = 3;
            this.txtSellerAge.Text = "";
            // 
            // txtSellerName
            // 
            this.txtSellerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerName.Location = new System.Drawing.Point(225, 149);
            this.txtSellerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(229, 39);
            this.txtSellerName.TabIndex = 2;
            this.txtSellerName.Text = "";
            // 
            // txtSellerId
            // 
            this.txtSellerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerId.Location = new System.Drawing.Point(225, 102);
            this.txtSellerId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellerId.Multiline = false;
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(229, 39);
            this.txtSellerId.TabIndex = 1;
            this.txtSellerId.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Menlo", 13F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(575, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE SELLER";
            // 
            // SellerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1313, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Controls.Border myBorder1;
        private Panel panel1;
        private RichTextBox txtSellerPassword;
        private Button btnEditSeller;
        private Button btnAddSeller;
        private Button btnDeleteProduct;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox txtSellerPhone;
        private RichTextBox txtSellerAge;
        private RichTextBox txtSellerName;
        private RichTextBox txtSellerId;
        private Label label1;
        private DataGridView dtGrdSeller;
    }
}