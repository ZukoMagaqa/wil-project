using BackendlessAPI;
using BackendlessAPI.Exception;
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
        IList<Product> _products;
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
            int rowindex = dtGrdProduct.CurrentCell.RowIndex;

            if (rowindex == -1 && rowindex < _products.Count)
            {
                return;
            }
            else
            {
                _product.objectId = _products[rowindex].objectId;


                MessageBox.Show("Successfully deleted product");
                var whereClasue = "objectId = '" + _product.objectId + "'";

                var catQueryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(whereClasue);
                Backendless.Persistence.Of<Product>().Remove(whereClasue);

                dtGrdProduct.Rows.RemoveAt(rowindex);
                _products.RemoveAt(rowindex);
                dtGrdProduct.Update();
                
                Clear();
            }
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

            if (!string.IsNullOrEmpty(txtProdName.Text.Trim()) || Convert.ToInt32(txtProdPrice.Text) >= 0 || Convert.ToInt32(txtProdPrice.Text) >= 0 || cmbBoxProduct.Text != "Select Category")
            {
                product.Category = cmbBoxProduct.Text;
                product.Name = txtProdName.Text;
                product.Qauntity = Convert.ToInt32(txtProdQuantity.Text);
                product.Price = Convert.ToDouble(txtProdPrice.Text);

                if (product != null)
                {
                    var prod = Backendless.Data.Of<Product>().Save(product);

                    MessageBox.Show("Successfully added a product");
                    LoadProducts();
                    dtGrdProduct.Update();

                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Please some field");
            }
        }

        private void Clear()
        {
            txtProdName.Clear();
            txtProdPrice.Clear();
            txtProdQuantity.Clear();
            cmbBoxProduct.Text = "Select Category";
        }

        private void btnEditProductClick(object sender, EventArgs e)
        {
            int rowindex = dtGrdProduct.CurrentCell.RowIndex;
            if (rowindex == -1 && rowindex < _products.Count)
            {
                return;
            }
            else
            {
                Product prod = new Product();

                prod.Name = txtProdName.Text.Trim();
                prod.Price = Convert.ToDouble(txtProdPrice.Text);
                prod.Qauntity = Convert.ToInt32(txtProdQuantity.Text);
                prod.Category = cmbBoxProduct.Text.Trim();
                prod.objectId = _products[rowindex].objectId;

                
                
                MessageBox.Show("Successfully updated product");
                Backendless.Persistence.Of<Product>().Save(prod);
                LoadProducts();
                //dtGrdProduct.Rows.RemoveAt(rowindex);

                //DataGridViewRow newDataRow = dtGrdProduct.Rows[rowindex];
                
                //newDataRow.Cells[0].Value = txtProdName.Text;
                //newDataRow.Cells[1].Value = txtProdQuantity.Text;
                //newDataRow.Cells[3].Value = txtProdPrice.Text;
                //newDataRow.Cells[2].Value = cmbBoxProduct.Text;
                
                //_products.Insert(rowindex, prod);
                dtGrdProduct.Update();

                Clear();
            }
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
            LoadProducts();
        }

        public void LoadProducts()
        {
            var loggedInUser = Backendless.UserService.LoggedInUserObjectId();
            var catClause = "ownerId = '" + loggedInUser + "'";
            var catQueryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(catClause);

            try
            {

                _products = Backendless.Data.Of<Product>().Find(catQueryBuilder);
                dtGrdProduct.Rows.Clear();
                foreach (var product in _products)
                {
                    updateRow(product);
                }
            }
            catch (BackendlessException ex)
            {
                MessageBox.Show(ex.BackendlessFault.Message);
            }
        }

        public void updateRow(Product product)
        {
            //ADD COLUMN
            dtGrdProduct.ColumnCount = 4;
            dtGrdProduct.Columns[0].Name = "Name";
            dtGrdProduct.Columns[1].Name = "Quantity";
            dtGrdProduct.Columns[2].Name = "Category";
            dtGrdProduct.Columns[3].Name = "Price";


            if (product == null)
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

                dtGrdProduct.BorderStyle = BorderStyle.None;
                dtGrdProduct.HorizontalScrollingOffset = 0;
            }
        }
        private void cellClickIndexChanged(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex < _products.Count && e.RowIndex != -1)
            {
                LoadProducts();

                var product = _products[e.RowIndex];


                if (product != null)
                {
                    // use the backendless object to populate the textbox.
                    txtProdName.Text = product.Name;
                    txtProdPrice.Text = product.Price.ToString();
                    txtProdQuantity.Text = product.Qauntity.ToString();
                    cmbBoxProduct.Text = product.Category;
                }
                else
                {
                    txtProdName.Text = "NO DATA";
                }
            }
            else
            {
                Clear();
            }
        }
    }
}
