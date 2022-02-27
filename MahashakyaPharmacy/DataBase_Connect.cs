using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADO.Net class library
using System.Data;

namespace MahashakyaPharmacy
{
    class DataBase_Connect
    {
        SqlConnection con; 
        SqlCommand cmd;
        SqlDataAdapter da;

        public DataBase_Connect() 
        {
            //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MahashakyaPharmacy.Properties.Settings.MahashakyaPharmacyDatabaseConnectionString"].ToString();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MahashakyaPharmacyDatabase.mdf;Integrated Security=True;Connect Timeout=30"); //Create the pipeline 
            //con = new SqlConnection();
            //con.ConnectionString = connectionString;
            //con.Open();
        }

       

        public int save_update_delete(string query)
        {

            con.Open();
            cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;


        }

        public DataTable view_data(string query)
        {
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }
    }
}
