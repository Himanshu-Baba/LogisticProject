using DataBaseAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccessLayer.Repository
{
    public class ContactUsDB
    {
        public void ContactUs(ContactUsModel data)
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                string query = "InsertContactUs";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", data.Contact_Name);
                cmd.Parameters.AddWithValue("@Email", data.Contact_Email);
                cmd.Parameters.AddWithValue("@Phone", data.Contact_Phone);
                cmd.Parameters.AddWithValue("@Message", data.Contact_Message);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
