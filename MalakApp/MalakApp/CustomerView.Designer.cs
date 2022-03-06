namespace MalakApp
{
    partial class CustomerView
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
            this.CustID = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.PhoneNo = new System.Windows.Forms.TextBox();
            this.CustName = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.Cust_phNoLabel = new System.Windows.Forms.Label();
            this.CustLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustID
            // 
            this.CustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustID.Location = new System.Drawing.Point(358, 172);
            this.CustID.Margin = new System.Windows.Forms.Padding(2);
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Size = new System.Drawing.Size(352, 23);
            this.CustID.TabIndex = 59;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(358, 350);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Size = new System.Drawing.Size(352, 23);
            this.Email.TabIndex = 51;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(358, 283);
            this.Address.Margin = new System.Windows.Forms.Padding(2);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Size = new System.Drawing.Size(352, 52);
            this.Address.TabIndex = 49;
            // 
            // PhoneNo
            // 
            this.PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNo.Location = new System.Drawing.Point(358, 244);
            this.PhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            this.PhoneNo.Size = new System.Drawing.Size(352, 23);
            this.PhoneNo.TabIndex = 47;
            // 
            // CustName
            // 
            this.CustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.Location = new System.Drawing.Point(358, 201);
            this.CustName.Margin = new System.Windows.Forms.Padding(2);
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            this.CustName.Size = new System.Drawing.Size(352, 23);
            this.CustName.TabIndex = 45;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(623, 409);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(87, 40);
            this.Clear.TabIndex = 53;
            this.Clear.Text = "مسح الحقول";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(258, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "بيانات الزبون";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(610, 72);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 29);
            this.Search.TabIndex = 43;
            this.Search.Text = "إبحث الان";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(358, 75);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(237, 23);
            this.CustomerName.TabIndex = 42;
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIDLabel.Location = new System.Drawing.Point(260, 172);
            this.CustIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(84, 17);
            this.CustIDLabel.TabIndex = 64;
            this.CustIDLabel.Text = "رقم سجل الزبون";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(260, 350);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(83, 17);
            this.EmailLabel.TabIndex = 63;
            this.EmailLabel.Text = "البريد الالكتروني";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(306, 286);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(38, 17);
            this.addressLabel.TabIndex = 62;
            this.addressLabel.Text = "العنوان";
            // 
            // Cust_phNoLabel
            // 
            this.Cust_phNoLabel.AutoSize = true;
            this.Cust_phNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_phNoLabel.Location = new System.Drawing.Point(288, 244);
            this.Cust_phNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cust_phNoLabel.Name = "Cust_phNoLabel";
            this.Cust_phNoLabel.Size = new System.Drawing.Size(56, 17);
            this.Cust_phNoLabel.TabIndex = 61;
            this.Cust_phNoLabel.Text = "رقم الهاتف";
            // 
            // CustLabel
            // 
            this.CustLabel.AutoSize = true;
            this.CustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLabel.Location = new System.Drawing.Point(287, 201);
            this.CustLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustLabel.Name = "CustLabel";
            this.CustLabel.Size = new System.Drawing.Size(57, 17);
            this.CustLabel.TabIndex = 60;
            this.CustLabel.Text = "اسم الزبون";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "اسم الزبون";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustIDLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.Cust_phNoLabel);
            this.Controls.Add(this.CustLabel);
            this.Controls.Add(this.CustID);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PhoneNo);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CustomerName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة عرض بيانات زبون";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.CustomerView_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustID;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox PhoneNo;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label Cust_phNoLabel;
        private System.Windows.Forms.Label CustLabel;
        private System.Windows.Forms.Label label1;
    }
}