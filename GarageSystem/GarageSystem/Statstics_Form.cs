using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1;

namespace GarageSystem
{
    public partial class Statstics_Form : Form
    {
        SEL_Statstics SEL_Statstics_obj=new SEL_Statstics();    
        public Statstics_Form()
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


        #region Exit Minimize Maximize Bar

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

        #endregion


        # region Selecting Forms
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

        private void Label_Logout_Click(object sender, EventArgs e)
        {
            Login_Form Login_Form_Obj = new Login_Form();
            this.Hide();
            Login_Form_Obj.Show();
        }


        #endregion


        #region Load statistices
        private void LoadSlotsAvilabilityRelationF1Data()
        {

            int totalNoSlots = SEL_SlotsMap.TOTAL_NUMBER_OF_SLOTS_IN_FLOORS;  ///todo
            int AvailableSlots = SEL_Statstics_obj.SEL_GetAvailableSlotsF1();  ////todo
            int UnAvailableSlots = totalNoSlots - AvailableSlots;


            // Clear existing series
            SlotsAvilabilityRelationF1.Series.Clear();

            // Create a new series
            Series series = new Series
            {
                Name = "Available Slots",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            // Define better contrasting colors
            Color AvailableSlotsColor = Color.ForestGreen;  // Better green color
            Color UnAvailableSlotsColor = Color.DarkSlateBlue;    // Better red color

            // Add data points to the series
            DataPoint chargedPoint = new DataPoint
            {
                AxisLabel = "Available Slots",
                YValues = new double[] { AvailableSlots },
                Color = AvailableSlotsColor,
                Label = $"{AvailableSlots} ({AvailableSlots * 100.0 / totalNoSlots:F1}%)" // Number and percentage inside slice
            };
            series.Points.Add(chargedPoint);

            DataPoint nonChargedPoint = new DataPoint
            {
                AxisLabel = "Reserved Slots",
                YValues = new double[] { UnAvailableSlots },
                Color = UnAvailableSlotsColor,
                Label = $"{UnAvailableSlots} ({UnAvailableSlots * 100.0 / totalNoSlots:F1}%)" // Number and percentage inside slice
            };
            series.Points.Add(nonChargedPoint);

            // Add the series to the chart
            SlotsAvilabilityRelationF1.Series.Add(series);

            // Customize the chart title
            SlotsAvilabilityRelationF1.Titles.Clear();
            Title title = new Title
            {
                Text = "Downstairs Slots Avilability Relation",
                Font = new Font("Arial", 13, FontStyle.Regular),
                ForeColor = Color.Black,
                Docking = Docking.Top,
                Alignment = ContentAlignment.MiddleCenter
            };
            SlotsAvilabilityRelationF1.Titles.Add(title);





            // Restore previous legend customization
            SlotsAvilabilityRelationF1.Legends.Clear();
            Legend legend = new Legend
            {
                Docking = Docking.Bottom,
                Font = new Font("Arial", 12),
                Alignment = StringAlignment.Center
            };
            SlotsAvilabilityRelationF1.Legends.Add(legend);

            // Customize the data point labels with dynamic font size
            foreach (DataPoint point in series.Points)
            {
                point.LabelForeColor = Color.White;
                point.Font = new Font("Arial", 10, FontStyle.Regular);
                // Labels inside slices: display number and percentage
                point.Label = $"{point.YValues[0]} ({point.YValues[0] * 100.0 / totalNoSlots:F1}%)";

                // Set custom text for the legend
                point.LegendText = $"{point.AxisLabel} ({point.YValues[0]})";

                // Center the label inside the slice
                point["LabelStyle"] = "Center";
            }


            //Color the background of chart and its legends
            SlotsAvilabilityRelationF1.BackColor = SystemColors.Control; // Set the background color of the chart to match the form's background
            SlotsAvilabilityRelationF1.ChartAreas[0].BackColor = SystemColors.Control; // Set the background color of the chart area

            foreach (Legend legende in SlotsAvilabilityRelationF1.Legends)
            {
                legend.BackColor = SystemColors.Control;
            }



            // Display only number and percentage inside slices
            series["PieLabelStyle"] = "Inside";
            series["PieStartAngle"] = "0"; // Start angle for better visibility
            series["PieDrawingStyle"] = "SoftEdge"; // Add soft edge style for better appearance

        }

        private void LoadSlotsAvilabilityRelationF2Data()
        {

            int totalNoSlots = SEL_SlotsMap.TOTAL_NUMBER_OF_SLOTS_IN_FLOORS;  ///todo
            int AvailableSlots = SEL_Statstics_obj.SEL_GetAvailableSlotsF2();  ////todo
            int UnAvailableSlots = totalNoSlots - AvailableSlots;



            // Clear existing series
            SlotsAvilabilityRelationF2.Series.Clear();

            // Create a new series
            Series series = new Series
            {
                Name = "Available Slots",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            // Define better contrasting colors
            Color AvailableSlotsColor = Color.DarkKhaki;  // Better green color
            Color UnAvailableSlotsColor = Color.RosyBrown;    // Better red color

            // Add data points to the series
            DataPoint chargedPoint = new DataPoint
            {
                AxisLabel = "Available Slots",
                YValues = new double[] { AvailableSlots },
                Color = AvailableSlotsColor,
                Label = $"{AvailableSlots} ({AvailableSlots * 100.0 / totalNoSlots:F1}%)" // Number and percentage inside slice
            };
            series.Points.Add(chargedPoint);

            DataPoint nonChargedPoint = new DataPoint
            {
                AxisLabel = "Reserved Slots",
                YValues = new double[] { UnAvailableSlots },
                Color = UnAvailableSlotsColor,
                Label = $"{UnAvailableSlots} ({UnAvailableSlots * 100.0 / totalNoSlots:F1}%)" // Number and percentage inside slice
            };
            series.Points.Add(nonChargedPoint);

            // Add the series to the chart
            SlotsAvilabilityRelationF2.Series.Add(series);

            // Customize the chart title
            SlotsAvilabilityRelationF2.Titles.Clear();
            Title title = new Title
            {
                Text = "Upstairs Slots Avilability Relation",
                Font = new Font("Arial", 13, FontStyle.Regular),
                ForeColor = Color.Black,
                Docking = Docking.Top,
                Alignment = ContentAlignment.MiddleCenter
            };
            SlotsAvilabilityRelationF2.Titles.Add(title);





            // Restore previous legend customization
            SlotsAvilabilityRelationF2.Legends.Clear();
            Legend legend = new Legend
            {
                Docking = Docking.Bottom,
                Font = new Font("Arial", 12),
                Alignment = StringAlignment.Center
            };
            SlotsAvilabilityRelationF2.Legends.Add(legend);

            // Customize the data point labels with dynamic font size
            foreach (DataPoint point in series.Points)
            {
                point.LabelForeColor = Color.White;
                point.Font = new Font("Arial", 10, FontStyle.Regular);
                // Labels inside slices: display number and percentage
                point.Label = $"{point.YValues[0]} ({point.YValues[0] * 100.0 / totalNoSlots:F1}%)";

                // Set custom text for the legend
                point.LegendText = $"{point.AxisLabel} ({point.YValues[0]})";

                // Center the label inside the slice
                point["LabelStyle"] = "Center";
            }


            //Color the background of chart and its legends
            SlotsAvilabilityRelationF2.BackColor = SystemColors.Control; // Set the background color of the chart to match the form's background
            SlotsAvilabilityRelationF2.ChartAreas[0].BackColor = SystemColors.Control; // Set the background color of the chart area

            foreach (Legend legende in SlotsAvilabilityRelationF2.Legends)
            {
                legend.BackColor = SystemColors.Control;
            }



            // Display only number and percentage inside slices
            series["PieLabelStyle"] = "Inside";
            series["PieStartAngle"] = "0"; // Start angle for better visibility
            series["PieDrawingStyle"] = "SoftEdge"; // Add soft edge style for better appearance

        }

        public int LoadDailyReservations()
        {
            int dailyReservarions = SEL_Statstics_obj.SEL_GetDailyReservations();
            guna2HtmlLabel_dailyReservarions.Text = dailyReservarions.ToString();
            return dailyReservarions;
        }

        private void Statstics_Form_Load(object sender, EventArgs e)
        {
            LoadSlotsAvilabilityRelationF1Data();
            LoadSlotsAvilabilityRelationF2Data();

            progressBar_DailyReservations.Minimum = 0;
            progressBar_DailyReservations.Maximum = SEL_Statstics_obj.SEL_GetAllReservations();  // Set this value based on your expected reservations
            progressBar_DailyReservations.Value = LoadDailyReservations();

            dataGridView_Troubles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_Troubles.DataSource = SEL_Statstics_obj.SEL_SelectTroubles();
        }
        #endregion


        private void dataGridView_Troubles_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView_Troubles.CurrentRow != null)
            {
                // Get values from the current row's cells
                guna2TextBoxTDescrip.Text = dataGridView_Troubles.CurrentRow.Cells["Trouble_CategoryNumber"].Value.ToString();
                guna2TextBox_TTaxes.Text = dataGridView_Troubles.CurrentRow.Cells["Trouble_CategoryNumber"].Value.ToString();
                guna2TextBox_TCateNo.Text = dataGridView_Troubles.CurrentRow.Cells["Trouble_CategoryNumber"].Value.ToString();

                int TroubleID = int.Parse(dataGridView_Troubles.CurrentRow.Cells["Trouble_ID"].Value.ToString());
                BLL_Reservation BLL_Reservation_obj = SEL_Statstics_obj.SEL_GetCustomerDataRelatedToTrouble(TroubleID);

                // Assign data to the TextBoxes
                if (BLL_Reservation_obj != null)
                {
                    guna2TextBox_VehicleNumber.Text = BLL_Reservation_obj.Reservation_VehicleNumber.ToString();
                    guna2TextBox_Mobile.Text = BLL_Reservation_obj.Reservation_ConsumPhone.ToString();
                    guna2TextBox_StartTime.Text = BLL_Reservation_obj.Reservation_EnterDateTime.ToString();
                    guna2TextBox_EndTime.Text = BLL_Reservation_obj.Reservation_ExitDateTime.ToString();
                }
                else
                {
                    guna2TextBox_VehicleNumber.Text = "";
                    guna2TextBox_Mobile.Text = "";
                    guna2TextBox_StartTime.Text = "";
                    guna2TextBox_EndTime.Text = "";

                }
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

    }
}
