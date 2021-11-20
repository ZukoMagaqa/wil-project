using BackendlessAPI;
using BackendlessAPI.Async;
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
    public partial class Form1 : Form
    {
        Test test = new Test();
        string selectedRole = "";
        string username = "";
        string password = "";
        bool isValid = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRole = comboBox1.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginClick(object sender, EventArgs e)
        {

            if (validate())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                test.Name = username;
                test.Age = password;
                test.Role = selectedRole;

                AsyncCallback<Test> callback = new AsyncCallback<Test>(
                    result =>
                    {
                        MessageBox.Show("Successfully saved ${0}", result.Name);
                    },

                    fault =>
                    {
                        MessageBox.Show(fault.Message);
                    });
                Backendless.Data.Of<Test>().Save(test, callback);

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
    }

    public class Test
    {
      public string Name { get; set; }
      public string Age { get; set; }
        public string Role { get; set; }
    }
}
