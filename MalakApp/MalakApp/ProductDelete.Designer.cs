namespace MalakApp
{
    partial class ProductDelete
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
            this.Deletebtn = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.ProdIDlbl = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductNamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(675, 237);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(62, 29);
            this.Deletebtn.TabIndex = 56;
            this.Deletebtn.Text = "حذف";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // ProductID
            // 
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(384, 240);
            this.ProductID.Margin = new System.Windows.Forms.Padding(2);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(258, 23);
            this.ProductID.TabIndex = 55;
            // 
            // ProdIDlbl
            // 
            this.ProdIDlbl.AutoSize = true;
            this.ProdIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIDlbl.Location = new System.Drawing.Point(253, 243);
            this.ProdIDlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProdIDlbl.Name = "ProdIDlbl";
            this.ProdIDlbl.Size = new System.Drawing.Size(53, 17);
            this.ProdIDlbl.TabIndex = 54;
            this.ProdIDlbl.Text = "رقم المنتج";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(675, 188);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(62, 29);
            this.Searchbtn.TabIndex = 53;
            this.Searchbtn.Text = "بحث";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(384, 191);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(258, 23);
            this.ProductName.TabIndex = 52;
            // 
            // ProductNamelbl
            // 
            this.ProductNamelbl.AutoSize = true;
            this.ProductNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNamelbl.Location = new System.Drawing.Point(253, 193);
            this.ProductNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNamelbl.Name = "ProductNamelbl";
            this.ProductNamelbl.Size = new System.Drawing.Size(53, 17);
            this.ProductNamelbl.TabIndex = 51;
            this.ProductNamelbl.Text = "اسم المنتج";
            // 
            // ProductDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.ProdIDlbl);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductNamelbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductDelete";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شاشة حذف بيانات منتج";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.ProductDelete_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label ProdIDlbl;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label ProductNamelbl;
    }
}