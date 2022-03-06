namespace MalakApp
{
    partial class VendorDelete
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
            this.Delete = new System.Windows.Forms.Button();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.VendorIDlbl = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.VendorName = new System.Windows.Forms.TextBox();
            this.Vendornamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(652, 276);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 31);
            this.Delete.TabIndex = 44;
            this.Delete.Text = "حذف";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // VendorID
            // 
            this.VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorID.Location = new System.Drawing.Point(348, 277);
            this.VendorID.Margin = new System.Windows.Forms.Padding(2);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(274, 23);
            this.VendorID.TabIndex = 43;
            // 
            // VendorIDlbl
            // 
            this.VendorIDlbl.AutoSize = true;
            this.VendorIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorIDlbl.Location = new System.Drawing.Point(234, 277);
            this.VendorIDlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VendorIDlbl.Name = "VendorIDlbl";
            this.VendorIDlbl.Size = new System.Drawing.Size(57, 17);
            this.VendorIDlbl.TabIndex = 42;
            this.VendorIDlbl.Text = "رقم المورد";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(652, 233);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 29);
            this.Search.TabIndex = 47;
            this.Search.Text = "بحث ";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // VendorName
            // 
            this.VendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorName.Location = new System.Drawing.Point(348, 236);
            this.VendorName.Margin = new System.Windows.Forms.Padding(2);
            this.VendorName.Name = "VendorName";
            this.VendorName.Size = new System.Drawing.Size(274, 23);
            this.VendorName.TabIndex = 40;
            // 
            // Vendornamelbl
            // 
            this.Vendornamelbl.AutoSize = true;
            this.Vendornamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendornamelbl.Location = new System.Drawing.Point(238, 236);
            this.Vendornamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vendornamelbl.Name = "Vendornamelbl";
            this.Vendornamelbl.Size = new System.Drawing.Size(57, 17);
            this.Vendornamelbl.TabIndex = 46;
            this.Vendornamelbl.Text = "اسم المورد";
            // 
            // VendorDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.VendorIDlbl);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.VendorName);
            this.Controls.Add(this.Vendornamelbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VendorDelete";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة حذف بيانات مورد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.VendorDelete_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox VendorID;
        private System.Windows.Forms.Label VendorIDlbl;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox VendorName;
        private System.Windows.Forms.Label Vendornamelbl;
    }
}