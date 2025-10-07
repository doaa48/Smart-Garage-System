using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SEL_Home
    {
        
        DAL_SlotsMap DAL_SlotsMap_obj = new DAL_SlotsMap();

        public int SEL_GetAvailableSlotsF1()
        {
            return DAL_SlotsMap_obj.GetAvailableSlotsF1();

        }

        public int SEL_GetAvailableSlotsF2()
        {
            return DAL_SlotsMap_obj.GetAvailableSlotsF2();

        }
    }
}
