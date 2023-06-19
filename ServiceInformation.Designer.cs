namespace CAR_Bussiness
{
    partial class ServiceInformation
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
            this.Insert = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.ServiceCost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ServiceDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CarID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ServiceID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DateOfService = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Insert.Depth = 0;
            this.Insert.Location = new System.Drawing.Point(337, 198);
            this.Insert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Insert.MouseState = MaterialSkin.MouseState.HOVER;
            this.Insert.Name = "Insert";
            this.Insert.Primary = false;
            this.Insert.Size = new System.Drawing.Size(59, 36);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "INSERT";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(416, 198);
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
            this.materialFlatButton2.Location = new System.Drawing.Point(510, 198);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 157);
            this.dataGridView1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "ServiceCost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "ServiceDescription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "DateOfService";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "CarID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ServiceID";
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "choose",
            "modified",
            "notmodified"});
            this.Status.Location = new System.Drawing.Point(491, 154);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(201, 21);
            this.Status.TabIndex = 26;
            // 
            // ServiceCost
            // 
            this.ServiceCost.Depth = 0;
            this.ServiceCost.Hint = "";
            this.ServiceCost.Location = new System.Drawing.Point(163, 154);
            this.ServiceCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServiceCost.Name = "ServiceCost";
            this.ServiceCost.PasswordChar = '\0';
            this.ServiceCost.SelectedText = "";
            this.ServiceCost.SelectionLength = 0;
            this.ServiceCost.SelectionStart = 0;
            this.ServiceCost.Size = new System.Drawing.Size(205, 23);
            this.ServiceCost.TabIndex = 24;
            this.ServiceCost.UseSystemPasswordChar = false;
            // 
            // ServiceDescription
            // 
            this.ServiceDescription.Depth = 0;
            this.ServiceDescription.Hint = "";
            this.ServiceDescription.Location = new System.Drawing.Point(491, 108);
            this.ServiceDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServiceDescription.Name = "ServiceDescription";
            this.ServiceDescription.PasswordChar = '\0';
            this.ServiceDescription.SelectedText = "";
            this.ServiceDescription.SelectionLength = 0;
            this.ServiceDescription.SelectionStart = 0;
            this.ServiceDescription.Size = new System.Drawing.Size(201, 23);
            this.ServiceDescription.TabIndex = 23;
            this.ServiceDescription.UseSystemPasswordChar = false;
            // 
            // CarID
            // 
            this.CarID.Depth = 0;
            this.CarID.Hint = "";
            this.CarID.Location = new System.Drawing.Point(491, 67);
            this.CarID.MouseState = MaterialSkin.MouseState.HOVER;
            this.CarID.Name = "CarID";
            this.CarID.PasswordChar = '\0';
            this.CarID.SelectedText = "";
            this.CarID.SelectionLength = 0;
            this.CarID.SelectionStart = 0;
            this.CarID.Size = new System.Drawing.Size(201, 23);
            this.CarID.TabIndex = 22;
            this.CarID.UseSystemPasswordChar = false;
            // 
            // ServiceID
            // 
            this.ServiceID.Depth = 0;
            this.ServiceID.Hint = "";
            this.ServiceID.Location = new System.Drawing.Point(163, 67);
            this.ServiceID.MouseState = MaterialSkin.MouseState.HOVER;
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.PasswordChar = '\0';
            this.ServiceID.SelectedText = "";
            this.ServiceID.SelectionLength = 0;
            this.ServiceID.SelectionStart = 0;
            this.ServiceID.Size = new System.Drawing.Size(205, 23);
            this.ServiceID.TabIndex = 21;
            this.ServiceID.UseSystemPasswordChar = false;
            // 
            // DateOfService
            // 
            this.DateOfService.Location = new System.Drawing.Point(160, 110);
            this.DateOfService.Name = "DateOfService";
            this.DateOfService.Size = new System.Drawing.Size(208, 20);
            this.DateOfService.TabIndex = 34;
            this.DateOfService.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ServiceInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateOfService);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ServiceCost);
            this.Controls.Add(this.ServiceDescription);
            this.Controls.Add(this.CarID);
            this.Controls.Add(this.ServiceID);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.Insert);
            this.Name = "ServiceInformation";
            this.Text = "ServiceInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Insert;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Status;
        private MaterialSkin.Controls.MaterialSingleLineTextField ServiceCost;
        private MaterialSkin.Controls.MaterialSingleLineTextField ServiceDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField CarID;
        private MaterialSkin.Controls.MaterialSingleLineTextField ServiceID;
        private System.Windows.Forms.DateTimePicker DateOfService;
    }
}