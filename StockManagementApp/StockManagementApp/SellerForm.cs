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
    public partial class SellerForm : Form
    {
        string columns = "{0, -10}{1, -20}{2, -20}";
        string sellerColumns = "{0, -10}{1, -20}{2, -20}{3, -30}{4, -40}";
        private string loggedInUser;
        Seller seller = new Seller();
        IList<Category> _categories = new List<Category>();
        int count = 0;

        public SellerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            //lstBoxOutput.Items.Add(String.Format(columns, "ID", "CatName", "CatDescription"));
            //lstSeller.Items.Add(String.Format(sellerColumns, "ID", "Password", "Name", "Phone", "Age"));
            panel2.Visible = true;
            Application.DoEvents();

            if (isValidLogin())
            {
                loggedInUser = Backendless.UserService.LoggedInUserObjectId();
                var catClause = "ownerId = '" + loggedInUser + "'";
                var catQueryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(catClause);

                var categories = Backendless.Data.Of<Category>().Find(catQueryBuilder);
                _categories = categories;


                //try
                //{
                //    var cats = Backendless.Persistence.Of<Category>().Find();
                //}
                //catch (BackendlessException ex)
                //{
                //    MessageBox.Show(ex.BackendlessFault.Message);
                //}



                foreach (var category in categories)
                {
                    lstBoxOutput.Items.Add(String.Format(columns, category.objectId, category.Name, category.Description));
                }

                var whereClause = "role = 'SELLER'";
                var queryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(whereClause);

                var sellers = Backendless.Data.Of<BackendlessUser>().Find(queryBuilder);

                foreach (var item in sellers)
                {
                    lstSeller.Items.Add(String.Format(sellerColumns, item.Email, "12",
                        item.GetProperty("name").ToString(), item.GetProperty("Phone").ToString(), item.GetProperty("Age").ToString()));
                }
            }

            
        }

        public IList<BackendlessUser> getSellers()
        {
            var whereClause = "role = 'SELLER'";
            var queryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(whereClause);

            var sellers = BackendlessAPI.Backendless.Data.Of<BackendlessUser>().Find(queryBuilder);

            return sellers;
        }


        public bool isValidLogin()
        {
            return Backendless.UserService.IsValidLogin();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProductsClick(object sender, EventArgs e)
        {
            panel1.Visible = panel1.Visible;
            panel2.Visible = false;
            Application.DoEvents();
        }

        private void btnCategoryClick(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            panel1.Visible = false;
            Application.DoEvents();
        }

        private void btnAddCategoryClick(object sender, EventArgs e)
        {
            Category category = new Category();

            category.Description = txtCatDesc.Text;
            category.Name = txtCatName.Text;

            if (category != null)
            {
               var cat =  Backendless.Persistence.Of<Category>().Save(category);

                lstBoxOutput.Items.Add(String.Format(columns, cat.objectId, cat.Name, cat.Description));

            }

            
        }

        private void btnEditCategoryClick(object sender, EventArgs e)
        {

        }

        private void btnDeleteCategory(object sender, EventArgs e)
        {

        }

        private void lstBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = _categories[lstBoxOutput.SelectedIndex];


            if(category != null)
            {
                // use the backendless object to populate the textbox.
                txtCatName.Text = category.Name;
                txtCatDesc.Text = category.Description;
                txtCatId.Text = category.objectId;
            }
        }

        private void sellerCloseClick(object sender, EventArgs e)
        {
            Application.Exit();
            BackendlessAPI.Backendless.UserService.Logout();
        }

        private void btnLogoutClick(object sender, EventArgs e)
        {
            Backendless.UserService.Logout();
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            BackendlessUser user = new BackendlessUser();


            try
            {
                user.Email = txtSellerId.Text;
                user.Password = txtSellerId.Text;
                user.SetProperty("Age", UInt16.Parse(txtSellerAge.Text));
                user.SetProperty("Phone", txtSellerPhone.Text);
                user.SetProperty("Name", txtSellerName.Text);
                user.SetProperty("Role", "SELLER");

                var results = Backendless.UserService.Register(user);
                lstSeller.Items.Add(
                    String.Format(sellerColumns, user.Email, user.Password, user.GetProperty("Name"), 
                    user.GetProperty("Phone"), user.GetProperty("Age")));
                lstSeller.Items.Add(results);
                clear();

                MessageBox.Show("Successfully Added ", results.GetProperty("Name").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clear()
        {
            txtSellerId.Clear();
            txtSellerAge.Clear();
            txtSellerName.Clear();
            txtSellerPassword.Clear();
            txtSellerPhone.Clear();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void lstSeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = getSellers()[lstSeller.SelectedIndex];


            if (user != null)
            {
                // use the backendless object to populate the textbox.
                txtSellerAge.Text = user.GetProperty("Age").ToString();
                txtSellerName.Text = user.GetProperty("name").ToString();
                txtSellerPhone.Text = user.GetProperty("Phone").ToString();
                txtSellerId.Text = user.ObjectId;
            }
            else
            {
                txtSellerName.Text = "NO DATA";
            }
        }
    }
}
