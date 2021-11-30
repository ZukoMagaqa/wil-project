using BackendlessAPI;
using BackendlessAPI.Async;
using BackendlessAPI.Exception;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementApp
{
    public partial class Form1 : Form
    {
        SellerForm seller;
        SellingForm sellingForm;

        string selectedRole = "";
        string username = "";
        string password = "";
        bool isValid = false;

        public string loggedInUser { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seller = new SellerForm();
            sellingForm = new SellingForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRole = cmbxRoles.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginClick(object sender, EventArgs e)
        {

            if (validate())
            {
                username = txtUsername.Text;
                password = txtPassword.Text;

                BackendlessUser user;

                try
                {
                    user = Backendless.UserService.Login(username.Trim(), password.Trim(), true);

                    this.Hide();

                    switch (user.GetProperty("role").ToString())
                    {
                        case "ADMIN":
                            this.Hide();
                            seller.Show();
                            break;
                        case "SELLER":
                            this.Hide();
                            sellingForm.Show();
                            break;
                        default:
                            break;
                    }
                }
                catch (BackendlessException exception)
                {
                    // login failed, to get the error code, use exception.Fault.FaultCode
                    MessageBox.Show("Sorry the ",exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Please make sure your fields are all filled");
            }
        }

        public bool validate()
        {
            username = txtUsername.Text;
            password = txtPassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(selectedRole))
            {
                return isValid = true;
            }
            return isValid;
        }

        private void clearLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbxRoles.Text = "Select Role";
        }
    }
}
