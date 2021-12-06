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
        Seller seller = new Seller();
        IList<Category> _categories = new List<Category>();
        TruncateExt truncate = new TruncateExt();
        private IList<BackendlessUser> _sellers;

        public SellerForm()
        {
            InitializeComponent();
        }
        

        private void SellerForm_Load(object sender, EventArgs e)
        {
            Application.DoEvents();

            if (isValidLogin())
            {
                try
                {
                   getSellers();
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

            _sellers = Backendless.Data.Of<BackendlessUser>().Find(queryBuilder);

            dtGrdSeller.Rows.Clear();

            foreach (var item in _sellers)
            {
                update(item);
            }

            return _sellers;
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

                getSellers();
                clear();

                MessageBox.Show("Successfully Added ", results.GetProperty("name").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnEditSeller_Click(object senderr, EventArgs e)
        {
            int rowindex = dtGrdSeller.CurrentCell.RowIndex;
            if (rowindex == -1 && rowindex < _sellers.Count)
            {
                return;
            }
            else
            {

                seller.Name = txtSellerName.Text.Trim();
                seller.Email = txtSellerId.Text.Trim();
                seller.Age = Convert.ToInt32(txtSellerAge.Text);
                seller.MyPassword = txtSellerPassword.Text.Trim();
                seller.Phone = txtSellerPhone.Text;
                seller.ObjectId = _sellers[rowindex].ObjectId;

                if(txtSellerPassword.Text != _sellers[rowindex].GetProperty("mypassword").ToString())
                {
                    Backendless.UserService.RestorePassword(seller.Email);
                }

                var whereClause = "objectId = '" + seller.ObjectId + "'";

                MessageBox.Show("Successfully updated seller");
                Dictionary<string, object> dic = new Dictionary<string, object>();

                dic.Add("name", seller.Name);
                dic.Add("age", seller.Age);
                dic.Add("phone", seller.Phone);
                dic.Add("mypassword", seller.MyPassword);

                Backendless.Persistence.Of<BackendlessUser>().Update(whereClause, dic);

                DataGridViewRow newDataRow = dtGrdSeller.Rows[rowindex];
                newDataRow.Cells[0].Value = txtSellerId.Text;
                newDataRow.Cells[1].Value = txtSellerPassword.Text;
                newDataRow.Cells[2].Value = txtSellerName.Text;
                newDataRow.Cells[3].Value = txtSellerAge.Text;
                newDataRow.Cells[4].Value = txtSellerPhone.Text;
                newDataRow.Cells[5].Value = _sellers[rowindex].GetProperty("role").ToString();
                dtGrdSeller.Update();
                clear();       
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

                dtGrdSeller.Rows.Add(row.ToArray());;

                dtGrdSeller.BorderStyle = BorderStyle.None;
                dtGrdSeller.HorizontalScrollingOffset = 0;
            }
        }

        private void cellClickIndexChanged(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = dtGrdSeller.CurrentCell.RowIndex;

            if (rowindex != -1 && rowindex < _sellers.Count)
            {
                var user = _sellers[rowindex];


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
            else
            {
                clear();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int rowindex = dtGrdSeller.CurrentCell.RowIndex;

            if (rowindex == -1 && rowindex < _sellers.Count)
            {
                return;
            }
            else
            {
                seller.ObjectId = _sellers[rowindex].ObjectId;


                MessageBox.Show("Successfully deleted seller");
                var whereClasue = "objectId = '" + seller.ObjectId + "'";

                var catQueryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(whereClasue);
                Backendless.Persistence.Of<BackendlessUser>().Remove(whereClasue);

                dtGrdSeller.Rows.RemoveAt(rowindex);
                _sellers.RemoveAt(rowindex);
                dtGrdSeller.Update();
                clear();
            }
        }
    }
}
