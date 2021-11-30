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
        string sellerColumns = "{0, 10}{1, 20}{2, 20}{3, 30}{4, 40}";
        string valueCol = "{0, 5}{1, 20}{2, 15}{3, 20}{4, 30}";
        private string loggedInUser;
        Seller seller = new Seller();
        IList<Category> _categories = new List<Category>();
        TruncateExt truncate = new TruncateExt();

        public SellerForm()
        {
            InitializeComponent();
        }
        

        private void SellerForm_Load(object sender, EventArgs e)
        {
            lstBoxSellerH.Items.Add(String.Format(sellerColumns, "ID", "Password", "Name", "Phone", "Age"));
            Application.DoEvents();

            if (isValidLogin())
            {
                loggedInUser = Backendless.UserService.LoggedInUserObjectId();
                var catClause = "ownerId = '" + loggedInUser + "'";


                try
                {
                    var whereClause = "role = 'SELLER'";
                    var queryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(whereClause);

                    var sellers = Backendless.Data.Of<BackendlessUser>().Find(queryBuilder);

                    foreach (var item in sellers)
                    {
                        lstSeller.Items.Add(String.Format(valueCol, truncate.Truncate(item.Email, 10), "12",
                            item.GetProperty("name").ToString(), item.GetProperty("Phone").ToString(), 
                            item.GetProperty("Age").ToString()));
                    }
                }
                catch (BackendlessException ex)
                {
                    MessageBox.Show(ex.BackendlessFault.Message);
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

        private void btnProductsClick(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void btnCategoryClick(object sender, EventArgs e)
        {
            this.Hide();
            Categories cat = new Categories();
            cat.Show();
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
                user.Password = txtSellerPassword.Text;
                user.SetProperty("Age", UInt16.Parse(txtSellerAge.Text));
                user.SetProperty("Phone", txtSellerPhone.Text);
                user.SetProperty("Name", txtSellerName.Text);
                user.SetProperty("Role", "SELLER");

                var results = Backendless.UserService.Register(user);
                lstSeller.Items.Add(
                    String.Format(sellerColumns, user.Email, user.Password, user.GetProperty("Name"), 
                    user.GetProperty("Phone"), user.GetProperty("Age")));
                //lstSeller.Items.Add(results);
                clear();

                MessageBox.Show("Successfully Added ", results.GetProperty("Name").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnEditSeller_Click(object senderr, EventArgs e)
        {

        }

        private void clear()
        {
            txtSellerId.Clear();
            txtSellerAge.Clear();
            txtSellerName.Clear();
            txtSellerPassword.Clear();
            txtSellerPhone.Clear();
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
                txtSellerPassword.Text = user.Password;
            }
            else
            {
                txtSellerName.Text = "NO DATA";
            }
        }
    }
}
