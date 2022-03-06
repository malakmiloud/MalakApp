using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalakApp
{
    public partial class VendorDelete : Form
    {
        /*
         * 
         * This cass handels deletion of vendor details.
         * 
         */ 

        SqlConnection con;

        public VendorDelete()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {


                    using (SqlCommand cmd = new SqlCommand("SELECT VID FROM VENDOR WHERE VNAME = @vname"))
                    {
                        cmd.Parameters.AddWithValue("@vname", VendorName.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            VendorID.Text = sdr["VID"].ToString();
                        }

                        con.Close();
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("لا يوجد مورد بهذا الاسم");
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("DELETE FROM VENDOR WHERE VID = @vid", con);
                cmd.Parameters.AddWithValue("@vid", VendorID.Text);
                int i = cmd.ExecuteNonQuery();

                
                //If count is equal to 1, than show frmMain form
                if (i != 0)
                {
                    MessageBox.Show("عملية حذف المورد تمت بنجاح");

                }
                else
                {
                    MessageBox.Show("فشلت عملية حذف المورد");
                }
                con.Close();
                //Clear the fields
                VendorID.Clear();
                VendorName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يوجد مورد بهذا الاسم");
            }
        }

        private void VendorDelete_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
