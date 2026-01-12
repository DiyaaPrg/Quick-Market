namespace QuickMart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnReciept = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            imageList1 = new ImageList(components);
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            notifyIcon1 = new NotifyIcon(components);
            groupBox3 = new GroupBox();
            lbProductUnit = new Label();
            label5 = new Label();
            cmbCategory = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            tbQuantity = new TextBox();
            label4 = new Label();
            lbPrice = new Label();
            label2 = new Label();
            cmbProductName = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReciept);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(5, 354);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 157);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actions";
            // 
            // btnReciept
            // 
            btnReciept.Enabled = false;
            btnReciept.FlatStyle = FlatStyle.Flat;
            btnReciept.Image = (Image)resources.GetObject("btnReciept.Image");
            btnReciept.Location = new Point(339, 49);
            btnReciept.Name = "btnReciept";
            btnReciept.Size = new Size(56, 51);
            btnReciept.TabIndex = 3;
            btnReciept.UseVisualStyleBackColor = true;
            btnReciept.Click += button1_Click_1;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Transparent;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.Enabled = false;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.Location = new Point(239, 49);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(56, 51);
            btnRemove.TabIndex = 2;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Enabled = false;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(139, 49);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(56, 51);
            btnEdit.TabIndex = 1;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 8F);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(39, 49);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(56, 51);
            btnAdd.TabIndex = 0;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Font = new Font("Segoe UI", 15F);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(525, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(876, 657);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Category";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Product";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price (per unit)";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Quantity";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Total Price";
            columnHeader6.Width = 200;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Milk.png");
            imageList1.Images.SetKeyName(1, "Bread.png");
            imageList1.Images.SetKeyName(2, "Sugar.png");
            imageList1.Images.SetKeyName(3, "Rice.png");
            imageList1.Images.SetKeyName(4, "Pasta.png");
            imageList1.Images.SetKeyName(5, "Cooking Oil.png");
            imageList1.Images.SetKeyName(6, "Cooking Oil5L.png");
            imageList1.Images.SetKeyName(7, "Salt.png");
            imageList1.Images.SetKeyName(8, "Egg.png");
            imageList1.Images.SetKeyName(9, "PlatEggs.png");
            imageList1.Images.SetKeyName(10, "Cheese.png");
            imageList1.Images.SetKeyName(11, "Cheese.png");
            imageList1.Images.SetKeyName(12, "Cheese.png");
            imageList1.Images.SetKeyName(13, "Cheese.png");
            imageList1.Images.SetKeyName(14, "Yougurt.png");
            imageList1.Images.SetKeyName(15, "Tea.png");
            imageList1.Images.SetKeyName(16, "Coffee.png");
            imageList1.Images.SetKeyName(17, "Mineral Water.png");
            imageList1.Images.SetKeyName(18, "Juice.png");
            imageList1.Images.SetKeyName(19, "Soft Drink.png");
            imageList1.Images.SetKeyName(20, "Biscuits.png");
            imageList1.Images.SetKeyName(21, "Chocolate.png");
            imageList1.Images.SetKeyName(22, "Potato Chips.png");
            imageList1.Images.SetKeyName(23, "Tuna.png");
            imageList1.Images.SetKeyName(24, "Sardines.png");
            imageList1.Images.SetKeyName(25, "Beef.png");
            imageList1.Images.SetKeyName(26, "Chiken.png");
            imageList1.Images.SetKeyName(27, "Fish.png");
            imageList1.Images.SetKeyName(28, "Potatoes.png");
            imageList1.Images.SetKeyName(29, "Tomatoes.png");
            imageList1.Images.SetKeyName(30, "Onions.png");
            imageList1.Images.SetKeyName(31, "Apples.png");
            imageList1.Images.SetKeyName(32, "Bananas.png");
            imageList1.Images.SetKeyName(33, "Oranges.png");
            imageList1.Images.SetKeyName(34, "Strawberries.png");
            imageList1.Images.SetKeyName(35, "Tissues.png");
            imageList1.Images.SetKeyName(36, "Floor Cleaner.png");
            imageList1.Images.SetKeyName(37, "Soap.png");
            imageList1.Images.SetKeyName(38, "Shampoo.png");
            imageList1.Images.SetKeyName(39, "Toothpaste.png");
            imageList1.Images.SetKeyName(40, "Toothbrush.png");
            imageList1.Images.SetKeyName(41, "Diapers.png");
            imageList1.Images.SetKeyName(42, "Wet Wipes.png");
            imageList1.Images.SetKeyName(43, "Garbage Bags.png");
            imageList1.Images.SetKeyName(44, "Insect Spray.png");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1, 536);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(482, 272);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "View";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(263, 92);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(58, 29);
            radioButton5.TabIndex = 4;
            radioButton5.Text = "List";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(263, 45);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(118, 29);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "Large Icon";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 142);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 29);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Tile";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(11, 92);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 29);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Small Icon";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 45);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Details";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbProductUnit);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(cmbCategory);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(tbQuantity);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(lbPrice);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cmbProductName);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Segoe UI", 15F);
            groupBox3.Location = new Point(5, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(465, 303);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Info";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lbProductUnit
            // 
            lbProductUnit.Font = new Font("Segoe UI", 20.25F);
            lbProductUnit.ForeColor = SystemColors.AppWorkspace;
            lbProductUnit.Location = new Point(142, 192);
            lbProductUnit.Name = "lbProductUnit";
            lbProductUnit.Size = new Size(151, 40);
            lbProductUnit.TabIndex = 21;
            lbProductUnit.Text = "Piece";
            lbProductUnit.Click += lbProductUnit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 202);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 20;
            label5.Text = "Product Unit:";
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 14F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Dairy & Eggs", "Bakery & Basics", "Grains & Pasta", "Oils", "Drinks", "Snacks", "Canned & Preserved", "Meat & Fish", "Fruits & Vegetables", "Cleaning & Hygiene" });
            cmbCategory.Location = new Point(199, 35);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(214, 33);
            cmbCategory.TabIndex = 19;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 35);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 18;
            label3.Text = "Category:";
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbQuantity
            // 
            tbQuantity.Cursor = Cursors.IBeam;
            tbQuantity.Font = new Font("Segoe UI", 13F);
            tbQuantity.Location = new Point(118, 247);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.ReadOnly = true;
            tbQuantity.Size = new Size(75, 31);
            tbQuantity.TabIndex = 16;
            tbQuantity.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 248);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 15;
            label4.Text = "Quantity:";
            // 
            // lbPrice
            // 
            lbPrice.Font = new Font("Segoe UI", 20.25F);
            lbPrice.ForeColor = SystemColors.AppWorkspace;
            lbPrice.Location = new Point(85, 141);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(151, 40);
            lbPrice.TabIndex = 14;
            lbPrice.Text = "0 DA";
            lbPrice.Click += lbPrice_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 151);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 13;
            label2.Text = "Price:";
            // 
            // cmbProductName
            // 
            cmbProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProductName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProductName.Font = new Font("Segoe UI", 14F);
            cmbProductName.FormattingEnabled = true;
            cmbProductName.Location = new Point(199, 85);
            cmbProductName.Name = "cmbProductName";
            cmbProductName.Size = new Size(214, 33);
            cmbProductName.TabIndex = 12;
            cmbProductName.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cmbProductName.QueryAccessibilityHelp += cmbProductName_QueryAccessibilityHelp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 85);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 11;
            label1.Text = "Product Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 749);
            Controls.Add(listView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "QuickMart";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnAdd;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnEdit;
        private Button btnRemove;
        private ImageList imageList1;
        private Button btnReciept;
        private ErrorProvider errorProvider1;
        private NotifyIcon notifyIcon1;
        private GroupBox groupBox3;
        private Label lbProductUnit;
        private Label label5;
        private ComboBox cmbCategory;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox tbQuantity;
        private Label label4;
        private Label lbPrice;
        private Label label2;
        private ComboBox cmbProductName;
        private Label label1;
    }
}
