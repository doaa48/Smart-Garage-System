using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarageSystem;

namespace WindowsFormsApp1
{
    public class DAL_SlotsMap
    {
        DBConnect db = new DBConnect();

        #region Select from DB
        public DataTable Select(string slotAddres)
        {
            DataTable dataTable = new DataTable();
            string Sql = @"SELECT * FROM Slots WHERE Slot_Address = @SlotAddres";

            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, db.GetConn()))
                {
                    // Add the parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@SlotAddres", slotAddres);

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
            string Sql = @"SELECT * FROM Slots";

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

        public DataTable SelectSpesificData()
        {
            DataTable dataTable = new DataTable();

            string Sql = @"SELECT Slot_Floor_Number,Slot_Address ,Slot_Status,Slot_StatusCause  FROM Slots";

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
        #endregion

        #region Insert in DB
        public bool Insert(BLL_SlotsMap BLL_SlotsMap_obj)
        {
            string Sql = @"INSERT INTO Slots 
                (Slot_Address, Slot_CharMap, Slot_Collector_Number, Slot_Status,Slot_LastReading_Date) 
                VALUES 
                (@SlotAddress, @SlotCharMap, @SlotCollectorNumber, @SlotStatus, @SlotLastReading_Date)";

            bool IsSucceeded = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, db.GetConn()))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@SlotAddress", BLL_SlotsMap_obj.Slot_Address);
                    cmd.Parameters.AddWithValue("@SlotCharMap", BLL_SlotsMap_obj.Slot_CharMap);
                    cmd.Parameters.AddWithValue("@SlotCollectorNumber", BLL_SlotsMap_obj.Slot_Collector_Number);
                    cmd.Parameters.AddWithValue("@SlotStatus", BLL_SlotsMap_obj.Slot_Status);
                    cmd.Parameters.AddWithValue("@SlotLastReading_Date", BLL_SlotsMap_obj.Slot_LastReading_Date);


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

        #region update in DB
        public bool Update(BLL_SlotsMap BLL_SlotsMap_obj)
        {
            string Sql = @"UPDATE Slots 
                        SET 
                            Slot_CharMap = @SlotCharMap, 
                            Slot_Status = @SlotStatus, 
                            Slot_LastReading_Date = @SlotLastReading_Date 
                        WHERE 
                            Slot_Address = @SlotAddress AND Slot_Collector_Number = @SlotCollectorNumber";

            bool IsSucceeded = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand(Sql, db.GetConn()))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@SlotCharMap", BLL_SlotsMap_obj.Slot_CharMap);
                    cmd.Parameters.AddWithValue("@SlotAddress", BLL_SlotsMap_obj.Slot_Address);
                    cmd.Parameters.AddWithValue("@SlotStatus", BLL_SlotsMap_obj.Slot_Status);
                    cmd.Parameters.AddWithValue("@SlotCollectorNumber", BLL_SlotsMap_obj.Slot_Collector_Number);
                    cmd.Parameters.AddWithValue("@SlotLastReading_Date", BLL_SlotsMap_obj.Slot_LastReading_Date);
                  

                    db.OpenConn();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        IsSucceeded = true;
                    }
                    else
                    {
                        MessageBox.Show("Please ,Don't Update Slot address or Collector Number");
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

        #region  Get Availbile Slots
        public int GetAvailableSlotsF1()
        {
            int availableSlots = 0;
            string sql = @"SELECT Count(Slot_Address)
                            FROM Slots
                            WHERE  Slot_Status=1 AND Slot_Floor_Number=1";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, db.GetConn()))
                {
                    db.OpenConn();
                    // Use ExecuteScalar to get the count result
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        availableSlots = Convert.ToInt32(result);
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

            return availableSlots;
        }

        public int GetAvailableSlotsF2()
        {
            int availableSlots = 0;
            string sql = @"SELECT Count(Slot_Address)
                            FROM Slots
                            WHERE  Slot_Status=1 AND Slot_Floor_Number=2";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, db.GetConn()))
                {
                    db.OpenConn();
                    // Use ExecuteScalar to get the count result
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        availableSlots = Convert.ToInt32(result);
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

            return availableSlots;
        }

        #endregion
    }
}
