namespace MalakApp
{
    partial class ProductUpdate
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
            this.productID = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
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
            // productID
            // 
            this.productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID.Location = new System.Drawing.Point(373, 167);
            this.productID.Margin = new System.Windows.Forms.Padding(2);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(321, 23);
            this.productID.TabIndex = 61;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(373, 332);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(141, 31);
            this.Update.TabIndex = 69;
            this.Update.Text = "تعديل";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(565, 332);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(129, 31);
            this.Clear.TabIndex = 68;
            this.Clear.Text = "مسح";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(373, 281);
            this.Amount.Margin = new System.Windows.Forms.Padding(2);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(321, 23);
            this.Amount.TabIndex = 67;
            // 
            // VendorID
            // 
            this.VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorID.Location = new System.Drawing.Point(373, 242);
            this.VendorID.Margin = new System.Windows.Forms.Padding(2);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(321, 23);
            this.VendorID.TabIndex = 65;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(373, 201);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(321, 23);
            this.ProductName.TabIndex = 63;
            // 
            // Productidlbl
            // 
            this.Productidlbl.AutoSize = true;
            this.Productidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productidlbl.Location = new System.Drawing.Point(278, 167);
            this.Productidlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Productidlbl.Name = "Productidlbl";
            this.Productidlbl.Size = new System.Drawing.Size(53, 17);
            this.Productidlbl.TabIndex = 73;
            this.Productidlbl.Text = "رقم المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "رقم سجل المورد";
            // 
            // Amtlbl
            // 
            this.Amtlbl.AutoSize = true;
            this.Amtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amtlbl.Location = new System.Drawing.Point(279, 283);
            this.Amtlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(33, 17);
            this.Amtlbl.TabIndex = 71;
            this.Amtlbl.Text = "الكمية";
            // 
            // ProductNamelbl
            // 
            this.ProductNamelbl.AutoSize = true;
            this.ProductNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNamelbl.Location = new System.Drawing.Point(279, 204);
            this.ProductNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNamelbl.Name = "ProductNamelbl";
            this.ProductNamelbl.Size = new System.Drawing.Size(53, 17);
            this.ProductNamelbl.TabIndex = 70;
            this.ProductNamelbl.Text = "اسم المنتج";
            // 
            // ProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.Productidlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amtlbl);
            this.Controls.Add(this.ProductNamelbl);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.ProductName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductUpdate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة تعديل بيانات منتج";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.ProductUpdate_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Button Update;
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