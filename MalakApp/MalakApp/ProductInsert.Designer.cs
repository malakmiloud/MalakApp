namespace MalakApp
{
    partial class ProductInsert
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
            this.ProductID = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TextBox();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Productidlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Amtlbl = new System.Windows.Forms.Label();
            this.ProductNamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductID
            // 
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(348, 169);
            this.ProductID.Margin = new System.Windows.Forms.Padding(2);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(353, 23);
            this.ProductID.TabIndex = 38;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(348, 339);
            this.Submit.Margin = new System.Windows.Forms.Padding(2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(139, 31);
            this.Submit.TabIndex = 47;
            this.Submit.Text = "حفظ بيانات";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(577, 339);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(124, 31);
            this.Clear.TabIndex = 46;
            this.Clear.Text = "مسح";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(348, 285);
            this.Amount.Margin = new System.Windows.Forms.Padding(2);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(353, 23);
            this.Amount.TabIndex = 41;
            // 
            // VendorID
            // 
            this.VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorID.Location = new System.Drawing.Point(348, 249);
            this.VendorID.Margin = new System.Windows.Forms.Padding(2);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(353, 23);
            this.VendorID.TabIndex = 40;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(348, 207);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(353, 23);
            this.ProductName.TabIndex = 39;
            // 
            // Productidlbl
            // 
            this.Productidlbl.AutoSize = true;
            this.Productidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productidlbl.Location = new System.Drawing.Point(255, 169);
            this.Productidlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Productidlbl.Name = "Productidlbl";
            this.Productidlbl.Size = new System.Drawing.Size(53, 17);
            this.Productidlbl.TabIndex = 77;
            this.Productidlbl.Text = "رقم المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "رقم سجل المورد";
            // 
            // Amtlbl
            // 
            this.Amtlbl.AutoSize = true;
            this.Amtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amtlbl.Location = new System.Drawing.Point(255, 291);
            this.Amtlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(33, 17);
            this.Amtlbl.TabIndex = 75;
            this.Amtlbl.Text = "الكمية";
            // 
            // ProductNamelbl
            // 
            this.ProductNamelbl.AutoSize = true;
            this.ProductNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNamelbl.Location = new System.Drawing.Point(255, 212);
            this.ProductNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNamelbl.Name = "ProductNamelbl";
            this.ProductNamelbl.Size = new System.Drawing.Size(53, 17);
            this.ProductNamelbl.TabIndex = 74;
            this.ProductNamelbl.Text = "اسم المنتج";
            // 
            // ProductInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.Productidlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amtlbl);
            this.Controls.Add(this.ProductNamelbl);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.ProductName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة إضافة بيانات منتج";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.ProductInsert_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox VendorID;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label Productidlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Amtlbl;
        private System.Windows.Forms.Label ProductNamelbl;
    }
}