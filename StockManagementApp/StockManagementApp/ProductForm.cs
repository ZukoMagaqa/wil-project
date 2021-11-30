using BackendlessAPI;
using StockManagementApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementApp
{
    public partial class ProductForm : Form
    {
        Product _product = new Product();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteProductClick(object sender, EventArgs e)
        {

        }

        private void btnRefreshClick(object sender, EventArgs e)
        {

        }

        private void selectedCategoryIndex(object sender, EventArgs e)
        {

        }

        private void btnAddProductClick(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Category = cmbBoxProduct.Text;
            product.Name = txtProdName.Text;
            product.Qauntity = Convert.ToInt32(txtProdQuantity.Text);
            product.Price = Convert.ToDouble(txtProdPrice.Text);

            if (product != null)
            {
                var prod = Backendless.Data.Of<Product>().Save(product);

                update(prod);
                
                Clear();
            }
        }

        private void Clear()
        {
            
        }

        private void btnEditProductClick(object sender, EventArgs e)
        {

        }

        private void btnSellerWinClick(object sender, EventArgs e)
        {
            this.Close();
            this.SuspendLayout();
            SellerForm seller = new SellerForm();
            seller.Show();
            seller.ResumeLayout();
        }

        private void btnCatWinClick(object sender, EventArgs e)
        {
            this.Close();
            this.SuspendLayout();
            Categories categories = new Categories();
            categories.Show();
            categories.ResumeLayout();
        }

        private void cmbBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            update(_product);
        }

        public void update(Product product)
        {
            //ADD COLUMN
            dtGrdProduct.ColumnCount = 4;
            dtGrdProduct.Columns[0].Name = "Name";
            dtGrdProduct.Columns[1].Name = "Quantity";
            dtGrdProduct.Columns[2].Name = "Category";
            dtGrdProduct.Columns[3].Name = "Price";


            if (product.Name == null && product.Qauntity == 0)
            {
                return;
            }
            else
            {
                //ADD ROWS
                ArrayList row = new ArrayList();
                row.Add(product.Name);
                row.Add(product.Qauntity);
                row.Add(product.Category);
                row.Add(product.Price);
                dtGrdProduct.Rows.Add(row.ToArray());

                //ADD BUTTON COLUMN
                //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                //button.HeaderText = "Click Me";
                //button.Name = "myButton";
                //button.Text = "Click Me";
                //button.UseColumnTextForButtonValue = true;
                //dtGrdProduct.Columns.Add(button);

                dtGrdProduct.BorderStyle = BorderStyle.None;
                dtGrdProduct.HorizontalScrollingOffset = 0;
            }
        }

    }
}
