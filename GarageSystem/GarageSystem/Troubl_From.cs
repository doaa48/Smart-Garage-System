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
    public partial class Troubl_From : Form
    {
        SEL_Trouble SEL_Trouble_obj = new SEL_Trouble();
        public Troubl_From()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second intervals
            timer.Tick += new EventHandler(UpdateDateTime);
            timer.Start();
        }
        #region UI description
        private void UpdateDateTime(object sender, EventArgs e)
        {
            Label_Current_Time.Text = DateTime.Now.ToString("F");
        }
        private void Label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Label_Logout_Click(object sender, EventArgs e)
        {
            Login_Form Login_Form_Obj = new Login_Form();
            this.Hide();
            Login_Form_Obj.Show();
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


        #endregion

        #region Fill Data




        #endregion

        private void Troubl_From_Load(object sender, EventArgs e)
        {

            DataTable DT= SEL_Trouble_obj.SEL_SelectCategories();
            List<int> categoryIds = new List<int>();

            foreach (DataRow row in DT.Rows)
            {
                int categoryId = Convert.ToInt32(row["Trouble_CategoryNumber"]); // Adjust column name as needed
                categoryIds.Add(categoryId);
            }
              guna2ComboBox_Trouble_Category.DataSource = categoryIds;
              guna2ComboBox_Trouble_Category.SelectedIndex = -1;

        }

        private void Button_AddTrouble_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(guna2TextBox_VehcileNo.Text) )
            {
                SEL_Trouble_obj.BLL_Trouble_obj.Trouble_VehcileNo = guna2TextBox_VehcileNo.Text;

            }
            else
            {
                MessageBox.Show("Vehicle number  must be Entered");

            }
            if (guna2ComboBox_Trouble_Category.SelectedIndex>=0)
            {
                SEL_Trouble_obj.BLL_Trouble_obj.Trouble_CategoryNumber = int.Parse(guna2ComboBox_Trouble_Category.SelectedItem?.ToString());

            }
            else
            {
                MessageBox.Show("Trouble Category must be selected");
            }
            SEL_Trouble_obj.BLL_Trouble_obj.Trouble_Description = guna2TextBox_TroubleDescription.Text;
            SEL_Trouble_obj.BLL_Trouble_obj.Trouble_ExitDateTime = dateTimePicker_ExitTime.Value;
            guna2TextBox_Taxes.Text = CalculateTaxes(SEL_Trouble_obj.BLL_Trouble_obj.Trouble_CategoryNumber).ToString();
            SEL_Trouble_obj.BLL_Trouble_obj.Trouble_Tax = int.Parse(guna2TextBox_Taxes.Text);
            SEL_Trouble_obj.SEL_InsertData();

        }

        static int CalculateTaxes(int troubleCategory)
        {
            int taxAmount = 0;

            switch (troubleCategory)
            {
                case 1:
                    taxAmount= 100;
                    break;

                case 2:
                    taxAmount = 200; 
                    break;

                case 3:
                    taxAmount = 300; 
                    break;

                default:
                    throw new ArgumentException("Invalid trouble category");
            }

            return taxAmount;
        }


    }
}
