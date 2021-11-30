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
            this.lstBoxSellerH = new System.Windows.Forms.ListBox();
            this.lstSeller = new System.Windows.Forms.ListBox();
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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1803, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(1801, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "x";
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCategory.ForeColor = System.Drawing.Color.Green;
            this.btnCategory.Location = new System.Drawing.Point(28, 88);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(87, 23);
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
            this.btnProducts.Location = new System.Drawing.Point(28, 144);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(87, 23);
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
            this.label9.Location = new System.Drawing.Point(961, -4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "x";
            this.label9.Click += new System.EventHandler(this.sellerCloseClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Menlo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(28, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLogoutClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lstBoxSellerH);
            this.panel1.Controls.Add(this.lstSeller);
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
            this.panel1.Location = new System.Drawing.Point(195, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 480);
            this.panel1.TabIndex = 1;
            // 
            // lstBoxSellerH
            // 
            this.lstBoxSellerH.FormattingEnabled = true;
            this.lstBoxSellerH.Location = new System.Drawing.Point(384, 87);
            this.lstBoxSellerH.Name = "lstBoxSellerH";
            this.lstBoxSellerH.Size = new System.Drawing.Size(347, 17);
            this.lstBoxSellerH.TabIndex = 19;
            // 
            // lstSeller
            // 
            this.lstSeller.FormattingEnabled = true;
            this.lstSeller.Location = new System.Drawing.Point(384, 103);
            this.lstSeller.Name = "lstSeller";
            this.lstSeller.Size = new System.Drawing.Size(347, 225);
            this.lstSeller.TabIndex = 18;
            this.lstSeller.SelectedIndexChanged += new System.EventHandler(this.lstSeller_SelectedIndexChanged);
            // 
            // txtSellerPassword
            // 
            this.txtSellerPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerPassword.Location = new System.Drawing.Point(169, 238);
            this.txtSellerPassword.Name = "txtSellerPassword";
            this.txtSellerPassword.Size = new System.Drawing.Size(172, 32);
            this.txtSellerPassword.TabIndex = 17;
            this.txtSellerPassword.Text = "";
            // 
            // btnEditSeller
            // 
            this.btnEditSeller.BackColor = System.Drawing.Color.Green;
            this.btnEditSeller.Font = new System.Drawing.Font("Menlo", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEditSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditSeller.Location = new System.Drawing.Point(193, 281);
            this.btnEditSeller.Name = "btnEditSeller";
            this.btnEditSeller.Size = new System.Drawing.Size(67, 29);
            this.btnEditSeller.TabIndex = 13;
            this.btnEditSeller.Text = "EDIT";
            this.btnEditSeller.UseVisualStyleBackColor = false;
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.BackColor = System.Drawing.Color.Green;
            this.btnAddSeller.Font = new System.Drawing.Font("Menlo", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddSeller.Location = new System.Drawing.Point(120, 281);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(67, 29);
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
            this.btnDeleteProduct.Location = new System.Drawing.Point(266, 281);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(76, 29);
            this.btnDeleteProduct.TabIndex = 11;
            this.btnDeleteProduct.Text = "DELETE";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(49, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "PASSWORD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(49, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "AGE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(49, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "PHONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(49, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(49, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "SELLER ID";
            // 
            // txtSellerPhone
            // 
            this.txtSellerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerPhone.Location = new System.Drawing.Point(169, 198);
            this.txtSellerPhone.Name = "txtSellerPhone";
            this.txtSellerPhone.Size = new System.Drawing.Size(172, 32);
            this.txtSellerPhone.TabIndex = 4;
            this.txtSellerPhone.Text = "";
            // 
            // txtSellerAge
            // 
            this.txtSellerAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerAge.Location = new System.Drawing.Point(169, 159);
            this.txtSellerAge.Name = "txtSellerAge";
            this.txtSellerAge.Size = new System.Drawing.Size(172, 32);
            this.txtSellerAge.TabIndex = 3;
            this.txtSellerAge.Text = "";
            // 
            // txtSellerName
            // 
            this.txtSellerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerName.Location = new System.Drawing.Point(169, 121);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(172, 32);
            this.txtSellerName.TabIndex = 2;
            this.txtSellerName.Text = "";
            // 
            // txtSellerId
            // 
            this.txtSellerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSellerId.Location = new System.Drawing.Point(169, 83);
            this.txtSellerId.Multiline = false;
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(172, 32);
            this.txtSellerId.TabIndex = 1;
            this.txtSellerId.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Menlo", 13F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(431, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE SELLER";
            // 
            // SellerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(985, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private ListBox lstBoxSellerH;
        private ListBox lstSeller;
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
    }
}