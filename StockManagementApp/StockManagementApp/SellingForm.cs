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
    public partial class SellingForm : Form
    {
        Product _product = new Product();
        IList<Product> _products;
        IList<Selling> _sellings;
        int index;
        double total = 0;
        double overall = 0;
        string billNo;
        private string billTotal;
        private IList<Bill> bills;

        public SellingForm()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSelling();
            LoadBill();
        }

        private void LoadBill()
        {
            var loggedInUser = Backendless.UserService.LoggedInUserObjectId();

            var catClause = "ownerId = '" + loggedInUser + "'";
            var catQueryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(catClause);

            try
            {
                bills = Backendless.Data.Of<Bill>().Find(catQueryBuilder);

                dtGrdPrint.Rows.Clear();
                foreach (var bill in bills)
                {
                    updateBillRow(bill);
                }
            }
            catch (BackendlessException ex)
            {
                MessageBox.Show(ex.BackendlessFault.Message);
            }
        }

        private void closeSelling_Click(object sender, EventArgs e)
        {
            Application.Exit();
            BackendlessAPI.Backendless.UserService.Logout();
        }

        private void btnLogoutClick(object sender, EventArgs e)
        {
            Application.Exit();
            BackendlessAPI.Backendless.UserService.Logout();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bill = bills[index];

            string doc = "\t\t" + bill.sellerName +"'s"+ " Bill " + bill.billNo + "\t\t" + "\nDate: "+ bill.billDate + "\t\t" + "\n" + "Total Bill: " + bill.total;


            e.Graphics.DrawString(doc, new Font("Menlo", 12, FontStyle.Bold), Brushes.Blue, new PointF(50, 100));
        }

        private void btnPrintClick(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void cellProdSellerClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtGrdSellerProd.CurrentCell.RowIndex;
            index = rowIndex;

            if (rowIndex < _products.Count && rowIndex != -1)
            {
                LoadProducts();

                var product = _products[e.RowIndex];


                if (product != null)
                {
                    // use the backendless object to populate the textbox.
                    txtSellingBillId.Clear();
                    txtSellingQuantity.Clear();
                    txtSellingName.Text = product.Name.ToString();
                    txtSellingPrice.Text = product.Price.ToString();
                }
            }
            else
            {
                Clear();
            }
        }

        private void Clear()
        {
            txtSellingBillId.Clear();
            txtSellingName.Clear();
            txtSellingPrice.Clear();
            txtSellingQuantity.Clear();
        }

        private void LoadProducts()
        {
            string id = Backendless.UserService.LoggedInUserObjectId();
            var user = Backendless.Data.Of<BackendlessUser>().FindById(id);

            lblSeller.Text = user.GetProperty("name").ToString();


            var catClause = "ownerId = '" + user.GetProperty("ownerId").ToString() + "'";
            var catQueryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(catClause);

            try
            {

                _products = Backendless.Data.Of<Product>().Find(catQueryBuilder);
                dtGrdSellerProd.Rows.Clear();

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
            dtGrdSellerProd.ColumnCount = 2;
            dtGrdSellerProd.Columns[0].Name = "Name";
            dtGrdSellerProd.Columns[1].Name = "Price";


            if (product == null)
            {
                return;
            }
            else
            {
                //ADD ROWS
                ArrayList row = new ArrayList();
                row.Add(product.Name);
                row.Add(product.Price);
                dtGrdSellerProd.Rows.Add(row.ToArray());

                dtGrdSellerProd.BorderStyle = BorderStyle.None;
                dtGrdSellerProd.HorizontalScrollingOffset = 0;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProdClick(object sender, EventArgs e)
        {
            _product = _products[index];
            overall = 0;
            

            if (!String.IsNullOrEmpty(txtSellingQuantity.Text))
            {
               
                Selling selling = new Selling();

                selling.productId = _product.objectId;
                selling.Total = Int32.Parse(txtSellingQuantity.Text) * _product.Price;
                selling.Price = _product.Price;
                selling.Qauntity = Int32.Parse(txtSellingQuantity.Text);

                Backendless.Data.Of<Selling>().Save(selling);

                LoadSelling();
            }
        }

        public void LoadSelling()
        {

            var loggedInUser = Backendless.UserService.LoggedInUserObjectId();
            
            var catClause = "ownerId = '" + loggedInUser + "'";
            var catQueryBuilder = BackendlessAPI.Persistence.DataQueryBuilder.Create().SetWhereClause(catClause);

            try
            {
                _sellings = Backendless.Data.Of<Selling>().Find(catQueryBuilder);
                
                dtGrdSelling.Rows.Clear();
                overall = 0;

                foreach (var selling in _sellings)
                {
                    updateSellingRows(selling);
                }
            }
            catch (BackendlessException ex)
            {
                MessageBox.Show(ex.BackendlessFault.Message);
            }
        }
        public void updateSellingRows(Selling selling)
        {
            dtGrdSelling.ColumnCount = 5;
            dtGrdSelling.Columns[0].Name = "ProductId";
            dtGrdSelling.Columns[1].Name = "Name";
            dtGrdSelling.Columns[2].Name = "Price";
            dtGrdSelling.Columns[3].Name = "ProdQty";
            dtGrdSelling.Columns[4].Name = "Total";


            if (selling == null)
            {
                return;
            }
            else
            {
                var trunc = new TruncateExt();

                double totalSelling = selling.Price * selling.Qauntity;

                lblTotal.Font = new Font("Menlo", 15, FontStyle.Bold);
                overall = total += totalSelling;

                lblTotal.Text = "TOTAL R:" + overall;

                //ADD ROWS
                ArrayList row = new ArrayList();
                row.Add(trunc.Truncate(selling.productId, 5));
                row.Add(txtSellingName.Text);
                row.Add(selling.Price);
                row.Add(selling.Qauntity);
                row.Add(totalSelling);

                dtGrdSelling.Rows.Add(row.ToArray());

                dtGrdSelling.BorderStyle = BorderStyle.None;
                dtGrdSelling.HorizontalScrollingOffset = 0;
            }
        }

        public void updateBillRow(Bill bill)
        {
            dtGrdPrint.ColumnCount = 4;
            dtGrdPrint.Columns[0].Name = "BillNo";
            dtGrdPrint.Columns[1].Name = "Seller Name";
            dtGrdPrint.Columns[2].Name = "Date";
            dtGrdPrint.Columns[3].Name = "Total";


            if (bill == null)
            {
                return;
            }
            else
            {
                //ADD ROWS
                ArrayList row = new ArrayList();
                row.Add(bill.billNo);
                row.Add(bill.sellerName);
                row.Add(bill.billDate);
                row.Add(bill.total);

                dtGrdPrint.Rows.Add(row.ToArray());

                dtGrdPrint.BorderStyle = BorderStyle.None;
                dtGrdPrint.HorizontalScrollingOffset = 0;
            }
        }

        private void btnAddSellingListClick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            Bill bill = new Bill();

            bill.billNo = txtSellingBillId.Text;
            bill.sellerName = lblSeller.Text;
            bill.billDate = date.ToString("G");
            bill.total = Int32.Parse(billTotal);

            var billDb = Backendless.Data.Of<Bill>().Save(bill);
            LoadBill();
        }

        private void cellBillClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        protected void GenerateID()
        {
            string numbers = "12345";

            string characters = numbers;
            int length = 5;
            string id = string.Empty;
            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (id.IndexOf(character) != -1);
                id += character;
            }
            txtSellingBillId.Text = "B" + id;
        }

        private void cellSellingClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            var sell = _sellings[index];


            foreach (var prod in _products)
            { 
                if (sell.productId == prod.objectId)
                {
                    txtSellingName.Text = prod.Name;
                    txtSellingPrice.Text = dtGrdSelling.CurrentRow.Cells[2].Value.ToString();
                    txtSellingQuantity.Text = dtGrdSelling.CurrentRow.Cells[3].Value.ToString();
                    billTotal = dtGrdSelling.CurrentRow.Cells[4].Value.ToString();
                    GenerateID();
                }

            }
        }
    }
}
