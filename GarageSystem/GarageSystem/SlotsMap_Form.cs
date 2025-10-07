using iText.StyledXmlParser.Jsoup.Select;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;



namespace GarageSystem
{
    public partial class SlotsMap_Form : Form
    {
        SEL_SlotsMap SEL_SlotsMap_obj = new SEL_SlotsMap();
       

        public SlotsMap_Form()
        {
            InitializeComponent();

            //SEL_SlotsMap_obj.SlotUpdate += UpdateSlotBackColor;

            // Configure the Timer
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second intervals
            timer.Tick += new EventHandler(UpdateDateTime);
            timer.Start();

        }
        private void UpdateDateTime(object sender, EventArgs e)
        {
            Label_Current_Time.Text = DateTime.Now.ToString("F");
        }


        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pictureBox_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {

                this.WindowState = FormWindowState.Normal;
            }

        }

        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox_Return_Click(object sender, EventArgs e)
        {
            Home_Form home_Form = new Home_Form();
            if (this.WindowState == FormWindowState.Normal)
            {

                home_Form.WindowState = FormWindowState.Normal;
                this.Hide();
                home_Form.Show();
            }
            else
            {
                home_Form.WindowState = FormWindowState.Maximized;
                this.Hide();
                home_Form.Show();

            }
        }

        // Method to update the BackColor of a specific slot
        public void UpdateSlotBackColor(int FloorNumber,int slotAddress, int SlotState,string SlotReservationCause)
        {
            //MessageBox.Show($"Floor: {FloorNumber}, Slot: {slotAddress}, State: {SlotState}");
            // Construct the name of the label based on the slot number
            string labelName ="";

            if (FloorNumber == SEL_SlotsMap.FLOOR_NUMBER_2)
            {
                 labelName = "Slot1_" + slotAddress.ToString();

            }
            else
            {
                labelName = "Slot_" + slotAddress.ToString();

            }

            // Find the label by name
            Label slotLabel = this.Controls.Find(labelName, true).FirstOrDefault() as Label;

            // If the label exists, update its BackColor
            if (slotLabel != null && SlotState==0)
            {
                if(SlotReservationCause== "Permanent")
                {
                    //orange
                    slotLabel.BackColor = Color.DarkOrange;

                }
                else if (SlotReservationCause == "Maintance")
                {
                    //Yello
                    slotLabel.BackColor = Color.YellowGreen;

                }
                else if (SlotReservationCause == "Reserved")
                {
                    slotLabel.BackColor = Color.FromArgb(192, 0, 0);

                }

            }
            else if (slotLabel != null && SlotState == 1)
            {
                slotLabel.BackColor =Color.Green ;

            }
        }

        private void pictureBox_SlotManagment_Click(object sender, EventArgs e)
        {
            Slot_Dealing_Form Slot_Dealing_Form_obj = new Slot_Dealing_Form();
            if (this.WindowState == FormWindowState.Normal)
            {

                Slot_Dealing_Form_obj.WindowState = FormWindowState.Normal;
                this.Hide();
                Slot_Dealing_Form_obj.Show();
            }
            else
            {
                Slot_Dealing_Form_obj.WindowState = FormWindowState.Maximized;
                this.Hide();
                Slot_Dealing_Form_obj.Show();

            }
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            Update_SlotMap();
        }

        private void SlotsMap_Form_Load(object sender, EventArgs e)
        {
            Update_SlotMap();

        }

        void Update_SlotMap()
        {
            int i = 0;
            for (i = 0; i < SEL_SlotsMap.TOTAL_NUMBER_OF_SLOTS_IN_FLOORS; i++)
            {
                UpdateSlotBackColor(SEL_SlotsMap.FLOOR_NUMBER_1, i + 1, 1, "Avilable");
            }
            for (i = 0; i < SEL_SlotsMap.TOTAL_NUMBER_OF_SLOTS_IN_FLOORS; i++)
            {
                UpdateSlotBackColor(SEL_SlotsMap.FLOOR_NUMBER_2, i + 1, 1, "Avilable");
            }

            DataTable Dt = SEL_SlotsMap_obj.SEL_SelectAllSlotsSpesificData();
            foreach (DataRow row in Dt.Rows)
            {
                if (Convert.ToInt32(row["Slot_Status"]) == 0)
                {
                    UpdateSlotBackColor(Convert.ToInt32(row["Slot_Floor_Number"]), Convert.ToInt32(row["Slot_Address"]), Convert.ToInt32(row["Slot_Status"]), row["Slot_StatusCause"].ToString());
                }
            }
        }
    }
}
