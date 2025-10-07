using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SEL_Statstics
    {

        public BLL_Statstics BLL_Statstics_obj = new BLL_Statstics();
        public DAL_Statstics DAL_Statstics_obj = new DAL_Statstics();


        public int SEL_GetAvailableSlotsF1()
        {
            return DAL_Statstics_obj.GetAvailableSlotsF1();

        }

        public int SEL_GetAvailableSlotsF2()
        {
            return DAL_Statstics_obj.GetAvailableSlotsF2();

        }
        public DataTable SEL_SelectTroubles()
        {
            return DAL_Statstics_obj.SelectTroubles();

        }
        public BLL_Reservation SEL_GetCustomerDataRelatedToTrouble(int TroubleID)
        {
            return DAL_Statstics_obj.GetCustomerDataRelatedToTrouble( TroubleID);

        }

        public int SEL_GetAllReservations()
        {
            return DAL_Statstics_obj.GetAllReservations();
        }
        public int SEL_GetDailyReservations()
        {
            return DAL_Statstics_obj.GetDailyReservations();
        }
    }
}
