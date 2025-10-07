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
    public partial class Slot_Dealing_Form : Form
    {
        SEL_SlotsMap SEL_SlotsMap_obj=new SEL_SlotsMap();

        public Slot_Dealing_Form()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second intervals
            timer.Tick += new EventHandler(UpdateDateTime);
            timer.Start();
            dataGridView_AllSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_AllSlots.DataSource=SEL_SlotsMap_obj.SEL_SelectAllSlotsData();
        }
        private void UpdateDateTime(object sender, EventArgs e)
        {
            Label_Current_Time.Text = DateTime.Now.ToString("F");
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            guna2TextBox_SAddress.Text = string.Empty;
            guna2TextBox_SCollectorNumber.Text = string.Empty;
            guna2TextBox_SLastReading.Text = string.Empty;
            guna2TextBox_SMapNumber.Text = string.Empty;
            guna2TextBox_SStatus.Text = string.Empty;
            guna2TextBox_SFloorNumber.Text = string.Empty;
        }
        private void Button_UpdateSlot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBox_SAddress.Text) && int.TryParse(guna2TextBox_SAddress.Text, out int slot_Address))
            {
                // Conversion successful, assign the parsed integer value
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_Address = slot_Address;
            }
            else
            {
                MessageBox.Show("Address number must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }



            if (!string.IsNullOrEmpty(guna2TextBox_SMapNumber.Text))
            {
                // Conversion successful, assign the parsed integer value
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_CharMap = guna2TextBox_SMapNumber.Text;
            }
            else
            {
                MessageBox.Show("Map Number must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }


            if (!string.IsNullOrEmpty(guna2TextBox_SCollectorNumber.Text) && int.TryParse(guna2TextBox_SCollectorNumber.Text, out int SCollectorNumber))
            {
                // Conversion successful, assign the parsed integer value
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_Collector_Number = SCollectorNumber;
            }
            else
            {
                MessageBox.Show("Collector number must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }

            if (!string.IsNullOrEmpty(guna2TextBox_SStatus.Text) && int.TryParse(guna2TextBox_SStatus.Text, out int SStatus))
            {
                // Conversion successful, assign the parsed integer value
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_Status = SStatus;
            }
            else
            {
                MessageBox.Show("Slot Status must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }

            SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_LastReading_Date = DateTime.Now;


            SEL_SlotsMap_obj.SEL_UpdateSlotData();
           // dataGridView_AllSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_AllSlots.DataSource = SEL_SlotsMap_obj.SEL_SelectAllSlotsData();

            clear();

        }

        private void Button_AddSlot_Click(object sender, EventArgs e)
        {

          
            if (!string.IsNullOrEmpty(guna2TextBox_SAddress.Text) && int.TryParse(guna2TextBox_SAddress.Text, out int slot_Address))
            {
                // Conversion successful, assign the parsed integer value
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_Address = slot_Address;
            }
            else
            {
                MessageBox.Show("Address number must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }



            if (!string.IsNullOrEmpty(guna2TextBox_SMapNumber.Text) )
            {
                // Conversion successful, assign the parsed integer value
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_CharMap = guna2TextBox_SMapNumber.Text;
            }
            else
            {
                MessageBox.Show("Map Number must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }


            if (!string.IsNullOrEmpty(guna2TextBox_SCollectorNumber.Text) && int.TryParse(guna2TextBox_SCollectorNumber.Text, out int SCollectorNumber))
            {
                // Conversion successful, assign the parsed integer value
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_Collector_Number = SCollectorNumber;
            }
            else
            {
                MessageBox.Show("Collector number must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }

            if (!string.IsNullOrEmpty(guna2TextBox_SStatus.Text) && int.TryParse(guna2TextBox_SStatus.Text, out int SStatus))
            {
                // Conversion successful, assign the parsed integer value
                SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_Status = SStatus;
            }
            else
            {
                MessageBox.Show("Slot Status must be a valid integer and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }

            SEL_SlotsMap_obj.BLL_SlotsMap_obj.Slot_LastReading_Date = DateTime.Now;



            SEL_SlotsMap_obj.SEL_InsertSlotData();


           // dataGridView_AllSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView_AllSlots.DataSource = SEL_SlotsMap_obj.SEL_SelectAllSlotsData();

            clear();


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

        private void dataGridView_AllSlots_SelectionChanged(object sender, EventArgs e)
        {
           
                // Check if any row is selected
                if (dataGridView_AllSlots.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView_AllSlots.SelectedRows[0];

                    // Assign the values to the corresponding Guna2TextBox controls
                    guna2TextBox_SAddress.Text = selectedRow.Cells["Slot_Address"].Value?.ToString();
                    guna2TextBox_SCollectorNumber.Text = selectedRow.Cells["Slot_Collector_Number"].Value?.ToString();
                    guna2TextBox_SLastReading.Text = selectedRow.Cells["Slot_LastReading_Date"].Value?.ToString();
                    guna2TextBox_SMapNumber.Text = selectedRow.Cells["Slot_CharMap"].Value?.ToString();
                    guna2TextBox_SStatus.Text = selectedRow.Cells["Slot_Status"].Value?.ToString();
                    guna2TextBox_SFloorNumber.Text = selectedRow.Cells["Slot_Floor_Number"].Value?.ToString();

            }


        }

        private void pictureBox_Return_Click(object sender, EventArgs e)
        {
            SlotsMap_Form SlotsMap_Form_obj = new SlotsMap_Form();
            if (this.WindowState == FormWindowState.Normal)
            {

                SlotsMap_Form_obj.WindowState = FormWindowState.Normal;
                this.Hide();
                SlotsMap_Form_obj.Show();
            }
            else
            {
                SlotsMap_Form_obj.WindowState = FormWindowState.Maximized;
                this.Hide();
                SlotsMap_Form_obj.Show();

            }
        }

    
    }


     
    
}
