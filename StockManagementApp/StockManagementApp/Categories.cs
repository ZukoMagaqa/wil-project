using BackendlessAPI;
using BackendlessAPI.Exception;
using StockManagementApp.Models;
using System;
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
    public partial class Categories : Form
    {
        string columns = "{0,5}{1, 35}{2,40}";
        TruncateExt truncate;
        IList<Category> list;

        public Categories()
        {
            InitializeComponent();
            truncate = new TruncateExt();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            var loggedInUser = Backendless.UserService.LoggedInUserObjectId();
            var catClause = "ownerId = '" + loggedInUser + "'";
            var catQueryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(catClause);

            lstBoxCategoriesH.Items.Add(String.Format(columns, "ID", "Name", "Description"));

            var categories = Backendless.Data.Of<Category>().Find(catQueryBuilder);
            list = categories;


            try
            {
                foreach (var category in categories)
                {
                    lstBoxCategories.Items.Add(String.Format(columns, truncate.Truncate(category.objectId, 5, "..."), category.Name, category.Description));
                }
            }
            catch (BackendlessException ex)
            {
                MessageBox.Show(ex.BackendlessFault.Message);
            }
        }

        private void btnProductWinClick(object sender, EventArgs e)
        {
            this.Close();
            this.SuspendLayout();
            ProductForm product = new ProductForm();
            product.Show();
            product.ResumeLayout();
        }

        private void btnSelllerWinClick(object sender, EventArgs e)
        {
            this.Close();
            this.SuspendLayout();
            SellerForm seller = new SellerForm();
            seller.Show();
            seller.ResumeLayout();
        }

        private void btnAddCatClick(object sender, EventArgs e)
        {
            Category category = new Category();

            category.Description = txtCatDesc.Text;
            category.Name = txtCatName.Text;

            if (category != null)
            {
                var cat = Backendless.Persistence.Of<Category>().Save(category);

                lstBoxCategories.Items.Add(String.Format(columns, truncate.Truncate(cat.objectId, 5), cat.Name, cat.Description));
                Clear();
            }
        }

        private void btnEditCatClick(object sender, EventArgs e)
        {
            if (lstBoxCategories.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Category category = new Category();

                category.Name = txtCatName.Text.Trim();
                category.Description = txtCatDesc.Text.Trim();
                category.objectId = list[lstBoxCategories.SelectedIndex].objectId;

                int index = lstBoxCategories.SelectedIndex;

                lstBoxCategories.Items.RemoveAt(index);
                lstBoxCategories.Items.Insert(index, String.Format(columns, truncate.Truncate(category.objectId, 5), category.Name, category.Description));
                
                Backendless.Persistence.Of<Category>().Save(category);
                MessageBox.Show("Successfully updated category");
                Clear();
            }
        }

        private void btnDeleteCatClick(object sender, EventArgs e)
        {
            if(lstBoxCategories.SelectedIndex == -1) 
            {
                return;
            }
            else
            {
                // Remove each item in reverse order to maintain integrity
                var selectedIndices = new List<int>(lstBoxCategories.SelectedIndices.Cast<int>());
                selectedIndices.Reverse();
                foreach (var index in selectedIndices)
                {
                    lstBoxCategories.Items.RemoveAt(index);

                    var catClause = "ownerId = '" + list[index].objectId + "'";
                    var catQueryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(catClause);

                    if (list[index].objectId == null)
                    {
                        MessageBox.Show("Category was not found with ID " + list[index].objectId);
                    }
                    Backendless.Data.Of<Category>().Remove(list[index]);
                }

                MessageBox.Show("Successfully deleted category");
            }
        }

        private void lstBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxCategories.SelectedIndex == -1)
            {
                Clear();
                return;
            }
            else
            {
                var category = list[lstBoxCategories.SelectedIndex];
                if (category != null)
                {
                    // use the backendless object to populate the textbox.
                    txtCatName.Text = category.Name;
                    txtCatDesc.Text = category.Description;
                }
            }
        }

        public void Clear()
        {
            txtCatDesc.Clear();
            txtCatName.Clear();
        }
    }
}
