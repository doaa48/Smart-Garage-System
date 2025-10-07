using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BLL_Reservation
    {
        public int Reservation_ID { get; set; }
        public string Reservation_ConsumName { get; set; }
        public string Reservation_ConsumPhone { get; set; }
        public string Reservation_VehicleNumber { get; set; }
        public int Reservation_Payment { get; set; }
        public DateTime Reservation_EnterDateTime { get; set; }
        public DateTime Reservation_ExitDateTime { get; set; }
        public string Reservation_VehicleType { get; set; }
        public int Reservation_MonthlyState { get; set; }
        public DateTime Reservation_StartMonth { get; set; }
        public int Reservation_MonthsNumber { get; set; }
        public int Reservation_TroubleID { get; set; }


    }
}
