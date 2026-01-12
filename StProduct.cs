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

    public struct stProduct
    {
        public string id;
        public string category;
        public string productName;
        public decimal price;
        public decimal quantity;
        public decimal totalPrice;
    };

    public static class DataStore
    {
        public static List<stProduct> ProductsList = new List<stProduct>();
    }

    public partial class StProduct : Form
    {
   
        public StProduct()
        {
            InitializeComponent();
        }

       

        private void StProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
