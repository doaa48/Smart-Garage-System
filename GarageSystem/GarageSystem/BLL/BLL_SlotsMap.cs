using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BLL_SlotsMap
    {
        public int Slot_ID { get; set; }
        public int Slot_Address { get; set; }
        public string Slot_CharMap{ get; set; }
        public int Slot_Collector_Number { get; set; }
        public int  Slot_Status{ get; set; }
        public int Slot_Floor_Number { get; set; }

        public string Slot_StatusCause { get; set; }
        public DateTime  Slot_LastReading_Date { get; set; }
    }
}
