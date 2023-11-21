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
    public class SignUpDB
    {
        string cn = ConfigurationManager.ConnectionStrings["Hello"].ConnectionString;
        SqlConnection sqlcon = null;
        public bool GetUser(SignUpModel osignUp)
        {
            string query = "sp_insertUserDetails";
            using (sqlcon = new SqlConnection(cn))
            {
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userName", osignUp.userName);
                cmd.Parameters.AddWithValue("@userEmail", osignUp.userEmail);
                cmd.Parameters.AddWithValue("@userContact", osignUp.userContact);
                cmd.Parameters.AddWithValue("@userPassword", osignUp.userPassword);

                sqlcon.Open();

                int i = cmd.ExecuteNonQuery();
                sqlcon.Close();

                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public List<SignUpModel> GetUser()
        {
            SqlConnection sqlcon = new SqlConnection(cn);
            List<SignUpModel> list = new List<SignUpModel>();
            SqlCommand cmd = new SqlCommand("select * from SignUp", sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new SignUpModel
                {
                    userName = Convert.ToString(dr[0]),
                    userEmail = Convert.ToString(dr[1]),
                    userContact = Convert.ToString(dr[2]),
                    userPassword = Convert.ToString(dr[3])
                });
            }
            return list;
        }


    }
}
