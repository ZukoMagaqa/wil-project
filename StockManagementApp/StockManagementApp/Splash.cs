using BackendlessAPI;
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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MyProgress.Value = startpoint;
            if(MyProgress.Value == 20)
            {
                MyProgress.Value = 0;
                if (!isValidLogin())
                {
                    timer1.Stop();
                    Form1 log = new Form1();
                    this.Hide();
                    log.Show();
                }
                else
                {
                    string id = Backendless.UserService.LoggedInUserObjectId();
                    var user = Backendless.Data.Of<BackendlessUser>().FindById(id);

                    switch (user.GetProperty("role").ToString())
                    {
                        case "ADMIN":
                            timer1.Stop();
                            SellerForm log = new SellerForm();
                            this.Hide();
                            log.Show();
                            break;
                        case "SELLER":
                            timer1.Stop();
                            SellingForm selling = new SellingForm();
                            this.Hide();
                            selling.Show();
                            break;
                        default:
                            break;
                    }
                }
                
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public bool isValidLogin()
        {
            return Backendless.UserService.IsValidLogin();
        }
    }
}
