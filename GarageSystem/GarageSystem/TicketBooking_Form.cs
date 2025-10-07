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
    public partial class TicketBooking_Form : Form
    {
        SEL_TicketBooking SEL_TicketBooking_Obj=new SEL_TicketBooking();
        public TicketBooking_Form()
        {
            InitializeComponent();
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

        private void guna2CustomRadioButton_HourlyFixedRate_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CustomRadioButton_HourlyFixedRate.Checked)
            {
                guna2CustomRadioButton_HourlyDifferentRate.Checked = false;
                guna2CustomRadioButton_OvernightStaySystem.Checked = false;
                
                label_FixedRate.Enabled = true;
                guna2TextBoxFixedRate.Enabled = true;

                Label_D1stRate.Enabled = false;
                guna2TextBox_D1stRate.Enabled = false;

                Label_D2ndRate.Enabled = false;
                guna2TextBox_D2ndRate.Enabled = false;

                Label_D3rdRate.Enabled = false;
                guna2TextBox_D3rdRate.Enabled = false;

                label_DailyRate.Enabled = false;
                guna2TextBox_DailyRate.Enabled = false;

            }
        }

        private void guna2CustomRadioButton_HourlyDifferentRate_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomRadioButton_HourlyDifferentRate.Checked)
            {
                guna2CustomRadioButton_HourlyFixedRate.Checked = false;
                guna2CustomRadioButton_OvernightStaySystem.Checked = false;
                label_FixedRate.Enabled = false;
                guna2TextBoxFixedRate.Enabled = false;

                Label_D1stRate.Enabled = true;
                guna2TextBox_D1stRate.Enabled = true;

                Label_D2ndRate.Enabled = true;
                guna2TextBox_D2ndRate.Enabled = true;

                Label_D3rdRate.Enabled = true;
                guna2TextBox_D3rdRate.Enabled = true;

                label_DailyRate.Enabled = false;
                guna2TextBox_DailyRate.Enabled = false;
            }
        }

        private void guna2CustomRadioButton_OvernightStaySystem_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomRadioButton_OvernightStaySystem.Checked)
            {
                guna2CustomRadioButton_HourlyDifferentRate.Checked = false;
                guna2CustomRadioButton_HourlyFixedRate.Checked = false;

                label_FixedRate.Enabled = false;
                guna2TextBoxFixedRate.Enabled = false;

                Label_D1stRate.Enabled = false;
                guna2TextBox_D1stRate.Enabled = false;

                Label_D2ndRate.Enabled = false;
                guna2TextBox_D2ndRate.Enabled = false;

                Label_D3rdRate.Enabled = false;
                guna2TextBox_D3rdRate.Enabled = false;

                label_DailyRate.Enabled = true;
                guna2TextBox_DailyRate.Enabled = true;
            }
        }

        private void Button_GenerateTicket_Click(object sender, EventArgs e)
        {
           if (guna2CustomRadioButton_HourlyFixedRate.Checked)
            {
                SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_PricingModel = "consistent";
            }
            else if (guna2CustomRadioButton_HourlyDifferentRate.Checked)
            {
                SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_PricingModel = "dynamic";

            }
            else if (guna2CustomRadioButton_OvernightStaySystem.Checked)
            {
                SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_PricingModel = "flat";

            }

        }

        private void guna2TextBoxFixedRate_TextChanged(object sender, EventArgs e)
        {
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_FixedRate = int.Parse(guna2TextBoxFixedRate.Text);
        }

        private void guna2TextBox_D1stRate_TextChanged(object sender, EventArgs e)
        {
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_DifferentRate_hr1 = int.Parse(guna2TextBox_D1stRate.Text);

        }

        private void guna2TextBox_D3rdRate_TextChanged(object sender, EventArgs e)
        {
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_DifferentRate_hr3 = int.Parse(guna2TextBox_D3rdRate.Text);

        }

        private void guna2TextBox_DailyRate_TextChanged(object sender, EventArgs e)
        {
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_OvernightRate = int.Parse(guna2TextBox_DailyRate.Text);

        }
        private void guna2TextBox_D2ndRate_TextChanged(object sender, EventArgs e)
        {
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_DifferentRate_hr2 = int.Parse(guna2TextBox_D2ndRate.Text);

        }

        private void TicketBooking_Form_Load(object sender, EventArgs e)
        {
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_FixedRate = 50;
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_DifferentRate_hr1 = 70;
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_DifferentRate_hr2 = 60;
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_DifferentRate_hr3 = 40;
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_OvernightRate = 250;

            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_Free_IntervalTime = 15;

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked==true)
            {
                guna2TextBox_timeInterval.Enabled = true;
            }
            else
            {
                guna2TextBox_timeInterval.Enabled = false;

            }
        }

        private void guna2TextBox_timeInterval_TextChanged(object sender, EventArgs e)
        {
            SEL_TicketBooking_Obj.BLL_TicketBooking_Obj.Ticket_Free_IntervalTime = int.Parse(guna2TextBox_timeInterval.Text);
        }
    }
}
