using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GarageSystem
{
    public class DBConnect
    {
        //private SqlConnection connection=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maria\Documents\Doaa_MiniSupermarket.mdf;Integrated Security=True;Connect Timeout=30");
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Downloads\GarageSystem\Database_Data\GarageSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection GetConn()
        {
            return connection;
        }

        public void OpenConn()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

       public void CloseConn()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
