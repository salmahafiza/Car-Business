namespace CAR_Bussiness
{
    partial class Vendor
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
            this.VendorID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.VendorName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Contact = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Address = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Commission = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new MaterialSkin.Controls.MaterialFlatButton();
            this.Submit = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // VendorID
            // 
            this.VendorID.Depth = 0;
            this.VendorID.Hint = "";
            this.VendorID.Location = new System.Drawing.Point(221, 104);
            this.VendorID.MouseState = MaterialSkin.MouseState.HOVER;
            this.VendorID.Name = "VendorID";
            this.VendorID.PasswordChar = '\0';
            this.VendorID.SelectedText = "";
            this.VendorID.SelectionLength = 0;
            this.VendorID.SelectionStart = 0;
            this.VendorID.Size = new System.Drawing.Size(114, 23);
            this.VendorID.TabIndex = 0;
            this.VendorID.Text = "Update/Delete";
            this.VendorID.UseSystemPasswordChar = false;
            this.VendorID.Click += new System.EventHandler(this.VendorID_Click);
            // 
            // VendorName
            // 
            this.VendorName.Depth = 0;
            this.VendorName.Hint = "";
            this.VendorName.Location = new System.Drawing.Point(465, 104);
            this.VendorName.MouseState = MaterialSkin.MouseState.HOVER;
            this.VendorName.Name = "VendorName";
            this.VendorName.PasswordChar = '\0';
            this.VendorName.SelectedText = "";
            this.VendorName.SelectionLength = 0;
            this.VendorName.SelectionStart = 0;
            this.VendorName.Size = new System.Drawing.Size(114, 23);
            this.VendorName.TabIndex = 1;
            this.VendorName.UseSystemPasswordChar = false;
            this.VendorName.Click += new System.EventHandler(this.VendorName_Click);
            // 
            // Contact
            // 
            this.Contact.Depth = 0;
            this.Contact.Hint = "";
            this.Contact.Location = new System.Drawing.Point(221, 150);
            this.Contact.MouseState = MaterialSkin.MouseState.HOVER;
            this.Contact.Name = "Contact";
            this.Contact.PasswordChar = '\0';
            this.Contact.SelectedText = "";
            this.Contact.SelectionLength = 0;
            this.Contact.SelectionStart = 0;
            this.Contact.Size = new System.Drawing.Size(114, 23);
            this.Contact.TabIndex = 2;
            this.Contact.UseSystemPasswordChar = false;
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            // 
            // Email
            // 
            this.Email.Depth = 0;
            this.Email.Hint = "";
            this.Email.Location = new System.Drawing.Point(465, 150);
            this.Email.MouseState = MaterialSkin.MouseState.HOVER;
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.SelectedText = "";
            this.Email.SelectionLength = 0;
            this.Email.SelectionStart = 0;
            this.Email.Size = new System.Drawing.Size(114, 23);
            this.Email.TabIndex = 3;
            this.Email.UseSystemPasswordChar = false;
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Address
            // 
            this.Address.Depth = 0;
            this.Address.Hint = "";
            this.Address.Location = new System.Drawing.Point(221, 194);
            this.Address.MouseState = MaterialSkin.MouseState.HOVER;
            this.Address.Name = "Address";
            this.Address.PasswordChar = '\0';
            this.Address.SelectedText = "";
            this.Address.SelectionLength = 0;
            this.Address.SelectionStart = 0;
            this.Address.Size = new System.Drawing.Size(114, 23);
            this.Address.TabIndex = 4;
            this.Address.UseSystemPasswordChar = false;
            this.Address.Click += new System.EventHandler(this.Address_Click);
            // 
            // Commission
            // 
            this.Commission.Depth = 0;
            this.Commission.Hint = "";
            this.Commission.Location = new System.Drawing.Point(474, 194);
            this.Commission.MouseState = MaterialSkin.MouseState.HOVER;
            this.Commission.Name = "Commission";
            this.Commission.PasswordChar = '\0';
            this.Commission.SelectedText = "";
            this.Commission.SelectionLength = 0;
            this.Commission.SelectionStart = 0;
            this.Commission.Size = new System.Drawing.Size(114, 23);
            this.Commission.TabIndex = 5;
            this.Commission.UseSystemPasswordChar = false;
            this.Commission.Click += new System.EventHandler(this.Commission_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 179);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Update
            // 
            this.Update.AutoSize = true;
            this.Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Update.Depth = 0;
            this.Update.Location = new System.Drawing.Point(378, 226);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.Update.Name = "Update";
            this.Update.Primary = false;
            this.Update.Size = new System.Drawing.Size(64, 36);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "VendorID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "VendorName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contact";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Commission";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete.Depth = 0;
            this.delete.Location = new System.Drawing.Point(450, 226);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete.Name = "delete";
            this.delete.Primary = false;
            this.delete.Size = new System.Drawing.Size(60, 36);
            this.delete.TabIndex = 15;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Submit
            // 
            this.Submit.AutoSize = true;
            this.Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Submit.Depth = 0;
            this.Submit.Location = new System.Drawing.Point(308, 226);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.Submit.Name = "Submit";
            this.Submit.Primary = false;
            this.Submit.Size = new System.Drawing.Size(62, 36);
            this.Submit.TabIndex = 16;
            this.Submit.Text = "SUBMIT";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click_1);
            // 
            // Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Commission);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.VendorName);
            this.Controls.Add(this.VendorID);
            this.Name = "Vendor";
            this.Text = "Vendor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField VendorID;
        private MaterialSkin.Controls.MaterialSingleLineTextField VendorName;
        private MaterialSkin.Controls.MaterialSingleLineTextField Contact;
        private MaterialSkin.Controls.MaterialSingleLineTextField Email;
        private MaterialSkin.Controls.MaterialSingleLineTextField Address;
        private MaterialSkin.Controls.MaterialSingleLineTextField Commission;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialFlatButton delete;
        private MaterialSkin.Controls.MaterialFlatButton Submit;
    }
}