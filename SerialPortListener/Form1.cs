using SerialPortListener.Serial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortListener
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        SerialPortManager _spManager;

        public MainForm()
        {
            InitializeComponent();

            UserInitialization();
        }

        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            serialSettingsBindingSource.DataSource = mySerialSettings;
            portNameCb.DataSource = mySerialSettings.PortNameCollection;
            baudRateCb.DataSource = mySerialSettings.BaudRateCollection;
            dataBitsCb.DataSource = mySerialSettings.DataBitsCollection;
            parityCb.DataSource = Enum.GetValues(typeof(System.IO.Ports.Parity));
            stopBitsCb.DataSource = Enum.GetValues(typeof(System.IO.Ports.StopBits));

            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }

        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }

            int maxTextLength = 1000; // maximum text length in text box
            if (resultTb.TextLength > maxTextLength)
                resultTb.Text = resultTb.Text.Remove(0, resultTb.TextLength - maxTextLength);

            // This application is connected to a GPS sending ASCCI characters, so data is converted to text
            string str = Encoding.ASCII.GetString(e.Data);
            resultTb.AppendText(str);
            resultTb.ScrollToCaret();
        }

        private void listenBtn_Click(object sender, EventArgs e)
        {
            if(listenBtn.Text == "Start Listening")
            {
                _spManager.StartListening();
                listenBtn.Text = "Stop Listening";
            }
            else
            {
                _spManager.StopListening();
                resultTb.Clear();
                listenBtn.Text = "Start Listening";
            }
        }
    }
}
