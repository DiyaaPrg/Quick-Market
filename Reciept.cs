using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickMart
{
    public partial class Reciept : Form
    {

        public Reciept()
        {
            InitializeComponent();


            ManageCashBill();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateStartsLabel(Label lbstars, Label lbproduct)
        {


            lbstars.Location = new Point(lblStars.Location.X, lbproduct.Location.Y + lbproduct.Height);
            lbstars.Font = lblStars.Font;
            lbstars.AutoSize = false;
            lbstars.Height = 31;
            lbstars.Width = 327;

            lbstars.Text = lblStars.Text;

            this.Controls.Add(lbstars);
        }

        private void ManageCashBill()
        {
            DateTime date = new DateTime();

            date = DateTime.Now;

            lblDate.Text += date;

            Label lbProducts = new Label();

            lbProducts.Location = new Point(18, 154);
            lbProducts.Font = lbShop.Font;
            lbProducts.AutoSize = false;
            lbProducts.Height = 31;
            lbProducts.Width = 327;


            decimal totalPrice = 0;

            this.Controls.Add(lbProducts);

            string space = new string(' ', 32);


            foreach (stProduct product in DataStore.ProductsList)
            {
                lbProducts.Height += 30;


                string productinfo = $"{product.productName}  {space}  {product.quantity} × {product.price} DA";

                lbProducts.Text += $"{productinfo}\n";
                totalPrice += product.totalPrice;
            }

            Label lbFinalstars = new Label();
            CreateStartsLabel(lbFinalstars, lbProducts);


            int LocationOfPriceLabelX = lblStars.Right - 80;

            Label lblPrice = new Label();

            lblPrice.Location = new Point(lbProducts.Location.X, lbFinalstars.Location.Y + 30);
            lblPrice.Font = lbProducts.Font;
            lblPrice.AutoSize = false;
            lblPrice.Height = lbProducts.Height;
            lblPrice.Width = 100;

            lblPrice.Text = $"Total Price:";
            
            this.Controls.Add(lblPrice);


            // total price:
            Label lbDecimalTotalPrice = new Label();

            lbDecimalTotalPrice.Location = new Point(LocationOfPriceLabelX, lblPrice.Location.Y);
            lbDecimalTotalPrice.Font = lblPrice.Font;
            lbDecimalTotalPrice.AutoSize = false;
            lbDecimalTotalPrice.Height = lbProducts.Height;
            lbDecimalTotalPrice.Width = 100;

            lbDecimalTotalPrice.Text = $"{totalPrice} DA";
            this.Controls.Add(lbDecimalTotalPrice);

        }

        private void Reciept_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = $"X = {e.X} , Y = {e.Y}";
        }

        private void Reciept_Load(object sender, EventArgs e)
        {

        }
    }
}
