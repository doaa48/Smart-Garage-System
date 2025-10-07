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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GarageSystem
{
    public partial class History_Form : Form
    {
        SEL_History SEL_History_obj=new SEL_History();  
        public History_Form()
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

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView_History.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_History.DataSource = SEL_History_obj.SEL_FilterByDate(dateTimePicker_FilterDate.Value);
        }



        private void pictureBox_PrintSelectedDate_Click(object sender, EventArgs e)
        {
            dataGridView_History.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

              if (checkBoxFilter_by_Date.Checked == true && checkBox_Filter_By_VehcileNumber.Checked == true)
            {
                dataGridView_History.DataSource = SEL_History_obj.SEL_FilterByDateAndVehicleNum(dateTimePicker_FilterDate.Value, guna2TextBox_VehicleNumberFilter.Text);

            }
            else if (checkBoxFilter_by_Date.Checked == true)
            {
                dataGridView_History.DataSource = SEL_History_obj.SEL_FilterByDate(dateTimePicker_FilterDate.Value);

            }
            else if (checkBox_Filter_By_VehcileNumber.Checked == true)
            {
                dataGridView_History.DataSource = SEL_History_obj.SEL_FilterByVehcileNumber(guna2TextBox_VehicleNumberFilter.Text);

            }
             else
            {
                dataGridView_History.DataSource = SEL_History_obj.SEL_AllReservations();
                PdfExporter pdfExporter2 = new PdfExporter(" ", " All assigned Reservations in Garage ");
                pdfExporter2.ExportDataGridViewToPdf(dataGridView_History);
                return;
            }

            string title = "The Selected Date : ";

            PdfExporter pdfExporter = new PdfExporter(title + dateTimePicker_FilterDate.Value.ToString(), "Garage Report");
            pdfExporter.ExportDataGridViewToPdf(dataGridView_History);
        }

        private void Button_PrintAllReport_Click(object sender, EventArgs e)
        {
            dataGridView_History.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_History.DataSource = SEL_History_obj.SEL_AllReservations();


            PdfExporter pdfExporter = new PdfExporter(" ", " All assigned Reservations in Garage ");
            pdfExporter.ExportDataGridViewToPdf(dataGridView_History);
        }

        private void pictureBox_DailyData_Click(object sender, EventArgs e)
        {
            dataGridView_History.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_History.DataSource = SEL_History_obj.SEL_FilterByDate(DateTime.Now.Date);

            string title = "The Selected Date : ";

            PdfExporter pdfExporter = new PdfExporter(title + DateTime.Now.Date.ToString(), "Garage Daily Report");
            pdfExporter.ExportDataGridViewToPdf(dataGridView_History);
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

        private void History_Form_Load(object sender, EventArgs e)
        {
            dataGridView_History.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_History.DataSource = SEL_History_obj.SEL_AllReservations();
        }

        private void guna2TextBox_VehicleNumberFilter_TextChanged(object sender, EventArgs e)
        {
            dataGridView_History.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_History.DataSource = SEL_History_obj.SEL_FilterByVehcileNumber(guna2TextBox_VehicleNumberFilter.Text);
        }

        private void checkBoxFilter_by_Date_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFilter_by_Date.Checked==true)
            {
                dateTimePicker_FilterDate.Enabled = true;

            }
            else
            {
                dateTimePicker_FilterDate.Enabled = false;

            }

        }

        private void checkBox_Filter_By_VehcileNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Filter_By_VehcileNumber.Checked == true)
            {
                guna2TextBox_VehicleNumberFilter.Enabled = true;

            }
            else
            {
                guna2TextBox_VehicleNumberFilter.Enabled = false;

            }
        }
    }
}
