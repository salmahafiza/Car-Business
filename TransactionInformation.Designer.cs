namespace CAR_Bussiness
{
    partial class TransactionInformation
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
            this.i = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.TransactionID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CarID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CustomerID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.VendorID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DateOfSale = new System.Windows.Forms.DateTimePicker();
            this.PaymentMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SalePrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.i.Depth = 0;
            this.i.Location = new System.Drawing.Point(440, 246);
            this.i.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.i.MouseState = MaterialSkin.MouseState.HOVER;
            this.i.Name = "i";
            this.i.Primary = false;
            this.i.Size = new System.Drawing.Size(59, 36);
            this.i.TabIndex = 0;
            this.i.Text = "INSERT";
            this.i.UseVisualStyleBackColor = true;
            this.i.Click += new System.EventHandler(this.i_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(507, 246);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "UPDATE";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(579, 246);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(60, 36);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "DELETE";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // TransactionID
            // 
            this.TransactionID.Depth = 0;
            this.TransactionID.Hint = "";
            this.TransactionID.Location = new System.Drawing.Point(162, 115);
            this.TransactionID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.PasswordChar = '\0';
            this.TransactionID.SelectedText = "";
            this.TransactionID.SelectionLength = 0;
            this.TransactionID.SelectionStart = 0;
            this.TransactionID.Size = new System.Drawing.Size(205, 23);
            this.TransactionID.TabIndex = 3;
            this.TransactionID.UseSystemPasswordChar = false;
            // 
            // CarID
            // 
            this.CarID.Depth = 0;
            this.CarID.Hint = "";
            this.CarID.Location = new System.Drawing.Point(490, 115);
            this.CarID.MouseState = MaterialSkin.MouseState.HOVER;
            this.CarID.Name = "CarID";
            this.CarID.PasswordChar = '\0';
            this.CarID.SelectedText = "";
            this.CarID.SelectionLength = 0;
            this.CarID.SelectionStart = 0;
            this.CarID.Size = new System.Drawing.Size(201, 23);
            this.CarID.TabIndex = 4;
            this.CarID.UseSystemPasswordChar = false;
            // 
            // CustomerID
            // 
            this.CustomerID.Depth = 0;
            this.CustomerID.Hint = "";
            this.CustomerID.Location = new System.Drawing.Point(490, 156);
            this.CustomerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.PasswordChar = '\0';
            this.CustomerID.SelectedText = "";
            this.CustomerID.SelectionLength = 0;
            this.CustomerID.SelectionStart = 0;
            this.CustomerID.Size = new System.Drawing.Size(201, 23);
            this.CustomerID.TabIndex = 5;
            this.CustomerID.UseSystemPasswordChar = false;
            // 
            // VendorID
            // 
            this.VendorID.Depth = 0;
            this.VendorID.Hint = "";
            this.VendorID.Location = new System.Drawing.Point(162, 202);
            this.VendorID.MouseState = MaterialSkin.MouseState.HOVER;
            this.VendorID.Name = "VendorID";
            this.VendorID.PasswordChar = '\0';
            this.VendorID.SelectedText = "";
            this.VendorID.SelectionLength = 0;
            this.VendorID.SelectionStart = 0;
            this.VendorID.Size = new System.Drawing.Size(205, 23);
            this.VendorID.TabIndex = 6;
            this.VendorID.UseSystemPasswordChar = false;
            // 
            // DateOfSale
            // 
            this.DateOfSale.Location = new System.Drawing.Point(162, 159);
            this.DateOfSale.Name = "DateOfSale";
            this.DateOfSale.Size = new System.Drawing.Size(205, 20);
            this.DateOfSale.TabIndex = 7;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.FormattingEnabled = true;
            this.PaymentMethod.Items.AddRange(new object[] {
            "Card",
            "Cheque",
            "Cash"});
            this.PaymentMethod.Location = new System.Drawing.Point(490, 202);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(201, 21);
            this.PaymentMethod.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "TransactionID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CarID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "DateOfSale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CustomerID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "VendorID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "PaymentMethod";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 157);
            this.dataGridView1.TabIndex = 15;
            // 
            // SalePrice
            // 
            this.SalePrice.Depth = 0;
            this.SalePrice.Hint = "";
            this.SalePrice.Location = new System.Drawing.Point(159, 245);
            this.SalePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.PasswordChar = '\0';
            this.SalePrice.SelectedText = "";
            this.SalePrice.SelectionLength = 0;
            this.SalePrice.SelectionStart = 0;
            this.SalePrice.Size = new System.Drawing.Size(205, 23);
            this.SalePrice.TabIndex = 16;
            this.SalePrice.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "SalePrice";
            // 
            // TransactionInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SalePrice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaymentMethod);
            this.Controls.Add(this.DateOfSale);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.CarID);
            this.Controls.Add(this.TransactionID);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.i);
            this.Name = "TransactionInformation";
            this.Text = "TransactionInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton i;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TransactionID;
        private MaterialSkin.Controls.MaterialSingleLineTextField CarID;
        private MaterialSkin.Controls.MaterialSingleLineTextField CustomerID;
        private MaterialSkin.Controls.MaterialSingleLineTextField VendorID;
        private System.Windows.Forms.DateTimePicker DateOfSale;
        private System.Windows.Forms.ComboBox PaymentMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField SalePrice;
        private System.Windows.Forms.Label label7;
    }
}