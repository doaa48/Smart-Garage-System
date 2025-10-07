using GarageSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GarageSystem
{
    public partial class SerialConnection_Form : Form
    {
        SEL_SerialVisulization SEL_SerialVisulization_obj=new SEL_SerialVisulization();
        SEL_SlotsMap SEL_SlotsMap_obj = new SEL_SlotsMap();
        public SerialConnection_Form()
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

        #region Serial Functions
        private void SerialConnection_Form_Load(object sender, EventArgs e)
        {
            string[] Ports=SerialPort.GetPortNames();

            if (Ports != null && Ports.Length > 0)
            {
                guna2ComboBoxCOMPort.Items.AddRange(Ports);
                guna2ComboBoxCOMPort.SelectedIndex = 0;
            }
            
            guna2ComboBoxBaudRate.SelectedIndex = 1;
            guna2ComboBoxStopBits.SelectedIndex = 0;    
            guna2ComboBoxDataBits.SelectedIndex = 0;
            guna2ComboBoxParity.SelectedIndex = 0;

            Button_StopConnection.Enabled = false;
            richTextBoxSerialDataTransciever.Enabled = false;


        }

        private void Button_StartConnection_Click(object sender, EventArgs e)
        {
       
             if (guna2ComboBoxCOMPort.SelectedIndex>=0)
            {
                // Conversion successful, assign the parsed integer value
                SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_PortName = guna2ComboBoxCOMPort.Text;
            }
            else
            {
                MessageBox.Show("Enter USB initialy then Select COM Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }
            SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_BaudRate = int.Parse(guna2ComboBoxBaudRate.Text);
            SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_DataBits = int.Parse(guna2ComboBoxDataBits.Text);
            SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_Parity = (Parity)Enum.Parse(typeof(Parity), guna2ComboBoxParity.Text);
            SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_StopBits = (StopBits)Enum.Parse(typeof(StopBits), guna2ComboBoxStopBits.Text);

/*
            if (guna2ComboBoxBaudRate.SelectedIndex >= 0)
            {
                // Conversion successful, assign the parsed integer value
                SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_BaudRate = int.Parse(guna2ComboBoxCOMPort.Text);
            }
            else
            {
                MessageBox.Show("Select Baudrate Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }

            if (guna2ComboBoxDataBits.SelectedIndex >= 0)
            {
                // Conversion successful, assign the parsed integer value
                SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_DataBits = int.Parse(guna2ComboBoxDataBits.Text);
            }
            else
            {
                MessageBox.Show("Select Data Bits Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }



            if (guna2ComboBoxStopBits.SelectedIndex >= 0)
            {
                // Conversion successful, assign the parsed integer value
                SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_StopBits = (StopBits)Enum.Parse(typeof(StopBits), guna2ComboBoxStopBits.Text);
            }
            else
            {
                MessageBox.Show("Select Stop Bits Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }



            if (guna2ComboBoxParity.SelectedIndex >= 0)
            {
                // Conversion successful, assign the parsed integer value
                SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_Parity = (Parity)Enum.Parse(typeof(Parity), guna2ComboBoxParity.Text);
            }
            else
            {
                MessageBox.Show("Select Parity Bit Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }
*/


            Button_StopConnection.Enabled = true;
            Button_StartConnection.Enabled = false;
            richTextBoxSerialDataTransciever.Enabled = true;


            SEL_SerialVisulization_obj.SEL_SerialPortIntializer();
            SEL_SerialVisulization_obj.SEL_StartConnection();
            SEL_SerialVisulization_obj.SerialConnection_Obj.DataReceived += SEL_SlotsMap_obj.OnDataReceived;


        }

        private void Button_StopConnection_Click(object sender, EventArgs e)
        {

            Button_StopConnection.Enabled = false;
            richTextBoxSerialDataTransciever.Enabled = false;
            Button_StartConnection.Enabled = true;
            SEL_SerialVisulization_obj.SEL_StopConnection();
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            if (guna2ComboBoxCOMPort.SelectedIndex >= 0)
            {
                // Conversion successful, assign the parsed integer value
                SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_PortName = guna2ComboBoxCOMPort.Text;
            }
            else
            {
                MessageBox.Show("Enter USB initialy then Select COM Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method to prevent further execution
            }
            SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_BaudRate = int.Parse(guna2ComboBoxCOMPort.Text);
            SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_DataBits = int.Parse(guna2ComboBoxDataBits.Text);
            SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_Parity = (Parity)Enum.Parse(typeof(Parity), guna2ComboBoxParity.Text);
            SEL_SerialVisulization_obj.BLL_SerialConnection_obj.SerialConnection_StopBits = (StopBits)Enum.Parse(typeof(StopBits), guna2ComboBoxStopBits.Text);

            SEL_SerialVisulization_obj.SEL_SerialPortIntializer();

            MessageBox.Show("The Serial Initialization is done succssefully");

        }

        private void guna2ComboBoxCOMPort_Click(object sender, EventArgs e)
        {
            string[] Ports = SerialPort.GetPortNames();

            if (Ports != null && Ports.Length > 0)
            {
                guna2ComboBoxCOMPort.Items.Clear();

                guna2ComboBoxCOMPort.Items.AddRange(Ports);
            }
        }
       
        private void richTextBoxSerialDataTransciever_TextChanged(object sender, EventArgs e)
        {
            
                // Get the text from the RichTextBox
             string newText = richTextBoxSerialDataTransciever.Text;

             SEL_SerialVisulization_obj.SerialConnection_Obj.SendSerial(newText);

        }

        #endregion
    }
}
