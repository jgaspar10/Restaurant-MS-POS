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
        public static readonly string  con_string = "Data Source=DESKTOP-GC55BUT;Initial Catalog=IndasRestaurantPOS;Persist Security Info=True;";
        public static SqlConnection con = new SqlConnection(con_string);

        // Method used to check user validation

        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = @"Select * from Users where UserName = '" + user + "' and UserPassword = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            if (dt.Rows.Count >0)
            {
                isValid = true;
            }


            return isValid;
        }
    }
}
