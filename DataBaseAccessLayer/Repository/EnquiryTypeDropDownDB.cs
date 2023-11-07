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
    public class EnquiryTypeDropDownDB
    {
        public List<string> GetEnquiryType()
        {
            List<string> EnquiryList = new List<string>();
            EnquiryModel oEnquiryModel = new EnquiryModel();
            string connection = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("GetEnquiryType", cn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    try
                    {
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {

                            EnquiryList.Add(dr["Enquiry_Type"].ToString());

                        }
                        dr.Close();
                    }
                    catch (SqlException ex)
                    {
                        string s = ex.Message;
                    }
                    finally
                    {
                        if (cn.State == System.Data.ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
            return EnquiryList;
        }
    }
}
