namespace MalakApp
{
    partial class CustomerInsert
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
            this.customerId = new System.Windows.Forms.TextBox();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CustomerAddress = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phno = new System.Windows.Forms.TextBox();
            this.Cust_phNoLabel = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerId
            // 
            this.customerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerId.Location = new System.Drawing.Point(284, 155);
            this.customerId.Margin = new System.Windows.Forms.Padding(2);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(408, 23);
            this.customerId.TabIndex = 1;
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIDLabel.Location = new System.Drawing.Point(186, 158);
            this.CustIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(84, 17);
            this.CustIDLabel.TabIndex = 53;
            this.CustIDLabel.Text = "رقم سجل الزبون";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(547, 399);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(145, 31);
            this.submitButton.TabIndex = 49;
            this.submitButton.Text = "حفظ بيانات";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(284, 399);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 31);
            this.clearButton.TabIndex = 48;
            this.clearButton.Text = "مسح بيانات";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 47;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerEmail.Location = new System.Drawing.Point(284, 354);
            this.CustomerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(408, 23);
            this.CustomerEmail.TabIndex = 46;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(186, 357);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(83, 17);
            this.EmailLabel.TabIndex = 45;
            this.EmailLabel.Text = "البريد الالكتروني";
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress.Location = new System.Drawing.Point(284, 265);
            this.CustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerAddress.Multiline = true;
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(408, 71);
            this.CustomerAddress.TabIndex = 44;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(186, 268);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(38, 17);
            this.addressLabel.TabIndex = 43;
            this.addressLabel.Text = "العنوان";
            // 
            // phno
            // 
            this.phno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phno.Location = new System.Drawing.Point(285, 225);
            this.phno.Margin = new System.Windows.Forms.Padding(2);
            this.phno.Name = "phno";
            this.phno.Size = new System.Drawing.Size(408, 23);
            this.phno.TabIndex = 42;
            // 
            // Cust_phNoLabel
            // 
            this.Cust_phNoLabel.AutoSize = true;
            this.Cust_phNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_phNoLabel.Location = new System.Drawing.Point(187, 228);
            this.Cust_phNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cust_phNoLabel.Name = "Cust_phNoLabel";
            this.Cust_phNoLabel.Size = new System.Drawing.Size(56, 17);
            this.Cust_phNoLabel.TabIndex = 41;
            this.Cust_phNoLabel.Text = "رقم الهاتف";
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(285, 188);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(408, 23);
            this.CustomerName.TabIndex = 40;
            // 
            // CustLabel
            // 
            this.CustLabel.AutoSize = true;
            this.CustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLabel.Location = new System.Drawing.Point(187, 191);
            this.CustLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustLabel.Name = "CustLabel";
            this.CustLabel.Size = new System.Drawing.Size(57, 17);
            this.CustLabel.TabIndex = 39;
            this.CustLabel.Text = "اسم الزبون";
            // 
            // CustomerInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.CustIDLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerEmail);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phno);
            this.Controls.Add(this.Cust_phNoLabel);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة اضافة بيانات زبون";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.CustomerInsert_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerInsert_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox CustomerAddress;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox phno;
        private System.Windows.Forms.Label Cust_phNoLabel;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label CustLabel;
    }
}