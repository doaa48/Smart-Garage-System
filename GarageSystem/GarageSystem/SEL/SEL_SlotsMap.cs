using GarageSystem;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public class SEL_SlotsMap
    {

        public BLL_SlotsMap BLL_SlotsMap_obj = new BLL_SlotsMap();
        DAL_SlotsMap DAL_SlotsMap_obj = new DAL_SlotsMap();

        public const int TOTAL_NUMBER_OF_SLOTS_IN_FLOORS = 120;
        public const int FLOOR_NUMBER_1 = 1;
        public const int FLOOR_NUMBER_2 = 2;
        public const int NUMBER_OF_FLOORS = 2;
        public const int SLOTS_TO_COLLECTOR_CAPACITY = 30;
        public const int NUMBER_OF_COLLECTORS_IN_FLOOR = 4;
        public int[] RecievedPacket = { };
        int PacketLenght = 0;

        // Define a delegate for the event
    //    public delegate void SlotUpdateEventHandler(int floorNumber, int slotAddress, int slotState);

        // Declare the event
    //   public event SlotUpdateEventHandler SlotUpdate;

       
        public void OnDataReceived(string data)
        {
            //RecievedPacket[PacketLenght++]= data[0];

           // if(PacketLenght==3)
            //{
                //PacketLenght = 0;

                //todo to make for loop and wait to the end of the packet
                BLL_SlotsMap_obj.Slot_Status = (int)(data[2] - '0');
                BLL_SlotsMap_obj.Slot_Address = (int)(data[1] - '0');
                BLL_SlotsMap_obj.Slot_Collector_Number = (int)(data[0] - '0');
                BLL_SlotsMap_obj.Slot_LastReading_Date = DateTime.Now;

                if (BLL_SlotsMap_obj.Slot_Status ==0)
                {
                    BLL_SlotsMap_obj.Slot_StatusCause = "Reserved";
                }
                else
                {
                    BLL_SlotsMap_obj.Slot_StatusCause ="Avilable";

                }

                //define floor number
                if (BLL_SlotsMap_obj.Slot_Collector_Number >= 1 && BLL_SlotsMap_obj.Slot_Collector_Number <= NUMBER_OF_COLLECTORS_IN_FLOOR)
                {
                    BLL_SlotsMap_obj.Slot_Floor_Number = FLOOR_NUMBER_1;

                }
                else
                {
                    BLL_SlotsMap_obj.Slot_Floor_Number = FLOOR_NUMBER_2;
                }

                //Formulate Map char for Slot

                if (BLL_SlotsMap_obj.Slot_Address % 30 == 0)
                {
                    BLL_SlotsMap_obj.Slot_CharMap = "F" + BLL_SlotsMap_obj.Slot_Floor_Number.ToString() + (char)('A' + (BLL_SlotsMap_obj.Slot_Collector_Number - (1 + NUMBER_OF_COLLECTORS_IN_FLOOR * (BLL_SlotsMap_obj.Slot_Floor_Number - 1)))) + "30";

                }
                else
                {
                    BLL_SlotsMap_obj.Slot_CharMap = "F" + BLL_SlotsMap_obj.Slot_Floor_Number.ToString() + (char)('A' + (BLL_SlotsMap_obj.Slot_Collector_Number - (1 + NUMBER_OF_COLLECTORS_IN_FLOOR * (BLL_SlotsMap_obj.Slot_Floor_Number - 1)))) + (BLL_SlotsMap_obj.Slot_Address % 30).ToString();

                }


            DAL_SlotsMap_obj.Update(BLL_SlotsMap_obj);

        }
        public DataTable SEL_SelectSlotDataWithSlotAddress(string slotAddres)
        {
            return DAL_SlotsMap_obj.Select(slotAddres);
        }
        public DataTable SEL_SelectAllSlotsData()
        {
            return DAL_SlotsMap_obj.Select();
        }
        public DataTable SEL_SelectAllSlotsSpesificData()
        {
            return DAL_SlotsMap_obj.SelectSpesificData();
        }

        public bool SEL_InsertSlotData()
        {
            return DAL_SlotsMap_obj.Insert(BLL_SlotsMap_obj);

        }
        public bool SEL_UpdateSlotData()
        {
            return DAL_SlotsMap_obj.Update(BLL_SlotsMap_obj);

        }

   

    }
}
