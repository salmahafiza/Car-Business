namespace CAR_Bussiness
{
    partial class CustomerVendorRelationship
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.RelationshipStartDate = new System.Windows.Forms.DateTimePicker();
            this.VendorID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CustomerID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CustomerVendorID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.RelationshipEndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.CarID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(467, 247);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "INSERT";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(534, 247);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton2.TabIndex = 1;
            this.materialFlatButton2.Text = "UPDATE";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(606, 247);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(60, 36);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "DELETE";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "VendorID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "RelationshipStartDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "CustomerID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "CustomerVendorID";
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "choose",
            "sold",
            "notsold"});
            this.Status.Location = new System.Drawing.Point(465, 206);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(201, 21);
            this.Status.TabIndex = 38;
            // 
            // RelationshipStartDate
            // 
            this.RelationshipStartDate.Location = new System.Drawing.Point(137, 158);
            this.RelationshipStartDate.Name = "RelationshipStartDate";
            this.RelationshipStartDate.Size = new System.Drawing.Size(205, 20);
            this.RelationshipStartDate.TabIndex = 37;
            // 
            // VendorID
            // 
            this.VendorID.Depth = 0;
            this.VendorID.Hint = "";
            this.VendorID.Location = new System.Drawing.Point(465, 159);
            this.VendorID.MouseState = MaterialSkin.MouseState.HOVER;
            this.VendorID.Name = "VendorID";
            this.VendorID.PasswordChar = '\0';
            this.VendorID.SelectedText = "";
            this.VendorID.SelectionLength = 0;
            this.VendorID.SelectionStart = 0;
            this.VendorID.Size = new System.Drawing.Size(201, 23);
            this.VendorID.TabIndex = 35;
            this.VendorID.UseSystemPasswordChar = false;
            // 
            // CustomerID
            // 
            this.CustomerID.Depth = 0;
            this.CustomerID.Hint = "";
            this.CustomerID.Location = new System.Drawing.Point(465, 114);
            this.CustomerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.PasswordChar = '\0';
            this.CustomerID.SelectedText = "";
            this.CustomerID.SelectionLength = 0;
            this.CustomerID.SelectionStart = 0;
            this.CustomerID.Size = new System.Drawing.Size(201, 23);
            this.CustomerID.TabIndex = 34;
            this.CustomerID.UseSystemPasswordChar = false;
            // 
            // CustomerVendorID
            // 
            this.CustomerVendorID.Depth = 0;
            this.CustomerVendorID.Hint = "";
            this.CustomerVendorID.Location = new System.Drawing.Point(137, 114);
            this.CustomerVendorID.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerVendorID.Name = "CustomerVendorID";
            this.CustomerVendorID.PasswordChar = '\0';
            this.CustomerVendorID.SelectedText = "";
            this.CustomerVendorID.SelectionLength = 0;
            this.CustomerVendorID.SelectionStart = 0;
            this.CustomerVendorID.Size = new System.Drawing.Size(205, 23);
            this.CustomerVendorID.TabIndex = 33;
            this.CustomerVendorID.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "RelationshipEndDate";
            // 
            // RelationshipEndDate
            // 
            this.RelationshipEndDate.Location = new System.Drawing.Point(137, 203);
            this.RelationshipEndDate.Name = "RelationshipEndDate";
            this.RelationshipEndDate.Size = new System.Drawing.Size(205, 20);
            this.RelationshipEndDate.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "CarID";
            // 
            // CarID
            // 
            this.CarID.Depth = 0;
            this.CarID.Hint = "";
            this.CarID.Location = new System.Drawing.Point(139, 247);
            this.CarID.MouseState = MaterialSkin.MouseState.HOVER;
            this.CarID.Name = "CarID";
            this.CarID.PasswordChar = '\0';
            this.CarID.SelectedText = "";
            this.CarID.SelectionLength = 0;
            this.CarID.SelectionStart = 0;
            this.CarID.Size = new System.Drawing.Size(205, 23);
            this.CarID.TabIndex = 47;
            this.CarID.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 162);
            this.dataGridView1.TabIndex = 49;
            // 
            // CustomerVendorRelationship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CarID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RelationshipEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.RelationshipStartDate);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.CustomerVendorID);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "CustomerVendorRelationship";
            this.Text = "CustomerVendorRelationship";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.DateTimePicker RelationshipStartDate;
        private MaterialSkin.Controls.MaterialSingleLineTextField VendorID;
        private MaterialSkin.Controls.MaterialSingleLineTextField CustomerID;
        private MaterialSkin.Controls.MaterialSingleLineTextField CustomerVendorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker RelationshipEndDate;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField CarID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}