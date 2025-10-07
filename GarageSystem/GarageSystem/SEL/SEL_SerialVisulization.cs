using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace GarageSystem
{
    public class SEL_SerialVisulization
    {
        public SerialConnection SerialConnection_Obj ;
        public BLL_SerialConnection BLL_SerialConnection_obj = new BLL_SerialConnection();

        public void SEL_SerialPortIntializer()
        {
             SerialConnection_Obj = new SerialConnection(BLL_SerialConnection_obj);
        }

        public void SEL_StartConnection()
        {
            SerialConnection_Obj.OpenConnection();
        }

        public void SEL_StopConnection()
        {
            SerialConnection_Obj.CloseConnection();
        }
    }
}
