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
    public class DAL_SignUpForm
    {
        DBConnect DBConnect_Obj=new DBConnect();
        int IdCounter = 0;

        #region Insert
        public void Insert( string UsrName, string PW)
        {
            try
            {
               
                string Query = @"INSERT INTO User_Data ( User_Name, User_Password) VALUES ( @Name, @Password)";

                using (SqlCommand cmd = new SqlCommand(Query, DBConnect_Obj.GetConn()))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@Name", UsrName);
                    cmd.Parameters.AddWithValue("@Password", PW);

                    DBConnect_Obj.OpenConn();

                    cmd.ExecuteNonQuery();

                    DBConnect_Obj.CloseConn();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Update
        public void Update(string id, string Name, string Description)
        {
            try
            {
                int result = Int32.Parse(id);
                string Query = @"Update Accounts SET Account_Email_UserName= '" + Name + "',  Account_Password='" + Description + "' WHERE Account_ID= " + result + " ";

                SqlCommand cmd = new SqlCommand(Query, DBConnect_Obj.GetConn());

                DBConnect_Obj.OpenConn();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("The Account updated successfully");
                }
                else
                {
                    MessageBox.Show("Account ID not found");
                }

                DBConnect_Obj.CloseConn();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

       
        #region Search
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

        #region Remove

        public void Remove(string id)
        {
            try
            {
                int result = Int32.Parse(id);
                string Query = @"DELETE FROM Accounts WHERE Account_ID= " + result + " ";

                SqlCommand cmd = new SqlCommand(Query, DBConnect_Obj.GetConn());

                DBConnect_Obj.OpenConn();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("The Account is Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Account ID not found");
                }

                DBConnect_Obj.CloseConn();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion


    }
}
