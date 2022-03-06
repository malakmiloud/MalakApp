using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MalakApp
{
    public class Connect
    {
        SqlConnection con;

        public static string cs = @"Data Source=.;Initial Catalog=MalakShopDB;Integrated Security=True";

        public  SqlConnection connect()
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                return con;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void closeConnection()
        {
            if(con != null)
            {
                con.Close();
            }
        }

        /*internal void Connect()
        {
            throw new NotImplementedException();
        }*/
    }
}
