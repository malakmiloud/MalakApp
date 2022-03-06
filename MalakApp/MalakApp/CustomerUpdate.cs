using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MalakApp
{
    public partial class CustomerUpdate : Form
    {
        /*
         * This class manages the updation of customer details. 
         * 
         */ 

        private SqlConnection con;

        public CustomerUpdate()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (customerName.Text == "" || CustPhno.Text == "" || customerAddress.Text == "" || Email.Text == "" || customerID.Text == "")
            {
                MessageBox.Show("نرجوا منك ملا كل حقول", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("UPDATE CUSTOMER SET cname = @cname,address = @address,phone_number = @phno,email = @email WHERE c_id = @id;", con);
          

                cmd.Parameters.AddWithValue("@id", customerID.Text);
                cmd.Parameters.AddWithValue("@cname", customerName.Text);
                cmd.Parameters.AddWithValue("@phno", Convert.ToInt64(CustPhno.Text));
                cmd.Parameters.AddWithValue("@address", customerAddress.Text);
                cmd.Parameters.AddWithValue("@email", Email.Text);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("تمت عملية تعديل زبون بنجاح", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("فشلت عملية تعديل بيانات زبون", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            //Clear the texboxes after inserting
            customerName.Clear();
            CustPhno.Clear();
            customerAddress.Clear();
            Email.Clear();
            customerID.Clear();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            //Clear the textboxes 
            customerName.Clear();
            CustPhno.Clear();
            customerAddress.Clear();
            Email.Clear();
            customerID.Clear();
        }
    }
}
