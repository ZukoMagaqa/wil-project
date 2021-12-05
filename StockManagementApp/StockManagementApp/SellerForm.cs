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
    public partial class SellerForm : Form
    {
        string sellerColumns = "{0, 10}{1, 20}{2, 20}{3, 30}{4, 40}";
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
                        update(item);
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
                user.SetProperty("age", UInt16.Parse(txtSellerAge.Text));
                user.SetProperty("phone", txtSellerPhone.Text);
                user.SetProperty("name", txtSellerName.Text);
                user.SetProperty("role", "SELLER");
                user.SetProperty("mypassword", txtSellerPassword.Text);

                var results = Backendless.UserService.Register(user);

                update(results);
               
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

       

        public void update(BackendlessUser user)
        {
            //ADD COLUMN
            dtGrdSeller.ColumnCount = 6;

            dtGrdSeller.Columns[0].Name = "Email";
            dtGrdSeller.Columns[1].Name = "Password";
            dtGrdSeller.Columns[2].Name = "Name";
            dtGrdSeller.Columns[3].Name = "Age";
            dtGrdSeller.Columns[4].Name = "Phone";
            dtGrdSeller.Columns[5].Name = "Role";


            if (user == null)
            {
                return;
            }
            else
            {
                //ADD ROWS
                ArrayList row = new ArrayList();
                row.Add(user.Email);
                row.Add(user.GetProperty("mypassword").ToString() != null ? user.GetProperty("mypassword").ToString() : "");
                row.Add(user.GetProperty("name").ToString());
                row.Add(user.GetProperty("age").ToString());
                row.Add(user.GetProperty("phone").ToString());
                row.Add(user.GetProperty("role").ToString());
                dtGrdSeller.Rows.Add(row.ToArray());

                dtGrdSeller.BorderStyle = BorderStyle.None;
                dtGrdSeller.HorizontalScrollingOffset = 0;
            }
        }

        private void cellClickIndexChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex < getSellers().Count)
            {
                var user = getSellers()[e.RowIndex];


                if (user != null)
                {
                    // use the backendless object to populate the textbox.
                    txtSellerAge.Text = user.GetProperty("age").ToString();
                    txtSellerName.Text = user.GetProperty("name").ToString();
                    txtSellerPhone.Text = user.GetProperty("phone").ToString();
                    txtSellerPassword.Text = user.GetProperty("mypassword").ToString();
                    txtSellerId.Text = user.Email;
                }
                else
                {
                    txtSellerName.Text = "NO DATA";
                }
            }
        }
    }
}
