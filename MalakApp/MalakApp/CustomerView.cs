using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MalakApp
{
    public partial class CustomerView : Form
    {

        SqlConnection con;

        public CustomerView()
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
                    using (SqlCommand cmd = new SqlCommand("SELECT C_ID,CNAME,PHONE_NUMBER,ADDRESS,EMAIL FROM CUSTOMER WHERE CNAME = @cname"))
                    {
                        cmd.Parameters.AddWithValue("@cname", CustomerName.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                            CustName.Text = sdr["CNAME"].ToString();
                            PhoneNo.Text = sdr["PHONE_NUMBER"].ToString();
                            Address.Text = sdr["ADDRESS"].ToString();
                            Email.Text = sdr["EMAIL"].ToString();
                            CustID.Text = sdr["C_ID"].ToString();
                            }else
                            {
                                MessageBox.Show("لا يوجد زبون بهذا الرقم", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close the connection
                if(con != null)
                {
                    con.Close();
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //Clear all the textboxes
            PhoneNo.Clear();
            Address.Clear();
            Email.Clear();
            CustName.Clear();
            CustomerName.Clear();
            CustID.Clear();
        }

        private void CustomerView_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
