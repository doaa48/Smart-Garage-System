using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BLL_Trouble
    {
        public int Trouble_ID { get; set; }
        public int Trouble_CategoryNumber { get; set; }
        public string Trouble_Description { get; set; }
        public int Trouble_Tax{ get; set; }
        public string Trouble_VehcileNo{ get; set; }
        public DateTime Trouble_ExitDateTime { get; set; }

    }
}
