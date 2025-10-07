using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageSystem
{
    public class DAL_LoginForm
    {
        DBConnect DBConnect_Obj=new DBConnect();

  
       

        #region Select
        public int Search(string UserName,string Password)
        {
            int ErrorStatus = -2;
            DataTable dt = new DataTable();
            try
            {
                string Query = @"SELECT * FROM User_Data Where User_Name=@UserName ";
               
                using (SqlCommand cmd = new SqlCommand(Query, DBConnect_Obj.GetConn()))
                {
                    cmd.Parameters.AddWithValue("@UserName", UserName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        ErrorStatus = -1;
                        string storedPassword = dt.Rows[0]["User_Password"].ToString();
                        
                        if (storedPassword == Password)
                        {
                            ErrorStatus = 1;
                        }
                        else
                        {
                            ErrorStatus = 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return ErrorStatus;
        }
        #endregion

  

    }
}
