using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarageSystem;
using System.Runtime.InteropServices.ComTypes;

namespace WindowsFormsApp1
{
    public class DAL_History
    {
        DBConnect db = new DBConnect();

        #region Select from DB
        public DataTable Select(DateTime startDate)
        {
            DataTable dataTable = new DataTable();
            //string Sql = @"SELECT * FROM Reservation WHERE Reservation_EnterDateTime = @Reservation_DateTime";

            string Sql = @"SELECT * FROM Reservation 
                   WHERE CAST(Reservation_EnterDateTime AS DATE) = CAST(@Reservation_Date AS DATE)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, db.GetConn()))
                {
                    // Add the parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Reservation_Date", startDate.Date);

                    db.OpenConn();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Fill the DataTable with the results from the query
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data search failed: {ex.Message}");
            }
            finally
            {
                db.CloseConn();
            }

            return dataTable;
        }
        public DataTable Select()
        {
            DataTable dataTable = new DataTable();
            //string Sql = @"SELECT * FROM Reservation WHERE Reservation_EnterDateTime = @Reservation_DateTime";

            string Sql = @"SELECT * FROM Reservation ";
            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, db.GetConn()))
                {
                    // Add the parameter to prevent SQL injection

                    db.OpenConn();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Fill the DataTable with the results from the query
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data search failed: {ex.Message}");
            }
            finally
            {
                db.CloseConn();
            }

            return dataTable;
        }
        public DataTable GetDataOfVehicleNumAndDate(DateTime Date, string VehicleNumberFilter)
        {
            DataTable dataTable = new DataTable();
            //string Sql = @"SELECT * FROM Reservation WHERE Reservation_EnterDateTime = @Reservation_DateTime";

            string Sql = @"SELECT * FROM Reservation 
                   WHERE CAST(Reservation_EnterDateTime AS DATE) =CAST(@Reservation_Date AS DATE)  AND Reservation_VehicleNumber= @Reservation_vehicleNumber ";
            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, db.GetConn()))
                {
                    // Add the parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Reservation_Date", Date);
                    cmd.Parameters.AddWithValue("@Reservation_vehicleNumber", VehicleNumberFilter);

                    db.OpenConn();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Fill the DataTable with the results from the query
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data search failed: {ex.Message}");
            }
            finally
            {
                db.CloseConn();
            }

            return dataTable;
        }
        public DataTable GetDataOfVehicleNum(string VehicleNum)
        {
            DataTable dataTable = new DataTable();
            //string Sql = @"SELECT * FROM Reservation WHERE Reservation_EnterDateTime = @Reservation_DateTime";

            string Sql = @"SELECT * FROM Reservation 
                   WHERE Reservation_VehicleNumber= @Reservation_vehicleNumber";
            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, db.GetConn()))
                {
                    // Add the parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Reservation_vehicleNumber", VehicleNum);

                    db.OpenConn();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Fill the DataTable with the results from the query
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data search failed: {ex.Message}");
            }
            finally
            {
                db.CloseConn();
            }

            return dataTable;

        }
        #endregion

        #region Insert in DB
        public bool Insert(string TextBox_UserName, string TextBox_Mobile, string TextBox_VehicleNo, DateTime dateTimePicker_StartTime, DateTime dateTimePicker_EndTime, string TextBox_Payment, string MonthReservationCheck, DateTime dateTimePicker_StartMonth, string TextBox_MonthesNumber, string VehicleType)
        {
            string Sql = @"INSERT INTO Reservation 
    (Reservation_ConsumName, Reservation_ConsumPhone, Reservation_VehicleNumber, Reservation_EnterDateTime, Reservation_ExitDateTime, Reservation_Payment, Reservation_VehicleType, Reservation_MonthlyState, Reservation_StartMonth, Reservation_MonthsNumber) 
    VALUES 
    (@Reservation_ConsumName, @Reservation_ConsumPhone, @Reservation_VehicleNumber, @Reservation_EnterDateTime, @Reservation_ExitDateTime, @Reservation_Payment, @Reservation_VehicleType, @Reservation_MonthlyState, @Reservation_StartMonth, @Reservation_MonthsNumber)";

            bool IsSucceeded = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, db.GetConn()))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Reservation_ConsumName", TextBox_UserName);
                    cmd.Parameters.AddWithValue("@Reservation_ConsumPhone", TextBox_Mobile);
                    cmd.Parameters.AddWithValue("@Reservation_VehicleNumber", TextBox_VehicleNo);
                    cmd.Parameters.AddWithValue("@Reservation_EnterDateTime", dateTimePicker_StartTime);
                    cmd.Parameters.AddWithValue("@Reservation_ExitDateTime", dateTimePicker_EndTime);
                    cmd.Parameters.AddWithValue("@Reservation_Payment", TextBox_Payment);
                    cmd.Parameters.AddWithValue("@Reservation_VehicleType", VehicleType);
                    cmd.Parameters.AddWithValue("@Reservation_MonthlyState", MonthReservationCheck); // Adjust as needed
                    cmd.Parameters.AddWithValue("@Reservation_StartMonth", dateTimePicker_StartMonth);
                    cmd.Parameters.AddWithValue("@Reservation_MonthsNumber", TextBox_MonthesNumber);

                    db.OpenConn();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        IsSucceeded = true;
                    }
                    else
                    {
                        MessageBox.Show("No data was inserted into the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data insertion failed: {ex.Message}");
            }
            finally
            {
                db.CloseConn();
            }

            return IsSucceeded;
        }

        #endregion

        #region update in db
        public bool Update(int reservationId, string TextBox_UserName, string TextBox_Mobile, string TextBox_VehicleNo, DateTime dateTimePicker_StartTime, DateTime dateTimePicker_EndTime, string TextBox_Payment, string MonthReservationCheck, DateTime dateTimePicker_StartMonth, string TextBox_MonthesNumber, string VehicleType)
        {
            string Sql = @"UPDATE Reservation 
                        SET 
                            Reservation_ConsumName = @Reservation_ConsumName, 
                            Reservation_ConsumPhone = @Reservation_ConsumPhone, 
                            Reservation_VehicleNumber = @Reservation_VehicleNumber, 
                            Reservation_EnterDateTime = @Reservation_EnterDateTime, 
                            Reservation_ExitDateTime = @Reservation_ExitDateTime, 
                            Reservation_Payment = @Reservation_Payment, 
                            Reservation_VehicleType = @Reservation_VehicleType, 
                            Reservation_MonthlyState = @Reservation_MonthlyState, 
                            Reservation_StartMonth = @Reservation_StartMonth, 
                            Reservation_MonthsNumber = @Reservation_MonthsNumber
                        WHERE 
                            Reservation_ID = @Reservation_ID";

            bool IsSucceeded = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, db.GetConn()))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Reservation_ConsumName", TextBox_UserName);
                    cmd.Parameters.AddWithValue("@Reservation_ConsumPhone", TextBox_Mobile);
                    cmd.Parameters.AddWithValue("@Reservation_VehicleNumber", TextBox_VehicleNo);
                    cmd.Parameters.AddWithValue("@Reservation_EnterDateTime", dateTimePicker_StartTime);
                    cmd.Parameters.AddWithValue("@Reservation_ExitDateTime", dateTimePicker_EndTime);
                    cmd.Parameters.AddWithValue("@Reservation_Payment", TextBox_Payment);
                    cmd.Parameters.AddWithValue("@Reservation_VehicleType", VehicleType);
                    cmd.Parameters.AddWithValue("@Reservation_MonthlyState", MonthReservationCheck); // Adjust as needed
                    cmd.Parameters.AddWithValue("@Reservation_StartMonth", dateTimePicker_StartMonth);
                    cmd.Parameters.AddWithValue("@Reservation_MonthsNumber", TextBox_MonthesNumber);
                    cmd.Parameters.AddWithValue("@Reservation_ID", reservationId);

                    db.OpenConn();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        IsSucceeded = true;
                    }
                    else
                    {
                        MessageBox.Show("No data was updated in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data update failed: {ex.Message}");
            }
            finally
            {
                db.CloseConn();
            }

            return IsSucceeded;
        }

        #endregion
    }
}
