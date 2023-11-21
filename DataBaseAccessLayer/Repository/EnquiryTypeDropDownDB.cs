using DataBaseAccessLayer.Model;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccessLayer.Repository
{
    public class EnquiryTypeDropDownDB
    {
        string cs = ConfigurationManager.ConnectionStrings["Hello"].ConnectionString;
        public List<string> GetEnquiryType()
        {
            List<string> EnquiryList = new List<string>();
            EnquiryModel oEnquiryModel = new EnquiryModel();
            using (SqlConnection cn = new SqlConnection(cs))
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

        public List<StateModel> GetState()
        {
            List<StateModel> StateList = new List<StateModel>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * from tbl_EnquiryState", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                StateModel state = new StateModel();
                state.StateId = Convert.ToInt32(dr.GetValue(0).ToString());
                state.State = dr.GetValue(1).ToString();
                StateList.Add(state);
            }
            con.Close();
            return StateList;
        }
        public List<CityModel> GetCity()
        {
            List<CityModel> CityList = new List<CityModel>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * from tbl_EnquiryCity", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CityModel city = new CityModel();
                city.CityId = Convert.ToInt32(dr.GetValue(0).ToString());
                city.City = dr.GetValue(1).ToString();
                city.StateId = Convert.ToInt32(dr.GetValue(2).ToString());
                CityList.Add(city);
            }
            con.Close();
            return CityList;
        }
    }
}
