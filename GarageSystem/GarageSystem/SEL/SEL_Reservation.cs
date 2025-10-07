using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SEL_Reservation
    {

        public BLL_Reservation BLL_Reservation_obj = new BLL_Reservation();
        public DAL_Reservation DAL_Reservation_obj = new DAL_Reservation();
        public DataTable SEL_GetAvialabeSlots()
        {
            return DAL_Reservation_obj.SelectSCharMap();

         }
        public bool SEL_InsertData()
        {
           return DAL_Reservation_obj.Insert(BLL_Reservation_obj);
;
        }

        public void SEL_UpdateSlotStatus(string SlotCharMap,string SlotStatusCause)
        {
            DAL_Reservation_obj.UpdateSlotStatus(SlotCharMap, SlotStatusCause);
        }
    }
}
