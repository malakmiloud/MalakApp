namespace MalakApp
{
    partial class VendorView
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
            this.label11 = new System.Windows.Forms.Label();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.VendorName = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.VendorPhoneNo = new System.Windows.Forms.TextBox();
            this.VendorAddress = new System.Windows.Forms.TextBox();
            this.VendorName2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(264, 205);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 70;
            this.label11.Text = "تفاصيل المورد";
            // 
            // VendorID
            // 
            this.VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorID.Location = new System.Drawing.Point(370, 246);
            this.VendorID.Margin = new System.Windows.Forms.Padding(2);
            this.VendorID.Name = "VendorID";
            this.VendorID.ReadOnly = true;
            this.VendorID.Size = new System.Drawing.Size(348, 23);
            this.VendorID.TabIndex = 68;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(602, 123);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(117, 33);
            this.Search.TabIndex = 56;
            this.Search.Text = "بحث";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // VendorName
            // 
            this.VendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorName.Location = new System.Drawing.Point(377, 128);
            this.VendorName.Margin = new System.Windows.Forms.Padding(2);
            this.VendorName.Name = "VendorName";
            this.VendorName.Size = new System.Drawing.Size(187, 23);
            this.VendorName.TabIndex = 55;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(597, 491);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(122, 37);
            this.clear.TabIndex = 67;
            this.clear.Text = "مسح حقول";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(371, 438);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Size = new System.Drawing.Size(348, 23);
            this.Email.TabIndex = 66;
            // 
            // VendorPhoneNo
            // 
            this.VendorPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorPhoneNo.Location = new System.Drawing.Point(371, 400);
            this.VendorPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.VendorPhoneNo.Name = "VendorPhoneNo";
            this.VendorPhoneNo.ReadOnly = true;
            this.VendorPhoneNo.Size = new System.Drawing.Size(348, 23);
            this.VendorPhoneNo.TabIndex = 64;
            // 
            // VendorAddress
            // 
            this.VendorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorAddress.Location = new System.Drawing.Point(371, 321);
            this.VendorAddress.Margin = new System.Windows.Forms.Padding(2);
            this.VendorAddress.Multiline = true;
            this.VendorAddress.Name = "VendorAddress";
            this.VendorAddress.ReadOnly = true;
            this.VendorAddress.Size = new System.Drawing.Size(348, 64);
            this.VendorAddress.TabIndex = 62;
            // 
            // VendorName2
            // 
            this.VendorName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorName2.Location = new System.Drawing.Point(371, 282);
            this.VendorName2.Margin = new System.Windows.Forms.Padding(2);
            this.VendorName2.Name = "VendorName2";
            this.VendorName2.ReadOnly = true;
            this.VendorName2.Size = new System.Drawing.Size(348, 23);
            this.VendorName2.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "رقم المورد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 441);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "البريد الالكتروني";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "عنوان المورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "اسم المورد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "رقم الهاتف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "اسم المورد";
            // 
            // VendorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.VendorName);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.VendorPhoneNo);
            this.Controls.Add(this.VendorAddress);
            this.Controls.Add(this.VendorName2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VendorView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة عرض بيانات مورد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox VendorID;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox VendorName;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox VendorPhoneNo;
        private System.Windows.Forms.TextBox VendorAddress;
        private System.Windows.Forms.TextBox VendorName2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}