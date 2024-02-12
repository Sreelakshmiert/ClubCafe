using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ClubCafe
{
     class Function
    {

        protected static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SREELAKSHMI;" +
                "initial Catalog=clubcafe;Integrated Security=True;" +
                "Encrypt=True;Trust Server Certificate=True";

            return conn;
        }

        public DataSet getData(string query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new()
            {
                Connection = conn,
                CommandText = query
            };
            SqlDataAdapter adapter = new(cmd);
            DataSet ds  = new();
            adapter.Fill(ds);
            return ds;
        }

        public void SetData(string query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new()
            {
                Connection = conn
            };
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data processe Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


       

    }
}