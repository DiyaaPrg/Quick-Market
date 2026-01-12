using QuickMart.Properties;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace QuickMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private short id = 1;

        private decimal firstquantity;

        Dictionary<string, decimal> productQuantities = new Dictionary<string, decimal>
{
    { "Milk", 50 },
    { "Bread", 140},
    { "Sugar", 50 },
    { "Rice", 50 },
    { "Pasta", 50 },
    { "Cooking Oil 2L", 40},
    { "Cooking Oil 5L", 30},
    { "Salt", 100 },
    { "Egg", 20*30 },
    { "PlatEggs", 20 },
    { "Cheese 8", 40 },
    { "Cheese 16", 35 },
    { "Cheese 32", 30},
    { "Cheese 24", 30},
    { "Yogurt", 120 },
    { "Tea", 50 },
    { "Coffee", 50 },
    { "Mineral Water", 70 },
    { "Juice", 45 },
    { "Soft Drink", 45 },
    { "Biscuits", 90 },
    { "Chocolate", 70},
    { "Potato Chips", 50},
    { "Tuna", 40 },
    { "Sardines", 30 },
    { "Beef", 20 },
    { "Chicken", 30 },
    { "Fish", 30 },
    { "Potatoes", 50 },
    { "Tomatoes", 50 },
    { "Onions", 50 },
    { "Apples", 15 },
    { "Bananas",  20},
    { "Oranges", 30 },
    { "Strawberries", 15 },
    { "Tissues", 15 },
    { "Floor Cleaner", 20 },
    { "Soap", 20 },
    { "Shampoo", 20 },
    { "Toothpaste", 20 },
    { "Toothbrush", 20 },
    { "Diapers", 20 },
    { "Wet Wipes", 20 },
    { "Garbage Bags", 20 },
    { "Insect Spray", 20 }
};

        Dictionary<string, decimal> productsPrices = new Dictionary<string, decimal>
        {
        { "Milk", 25m },
        { "Bread", 20m },
        { "Sugar", 110m },
        { "Rice", 180m },
        { "Pasta", 90m },
        { "Cooking Oil 2L", 250m },
        { "Cooking Oil 5L", 550m },
        { "Salt", 30m },
        { "Egg", 20m },
        { "PlatEggs", 450m },
        { "Cheese 8", 80m },
        { "Cheese 16", 160m },
        { "Cheese 32", 320m },
        { "Cheese 24", 240m },
        {"Yogurt", 30m },
        { "Tea", 400m },
        { "Coffee", 200m },
        { "Mineral Water", 40m },
        { "Juice", 120m },
        { "Soft Drink", 120m },
        { "Biscuits", 80m },
        { "Chocolate", 150m },
        { "Potato Chips", 50m },
        { "Tuna", 150m },
        { "Sardines", 300m },

        { "Beef", 1800m },
        { "Chicken", 420m },
        { "Fish", 900m },
        { "Potatoes", 70m },
        { "Tomatoes", 90m },
        { "Onions", 60m },
        { "Apples", 180m },
        { "Bananas", 450m },
        { "Oranges", 120m },
        { "Strawberries", 350m },

        { "Tissues", 120m },
        { "Floor Cleaner", 450m },
        { "Soap", 70m },
        { "Shampoo", 350m },
        { "Toothpaste", 260m },
        { "Toothbrush", 150m },
        { "Diapers", 3200m },
        { "Wet Wipes", 350m },
        { "Garbage Bags", 220m },
        { "Insect Spray", 650m }
};

        Dictionary<string, List<string>> categorizedProducts = new Dictionary<string, List<string>>
    {
         // 🥛 Dairy & Eggs
        {
          "Dairy & Eggs",
           new List<string>
           {
            "Milk",
            "Yogurt",
            "Egg",
            "PlatEggs",
            "Cheese 8",
            "Cheese 16",
            "Cheese 24",
            "Cheese 32"
           }
        },

    // 🍞 Bakery & Basics
        {
        "Bakery & Basics",
        new List<string>
        {
            "Bread",
            "Sugar",
            "Salt"
        }
        },

    // 🌾 Grains & Pasta
        {
        "Grains & Pasta",
        new List<string>
        {
            "Rice",
            "Pasta"
        }
        },

    // 🛢️ Oils
        {
        "Oils",
        new List<string>
        {
            "Cooking Oil 2L",
            "Cooking Oil 5L"
        }
        },

    // 🥤 Drinks
        {
        "Drinks",
        new List<string>
        {
            "Mineral Water",
            "Juice",
            "Soft Drink",
            "Tea",
            "Coffee"
        }
        },

    // 🍪 Snacks
        {
        "Snacks",
        new List<string>
        {
            "Biscuits",
            "Chocolate",
            "Potato Chips"
        }
        },

    // 🐟 Canned & Preserved
        {
        "Canned & Preserved",
        new List<string>
        {
            "Tuna",
            "Sardines"
        }
        },

    // 🥩 Meat & Fish
        {
        "Meat & Fish",
        new List<string>
        {
            "Beef",
            "Chicken",
            "Fish"
        }
        },

    // 🥕 Fruits & Vegetables
        {
        "Fruits & Vegetables",
        new List<string>
        {
            "Potatoes",
            "Tomatoes",
            "Onions",
            "Apples",
            "Bananas",
            "Oranges",
            "Strawberries"
        }
        },

    // 🧼 Cleaning & Hygiene
        {
        "Cleaning & Hygiene",
        new List<string>
        {
            "Tissues",
            "Floor Cleaner",
            "Soap",
            "Shampoo",
            "Toothpaste",
            "Toothbrush",
            "Diapers",
            "Wet Wipes",
            "Garbage Bags",
            "Insect Spray"
        }
        }
};

        Dictionary<string, string> productUnits = new Dictionary<string, string>
{
    // 🥛 Dairy & Eggs
    { "Milk", "Liter" },
    { "Yogurt", "Piece" },
    { "Egg", "Piece" },
    { "PlatEggs", "Plate" },
    { "Cheese 8", "Piece" },
    { "Cheese 16", "Piece" },
    { "Cheese 24", "Piece" },
    { "Cheese 32", "Piece" },

     //🍞 Bakery & Basics
    { "Bread", "Piece" },
    { "Sugar", "Kilogram" },
    { "Salt", "Kilogram" },

    // 🌾 Grains & Pasta
    { "Rice", "Kilogram" },
    { "Pasta", "Piece" },

    // 🛢️ Oils
    { "Cooking Oil 2L", "Piece" },
    { "Cooking Oil 5L", "Piece" },

    // 🥤 Drinks
    { "Mineral Water", "Liter" },
    { "Juice", "Liter" },
    { "Soft Drink", "Liter" },
    { "Tea", "Piece" },
    { "Coffee", "Piece" },

    // 🍪 Snacks
    { "Biscuits", "Piece" },
    { "Chocolate", "Piece" },
    { "Potato Chips", "Piece" },

    // 🐟 Canned & Preserved
    { "Tuna", "Piece" },
    { "Sardines", "Piece" },

    // 🥩 Meat & Fish
    { "Beef", "Kilogram" },
    { "Chicken", "Kilogram" },
    { "Fish", "Kilogram" },

    // 🥕 Fruits & Vegetables
    { "Potatoes", "Kilogram" },
    { "Tomatoes", "Kilogram" },
    { "Onions", "Kilogram" },
    { "Apples", "Kilogram" },
    { "Bananas", "Kilogram" },
    { "Oranges", "Kilogram" },
    { "Strawberries", "Kilogram" },

    // 🧼 Cleaning & Hygiene
    { "Tissues", "Piece" },
    { "Floor Cleaner", "Liter" },
    { "Soap", "Piece" },
    { "Shampoo", "Piece" },
    { "Toothpaste", "Piece" },
    { "Toothbrush", "Piece" },
    { "Diapers", "Pack" },
    { "Wet Wipes", "Pack" },
    { "Garbage Bags", "Pack" },
    { "Insect Spray", "Piece" }
};


        private bool IsProductQuantityAvailable(string productname, decimal count)
        {
            return (count <= productQuantities[productname]) ? true : false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cmbProductName.Text))
            {

                decimal quantity = Convert.ToDecimal(tbQuantity.Text);

                if (IsProductQuantityAvailable(cmbProductName.Text, quantity))
                {
                    quantity += 1;
                }

                tbQuantity.Text = quantity.ToString();

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbQuantity.ReadOnly = false;
            if (!string.IsNullOrEmpty(lbPrice.Text))
            {
                lbPrice.Text = $"{productsPrices[cmbProductName.Text].ToString()} DA";
                lbProductUnit.Text = productUnits[cmbProductName.Text.Trim()];

            }


        }

        public bool IsNumericWithDecimal(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // السماح برقم واحد فقط مع فاصلة عشرية أو نقطة
            bool hasDecimalSeparator = false;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    continue;
                }
                else if (c == '.' || c == ',') // السماح بنقطة أو فاصلة
                {
                    // checking that the product isn't pieces, so . isn't allowed:
                    if (lbProductUnit.Text == "Piece" || lbProductUnit.Text == "Pack")
                    {
                        MessageBox.Show("You cannot Buy a product of pieces with decimal quantities", "QuickMart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;

                    }

                    if (hasDecimalSeparator) // إذا كان هناك فاصلة مسبقاً
                        return false;

                    hasDecimalSeparator = true;
                }

                else
                {
                    return false; // أي حرف آخر غير مسموح
                }
            }

            return true;
        }

        private bool IsProductRelevantToCategory()
        {
            // may be improved lately
            foreach (string item in categorizedProducts[cmbCategory.Text])
            {
                if (cmbProductName.Text == item)
                {
                    return true;
                }
            }
            return false;
        }

        private void SetDefaultValues()
        {
            cmbCategory.Text = "";
            cmbProductName.Text = "";
            cmbProductName.Items.Clear();
            lbPrice.Text = "0 DA";
            lbProductUnit.Text = "Piece";

            tbQuantity.ReadOnly = true;
            tbQuantity.Text = "0";
        }

        private bool AreValuesCorrect()
        {

            if (!IsProductRelevantToCategory())
            {
                MessageBox.Show("Product and Category are not Relevant", "QuickMat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // Check that the quantity is set and not empty
            if (Convert.ToDecimal(tbQuantity.Text) <= 0)
            {
                MessageBox.Show($"Please Enter an Amount", "QuickMart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // check that quantity is available
            if (!IsProductQuantityAvailable(cmbProductName.Text.Trim(), Convert.ToDecimal(tbQuantity.Text)))
            {
                MessageBox.Show($"This Amount is not available in the store!\nThe Available Amount: {productQuantities[cmbProductName.Text]}", "QuickMart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }



            else
                return true;
        }

        private short FindKeyIndex()
        {
            short i = 0;
            foreach (var key in productQuantities.Keys)
            {
                if (key == cmbProductName.Text)
                {
                    return i;
                }

                ++i;

            }

            return i;
        }

        private stProduct FillProductWithData()
        {
            stProduct product;

            product.id = ($"{id:D3}");
            product.category = cmbCategory.Text;
            product.productName = cmbProductName.Text.Trim();
            product.price = Convert.ToDecimal(productsPrices[product.productName]);
            product.quantity = Convert.ToDecimal(tbQuantity.Text);

            decimal TotalProductPrice = productsPrices[cmbProductName.Text.Trim()] * (Convert.ToDecimal(tbQuantity.Text));

            product.totalPrice = TotalProductPrice;

            DataStore.ProductsList.Add(product);

            return product;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // check that product and type are relevant:
            if (AreValuesCorrect())
            {
                stProduct product = FillProductWithData();

                ListViewItem item = new ListViewItem(product.id);

                item.ImageIndex = FindKeyIndex();

                item.SubItems.Add(product.category);
                item.SubItems.Add(product.productName);
                item.SubItems.Add($"{product.price.ToString()} DA");
                item.SubItems.Add($"{product.quantity} {lbProductUnit.Text}s");
                item.SubItems.Add($"{product.totalPrice} DA");
                listView1.Items.Add(item);

                id += 1;

                // decrease the amount of the product:
                productQuantities[cmbProductName.Text.Trim()] -= Convert.ToDecimal(tbQuantity.Text);

                btnReciept.Enabled = true;

                // set values default:
                SetDefaultValues();
                return;
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;

        }

        private string ExtractDigitsFromString(string text)
        {
            string digits = "";
            foreach (char c in text)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    digits += c;
                }


            }
            return digits;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (!e.IsSelected)
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
                return;
            }
            // fill the data with the item (subitems):
            if (listView1.SelectedItems.Count == 0)
            {
                btnReciept.Enabled = false;
                MessageBox.Show("No item selected", "QuickMart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;

            tbQuantity.ReadOnly = false;

            ListViewItem selectedItem = listView1.SelectedItems[0];
            // here you can extract data from the list, just by ID

            cmbCategory.Text = selectedItem.SubItems[1].Text;
            cmbProductName.Text = selectedItem.SubItems[2].Text;
            lbProductUnit.Text = productUnits[cmbProductName.Text];
            lbPrice.Text = $"{selectedItem.SubItems[3].Text}";
            tbQuantity.Text = (ExtractDigitsFromString(selectedItem.SubItems[4].Text));

            // رجع السلعة المأخوذة من المتجر
            firstquantity = Convert.ToDecimal(tbQuantity.Text);
            productQuantities[cmbProductName.Text] += firstquantity;
        }

        private stProduct EditProductData(ListViewItem item)
        {

            stProduct product = DataStore.ProductsList[0]; // just to avoid bug of return;

            for (short i = 0; i < DataStore.ProductsList.Count; ++i)
            {
                product = DataStore.ProductsList[i];

                if (product.id == item.SubItems[0].Text)
                {
                    product.category = cmbCategory.Text;
                    product.productName = cmbProductName.Text;
                    product.price = Convert.ToDecimal(productsPrices[product.productName]);
                    product.quantity = Convert.ToDecimal(tbQuantity.Text);

                    decimal TotalProductPrice = productsPrices[cmbProductName.Text.Trim()] * (Convert.ToDecimal(tbQuantity.Text));

                    product.totalPrice = TotalProductPrice;

                    DataStore.ProductsList[i] = product;
                    return product;

                }
            }
            return product;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            if (AreValuesCorrect())
            {
                ListViewItem item = listView1.SelectedItems[0];

                stProduct product = EditProductData(item);

                item.SubItems[1].Text = product.category;
                item.SubItems[2].Text = product.productName;
                item.SubItems[3].Text = ($"{product.price.ToString()} DA");
                item.SubItems[4].Text = ($"{product.quantity} {lbProductUnit.Text}s");
                item.SubItems[5].Text = ($"{product.totalPrice} DA");


                // decrease the amount of the product:
                productQuantities[cmbProductName.Text] -= (Convert.ToDecimal(tbQuantity.Text));

                item.ImageIndex = FindKeyIndex();

                tbQuantity.ReadOnly = true;
                SetDefaultValues();
            }



        }

        private void RemoveProductFromList(ListViewItem item)
        {
            for (int i = DataStore.ProductsList.Count - 1; i >= 0; --i)
            {
                if (DataStore.ProductsList[i].id == item.SubItems[0].Text)
                {
                    DataStore.ProductsList.RemoveAt(i);
                    break;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                RemoveProductFromList(listView1.SelectedItems[0]);

                listView1.Items.Remove(listView1.SelectedItems[0]);


                SetDefaultValues();

            }



            if (listView1.Items.Count <= 0)
            {
                btnReciept.Enabled = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true; // to appear in the tray
            notifyIcon1.Text = "QuickMart"; // the text that appear when the mouse 
            //notifyIcon1.Icon = ImageToIcon(WindowsFormsApp2.Properties.Resources.Facebook_icon);
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "QuicMart";
            notifyIcon1.BalloonTipText = "Your Order is Confirmed! Check The prices in The Bill";
            notifyIcon1.ShowBalloonTip(1000);

            Form frm = new Reciept();
            frm.ShowDialog();


        }

        private void tbQuantity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsNumericWithDecimal(tbQuantity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbQuantity, "Quantity Should be a number not a text!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbQuantity, "");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProductName.Items.Clear();

            if (!categorizedProducts.ContainsKey(cmbCategory.Text))
                return;

            List<string> ProductsOfCategory = categorizedProducts[cmbCategory.Text];

            cmbProductName.Items.AddRange(ProductsOfCategory.ToArray());
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cmbProductName_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void lbProductUnit_Click(object sender, EventArgs e)
        {

        }
    }
}
