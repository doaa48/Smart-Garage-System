using System;
using System.IO.Ports;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GarageSystem
{
    public class SerialConnection
    {
        private SerialPort _serialPort;

        public event Action<string> DataReceived;

        public SerialConnection(BLL_SerialConnection BLL_SerialConnection_obj)
        {
            _serialPort = new SerialPort
            {
                PortName = BLL_SerialConnection_obj.SerialConnection_PortName,
                BaudRate = BLL_SerialConnection_obj.SerialConnection_BaudRate,
                DataBits = BLL_SerialConnection_obj.SerialConnection_DataBits,
                StopBits = BLL_SerialConnection_obj.SerialConnection_StopBits,
                Parity = BLL_SerialConnection_obj.SerialConnection_Parity,
            };

            // Subscribe to the DataReceived event
            _serialPort.DataReceived += SerialPort_DataReceived;
        }

        public SerialConnection()
        {
            
        }

        // Open Connection
        public void OpenConnection()
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                    MessageBox.Show("Connection opened successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Close Connection
        public void CloseConnection()
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    MessageBox.Show("Connection closed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to close connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Send Data
        public void SendSerial(string data)
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.WriteLine(data);
                 //   MessageBox.Show("Data sent successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection is not open.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for DataReceived
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read the data from the serial port
                string receivedData = _serialPort.ReadLine();

                // Raise the DataReceived event to notify subscribers
                DataReceived?.Invoke(receivedData);

                // Optionally, display a message box (can be removed if not needed)
               MessageBox.Show("Data received successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to receive data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Additional cleanup if necessary
        public void Dispose()
        {
            if (_serialPort != null)
            {
                _serialPort.Dispose();
            }
        }
    }
}
