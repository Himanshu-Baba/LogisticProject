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
    public class EnquiryDB
    {
        public void Enquiry(EnquiryModel data)
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["Hello"].ConnectionString;
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                string query = "InsertEnquiry";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", data.Enquiry_Name);
                cmd.Parameters.AddWithValue("@Email", data.Enquiry_Email);
                cmd.Parameters.AddWithValue("@Phone", data.Enquiry_Phone);
                cmd.Parameters.AddWithValue("@Organization", data.Enquiry_Organization);
                cmd.Parameters.AddWithValue("@Type", data.Enquiry_Type);
                cmd.Parameters.AddWithValue("@State", data.StateId);
                cmd.Parameters.AddWithValue("@City", data.CityId);
                cmd.Parameters.AddWithValue("@Zip", data.Enquiry_Zip);
                cmd.Parameters.AddWithValue("@Address", data.Enquiry_Address);
                cmd.Parameters.AddWithValue("@Quiery", data.Enquiry_Quiery);
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
