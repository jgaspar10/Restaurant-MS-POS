using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_MS_POS
{
    class MainClass
    {
        public static readonly string con_string = "datasource=localhost;port=3306;username=root;password=;database=indasrestaurantmspos";
        public static MySqlConnection con = new MySqlConnection(con_string);

        // Method used to check user validation
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = "SELECT * FROM Users WHERE UserName = @UserName AND UserPassword = @UserPassword";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@UserName", user);
            cmd.Parameters.AddWithValue("@UserPassword", pass);

            DataTable dt = new DataTable();

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                    USER = dt.Rows[0]["UserName"].ToString();
                }
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isValid;
        }

        // Property for username
        public static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
    }
}
