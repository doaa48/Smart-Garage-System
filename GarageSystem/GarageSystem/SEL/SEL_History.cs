using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SEL_History
    {
        
        public BLL_History BLL_History_obj = new BLL_History();
        DAL_History DAL_History_obj = new DAL_History();


        public DataTable SEL_FilterByDate(DateTime dateTimePicker_FilterDate)
        {
            return DAL_History_obj.Select(dateTimePicker_FilterDate);
        }
        public DataTable SEL_FilterByVehcileNumber(string VehicleNum)
        {
            return DAL_History_obj.GetDataOfVehicleNum(VehicleNum);
        }

        public DataTable SEL_AllReservations()
        {
            return DAL_History_obj.Select();
        }

        public DataTable SEL_FilterByDateAndVehicleNum(DateTime Date, string VehicleNumberFilter)
        {
            return DAL_History_obj.GetDataOfVehicleNumAndDate(Date, VehicleNumberFilter);
        }
    }
}
