using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GarageSystem
{
    public partial class Reservation : Form
    {
        SEL_Reservation SEL_Reservation_obj=new SEL_Reservation();
        SEL_SlotsMap   SEL_SlotsMap_obj=new SEL_SlotsMap(); 
        SEL_TicketBooking SEL_TicketBooking_obj=new SEL_TicketBooking();    

        public Reservation()
        {
            InitializeComponent();
            // Configure the Timer
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second intervals
            timer.Tick += new EventHandler(UpdateDateTime);
            timer.Start();
            SetAvilabileSlots();
            SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_StatusCause = "Permanent";



        }
        private void UpdateDateTime(object sender, EventArgs e)
        {
            Label_Current_Time.Text = DateTime.Now.ToString("F");
        }

        private void SetAvilabileSlots()
        {
            DataTable dt = SEL_Reservation_obj.SEL_GetAvialabeSlots();
            string[] array = dt.AsEnumerable()
                                  .Select(row => row.Field<string>("Slot_CharMap"))
                                  .ToArray();
            guna2ComboBox_SlotCharMap.Items.Clear();  

            guna2ComboBox_SlotCharMap.Items.AddRange(array);
        }

        private void checkBox_Month_Reservation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Month_Reservation.Checked)
            {
                groupBox_MonthReservation.Enabled = true;
            }
            else
            {
                groupBox_MonthReservation.Enabled = false;
            }
        }

        #region Exit Maximize Minimize
        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
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

        #endregion

        #region Sellecting forms


        private void Label_Logout_Click(object sender, EventArgs e)
        {
            Login_Form Login_Form_Obj = new Login_Form();
            this.Hide();
            Login_Form_Obj.Show();
        }
        private void label_BookingTicket_Click(object sender, EventArgs e)
        {
            TicketBooking_Form ticketBooking_Form_obj = new TicketBooking_Form();
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Hide();
                ticketBooking_Form_obj.WindowState = FormWindowState.Normal;

                ticketBooking_Form_obj.Show();
            }
            else
            {
                this.Hide();
                ticketBooking_Form_obj.WindowState = FormWindowState.Maximized;

                ticketBooking_Form_obj.Show();

            }
        }

        private void label_Home_Click(object sender, EventArgs e)
        {
            Home_Form Home_Form_Obj = new Home_Form();
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Hide();
                Home_Form_Obj.WindowState = FormWindowState.Normal;

                Home_Form_Obj.Show();
            }
            else
            {
                this.Hide();
                Home_Form_Obj.WindowState = FormWindowState.Maximized;

                Home_Form_Obj.Show();

            }
        }

        private void label_Reservation_Click(object sender, EventArgs e)
        {
            Reservation Reservation_obj = new Reservation();
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Hide();
                Reservation_obj.WindowState = FormWindowState.Normal;

                Reservation_obj.Show();
            }
            else
            {
                this.Hide();
                Reservation_obj.WindowState = FormWindowState.Maximized;

                Reservation_obj.Show();

            }
        }

        private void Label_History_Click(object sender, EventArgs e)
        {
            History_Form History_Form_Obj = new History_Form();
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Hide();
                History_Form_Obj.WindowState = FormWindowState.Normal;

                History_Form_Obj.Show();
            }
            else
            {
                this.Hide();
                History_Form_Obj.WindowState = FormWindowState.Maximized;

                History_Form_Obj.Show();

            }
        }

        private void label_Statistecs_Click(object sender, EventArgs e)
        {
            Statstics_Form Statstics_Form_obj = new Statstics_Form();
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Hide();
                Statstics_Form_obj.WindowState = FormWindowState.Normal;

                Statstics_Form_obj.Show();
            }
            else
            {
                this.Hide();
                Statstics_Form_obj.WindowState = FormWindowState.Maximized;

                Statstics_Form_obj.Show();

            }
        }

        private void Label_Trouble_Click(object sender, EventArgs e)
        {
            Troubl_From Troubl_From_obj = new Troubl_From();
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Hide();
                Troubl_From_obj.WindowState = FormWindowState.Normal;

                Troubl_From_obj.Show();
            }
            else
            {
                this.Hide();
                Troubl_From_obj.WindowState = FormWindowState.Maximized;

                Troubl_From_obj.Show();

            }
        }
        #endregion
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TextBox_UserName.Text = string.Empty;
            TextBox_Mobile.Text = string.Empty;
            TextBox_Payment.Text= string.Empty;
            TextBox_VehicleNo.Text = string.Empty;  
            TextBox_MonthesNumber.Text = string.Empty;  
            
        }

        private void Button_AddCar_Click(object sender, EventArgs e)
        {


            if (guna2ToggleSwitch_Perminat_Maintanice.Checked == false)
            {
                if (!string.IsNullOrEmpty(TextBox_UserName.Text))
                {
                    // Conversion successful, assign the parsed integer value
                    SEL_Reservation_obj.BLL_Reservation_obj.Reservation_ConsumName = TextBox_UserName.Text;
                }
                else
                {
                    MessageBox.Show("Customper name must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method to prevent further execution
                }



                if (!string.IsNullOrEmpty(TextBox_Mobile.Text))
                {
                    // Conversion successful, assign the parsed integer value
                    SEL_Reservation_obj.BLL_Reservation_obj.Reservation_ConsumPhone = TextBox_Mobile.Text;
                }
                else
                {
                    MessageBox.Show("Phone number must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method to prevent further execution
                }


                if (!string.IsNullOrEmpty(TextBox_VehicleNo.Text))
                {
                    // Conversion successful, assign the parsed integer value
                    SEL_Reservation_obj.BLL_Reservation_obj.Reservation_VehicleNumber = TextBox_VehicleNo.Text;
                }
                else
                {
                    MessageBox.Show("Vehcile number must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method to prevent further execution
                }


                SEL_Reservation_obj.BLL_Reservation_obj.Reservation_EnterDateTime = dateTimePicker_StartTime.Value;
                SEL_Reservation_obj.BLL_Reservation_obj.Reservation_ExitDateTime = dateTimePicker_EndTime.Value;


                SEL_Reservation_obj.BLL_Reservation_obj.Reservation_Payment = PaymentSystem(dateTimePicker_StartTime.Value, dateTimePicker_EndTime.Value);
                TextBox_Payment.Text = SEL_Reservation_obj.BLL_Reservation_obj.Reservation_Payment.ToString();
                TextBox_Payment.Enabled = false;

                // if the vehicle type is 4 wheel Send "1", else 2 wheel "0"
                SEL_Reservation_obj.BLL_Reservation_obj.Reservation_VehicleType = "4 Wheel";
                if (guna2CustomRadioButton2Wheel.Checked)
                {
                    SEL_Reservation_obj.BLL_Reservation_obj.Reservation_VehicleType = "2 Wheel";
                }
                SEL_Reservation_obj.BLL_Reservation_obj.Reservation_MonthlyState = 0;

                if (checkBox_Month_Reservation.Checked)
                {
                    SEL_Reservation_obj.BLL_Reservation_obj.Reservation_MonthlyState = 1;

                    if (!string.IsNullOrEmpty(TextBox_MonthesNumber.Text) && int.TryParse(TextBox_MonthesNumber.Text, out int MonthesNum))
                    {
                        // Conversion successful, assign the parsed integer value
                        SEL_Reservation_obj.BLL_Reservation_obj.Reservation_MonthsNumber = MonthesNum;
                    }
                    else
                    {
                        MessageBox.Show("Monthes number must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method to prevent further execution
                    }
                    SEL_Reservation_obj.BLL_Reservation_obj.Reservation_StartMonth = dateTimePicker_StartMonth.Value;

                }

                SEL_Reservation_obj.SEL_InsertData();
            }
            SEL_Reservation_obj.SEL_UpdateSlotStatus(guna2ComboBox_SlotCharMap.SelectedItem.ToString(), SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_StatusCause);
            GenerateTicketWithEnterExit();

        }

     
        void GenerateTicketWithEnterExit()
        {
           if(SEL_Reservation_obj.BLL_Reservation_obj.Reservation_MonthlyState==1)
           {

           }
           else
            {

            }
        }

        #region Payment system
         int PaymentSystem(DateTime dateTime_StartTime, DateTime dateTime_EndTime)
        {
            // Calculate the duration in minutes
               TimeSpan duration = dateTime_EndTime - dateTime_StartTime;

               double totalMinutes = duration.TotalMinutes;
           
               int intervalMinutes = SEL_TicketBooking_obj.BLL_TicketBooking_Obj.Ticket_Free_IntervalTime;

               string PriceModel= SEL_TicketBooking_obj.BLL_TicketBooking_Obj.Ticket_PricingModel;


            // Round duration according to the rules
            int roundedMinutes = RoundToNearestInterval((int)totalMinutes, intervalMinutes);

            // Pricing models
            switch (PriceModel)
            {
                case "consistent":
                    return CalculateConsistentPricing(roundedMinutes, intervalMinutes); // Hour price = 50 EGP

                case "dynamic":
                    return CalculateDynamicPricing(roundedMinutes);

                case "flat":
                    return CalculateFlatRatePricing(duration);

                default:
                    throw new ArgumentException("Invalid pricing model");
            }
        }

        // Helper functions
         int CalculateConsistentPricing(int totalMinutes, int intervalMinutes)
        {
            decimal hourlyRate = SEL_TicketBooking_obj.BLL_TicketBooking_Obj.Ticket_FixedRate;
            
            int numberOfIntervals = (totalMinutes + intervalMinutes - 1) / intervalMinutes; // Ceiling of division
            decimal totalCost = numberOfIntervals * (hourlyRate / 60) * intervalMinutes; // Proportional rate per interval
            return (int)totalCost;
        }

         int CalculateDynamicPricing(int totalMinutes)
        {

         
            decimal firstHourPrice = SEL_TicketBooking_obj.BLL_TicketBooking_Obj.Ticket_DifferentRate_hr1;
            decimal secondHourPrice = SEL_TicketBooking_obj.BLL_TicketBooking_Obj.Ticket_DifferentRate_hr2; ;
            decimal nextHoursPrice = SEL_TicketBooking_obj.BLL_TicketBooking_Obj.Ticket_DifferentRate_hr3;

            
           

            int numberOfIntervals = totalMinutes / 60;
            decimal totalCost = 0;

            if (numberOfIntervals >= 1)
            {
                totalCost += firstHourPrice;
            }
            if (numberOfIntervals >= 2)
            {
                totalCost += secondHourPrice;
            }
            if (numberOfIntervals > 2)
            {
                totalCost += (numberOfIntervals - 2) * nextHoursPrice;
            }

            return (int)totalCost;
        }

         int CalculateFlatRatePricing(TimeSpan duration)
        {
            decimal dayPrice = SEL_TicketBooking_obj.BLL_TicketBooking_Obj.Ticket_OvernightRate;
            

            // Check if the stay is overnight (24 hours)
            if (duration.TotalHours <=24)
            {
                return (int)dayPrice ;
            }
            else if (duration.TotalHours % 24 == 0)
            {
                return (int)dayPrice * ((int)(duration.TotalHours) / 24);
            }
            else
            {
                return (int)dayPrice * (((int)(duration.TotalHours) / 24) +1);
            }
        }

        static int RoundToNearestInterval(int minutes, int interval)
        {
            if (minutes < interval)
            {
                return 0; // If less than one interval, consider it as 0
            }

            // Round to nearest interval
            int remainder = minutes % interval;
            if (remainder == 0)
            {
                return minutes;
            }
            else if (remainder <= interval / 2)
            {
                return minutes - remainder;
            }
            else
            {
                return minutes + (interval - remainder);
            }
        }
        #endregion
        void Disable_FieldsForMantianance()
        {
            TextBox_UserName.Enabled = false;
            TextBox_Mobile.Enabled = false;
            TextBox_Payment.Enabled = false;
            TextBox_VehicleNo.Enabled = false;
            
            groupBox2.Enabled = false;
            dateTimePicker_EndTime.Enabled = false;
            dateTimePicker_StartTime.Enabled = false;
            checkBox_Month_Reservation.Enabled = false;
            groupBox_MonthReservation.Enabled = false;
        }

        void Enable_FieldsForMantianance()
        {
            TextBox_UserName.Enabled = false;
            TextBox_Mobile.Enabled = false;
            TextBox_Payment.Enabled = false;
            TextBox_VehicleNo.Enabled = false;

            groupBox2.Enabled = false;
            dateTimePicker_EndTime.Enabled = false;
            dateTimePicker_StartTime.Enabled = false;
            checkBox_Month_Reservation.Enabled = false;
            groupBox_MonthReservation.Enabled = false;
        }

        private void guna2ToggleSwitch_Perminat_Maintanice_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2ToggleSwitch_Perminat_Maintanice.Checked==true)
            {
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_StatusCause = "Maintance";
                Disable_FieldsForMantianance();



            }
            else
            {
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_StatusCause = "Permanent";
                Enable_FieldsForMantianance();

            }
        }
    }
}
