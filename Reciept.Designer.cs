namespace QuickMart
{
    partial class Reciept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblStars = new Label();
            lbShop = new Label();
            lbAddress = new Label();
            lblDate = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 31);
            label1.TabIndex = 0;
            label1.Text = "CASH RECEIPT";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // lblStars
            // 
            lblStars.Font = new Font("Segoe UI", 15F);
            lblStars.Location = new Point(35, 40);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(325, 19);
            lblStars.TabIndex = 1;
            lblStars.Text = "***********************************";
            lblStars.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbShop
            // 
            lbShop.Font = new Font("Segoe UI", 11F);
            lbShop.Location = new Point(16, 60);
            lbShop.Name = "lbShop";
            lbShop.Size = new Size(266, 31);
            lbShop.TabIndex = 2;
            lbShop.Text = "Shop: QuickMart Shop";
            // 
            // lbAddress
            // 
            lbAddress.Font = new Font("Segoe UI", 11F);
            lbAddress.Location = new Point(16, 82);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(327, 31);
            lbAddress.TabIndex = 3;
            lbAddress.Text = "Address: Bordj El Kiffan Algeirs, Algeria";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 11F);
            lblDate.Location = new Point(16, 104);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(327, 21);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date: ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(35, 125);
            label2.Name = "label2";
            label2.Size = new Size(308, 22);
            label2.TabIndex = 5;
            label2.Text = "***********************************";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Reciept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 717);
            Controls.Add(label2);
            Controls.Add(lblDate);
            Controls.Add(lbAddress);
            Controls.Add(lbShop);
            Controls.Add(lblStars);
            Controls.Add(label1);
            Name = "Reciept";
            Text = "Reciept";
            Load += Reciept_Load;
            MouseMove += Reciept_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblStars;
        private Label lbShop;
        private Label lbAddress;
        private Label lblDate;
        private Label label2;
    }
}