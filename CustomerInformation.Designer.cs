namespace CAR_Bussiness
{
    partial class CustomerInformation
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ContactNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CustomerID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.Address = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(308, 182);
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
            this.materialFlatButton2.Location = new System.Drawing.Point(385, 182);
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
            this.materialFlatButton3.Location = new System.Drawing.Point(457, 182);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "ContactNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "CustomerID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 179);
            this.dataGridView1.TabIndex = 23;
            // 
            // Email
            // 
            this.Email.Depth = 0;
            this.Email.Hint = "";
            this.Email.Location = new System.Drawing.Point(202, 150);
            this.Email.MouseState = MaterialSkin.MouseState.HOVER;
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.SelectedText = "";
            this.Email.SelectionLength = 0;
            this.Email.SelectionStart = 0;
            this.Email.Size = new System.Drawing.Size(114, 23);
            this.Email.TabIndex = 21;
            this.Email.UseSystemPasswordChar = false;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Depth = 0;
            this.ContactNumber.Hint = "";
            this.ContactNumber.Location = new System.Drawing.Point(448, 106);
            this.ContactNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.PasswordChar = '\0';
            this.ContactNumber.SelectedText = "";
            this.ContactNumber.SelectionLength = 0;
            this.ContactNumber.SelectionStart = 0;
            this.ContactNumber.Size = new System.Drawing.Size(114, 23);
            this.ContactNumber.TabIndex = 20;
            this.ContactNumber.UseSystemPasswordChar = false;
            // 
            // LastName
            // 
            this.LastName.Depth = 0;
            this.LastName.Hint = "";
            this.LastName.Location = new System.Drawing.Point(202, 106);
            this.LastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LastName.Name = "LastName";
            this.LastName.PasswordChar = '\0';
            this.LastName.SelectedText = "";
            this.LastName.SelectionLength = 0;
            this.LastName.SelectionStart = 0;
            this.LastName.Size = new System.Drawing.Size(114, 23);
            this.LastName.TabIndex = 19;
            this.LastName.UseSystemPasswordChar = false;
            // 
            // FirstName
            // 
            this.FirstName.Depth = 0;
            this.FirstName.Hint = "";
            this.FirstName.Location = new System.Drawing.Point(446, 60);
            this.FirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.FirstName.Name = "FirstName";
            this.FirstName.PasswordChar = '\0';
            this.FirstName.SelectedText = "";
            this.FirstName.SelectionLength = 0;
            this.FirstName.SelectionStart = 0;
            this.FirstName.Size = new System.Drawing.Size(114, 23);
            this.FirstName.TabIndex = 18;
            this.FirstName.UseSystemPasswordChar = false;
            // 
            // CustomerID
            // 
            this.CustomerID.Depth = 0;
            this.CustomerID.Hint = "";
            this.CustomerID.Location = new System.Drawing.Point(202, 60);
            this.CustomerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.PasswordChar = '\0';
            this.CustomerID.SelectedText = "";
            this.CustomerID.SelectionLength = 0;
            this.CustomerID.SelectionStart = 0;
            this.CustomerID.Size = new System.Drawing.Size(114, 23);
            this.CustomerID.TabIndex = 17;
            this.CustomerID.Text = "Update/Delete";
            this.CustomerID.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Address";
            // 
            // Address
            // 
            this.Address.Depth = 0;
            this.Address.Hint = "";
            this.Address.Location = new System.Drawing.Point(448, 150);
            this.Address.MouseState = MaterialSkin.MouseState.HOVER;
            this.Address.Name = "Address";
            this.Address.PasswordChar = '\0';
            this.Address.SelectedText = "";
            this.Address.SelectionLength = 0;
            this.Address.SelectionStart = 0;
            this.Address.Size = new System.Drawing.Size(114, 23);
            this.Address.TabIndex = 30;
            this.Address.UseSystemPasswordChar = false;
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.ContactNumber);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "CustomerInformation";
            this.Text = "CustomerInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Email;
        private MaterialSkin.Controls.MaterialSingleLineTextField ContactNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField LastName;
        private MaterialSkin.Controls.MaterialSingleLineTextField FirstName;
        private MaterialSkin.Controls.MaterialSingleLineTextField CustomerID;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField Address;
    }
}