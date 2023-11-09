using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace AirCraftController
{
    public partial class Form1 : Form
    {
        const UInt16 ROW_COUNT = 8;
        RemoteFlightController flightController;

        public delegate void AddMessageDelegate(Telemetry_Update obj);
        public delegate void ControllerUpdateSent(Controls_Update obj); 
        public delegate void WarningCodeDanger(string str);

        public Form1()
        {
            InitializeComponent();
            getIPAddress(); 
            flightController = new RemoteFlightController(); //Allows interaction between the 'Form1' class and the RemoteFlightController

            //Subscribes all functions to its appropriate publisher
            flightController.messageRecieved += new AddMessageDelegate(displayRecievedJSON);
            flightController.controllerUpdated += new ControllerUpdateSent(displayOutgoingJSON);
            flightController.warningCodeUnsafe += new WarningCodeDanger(displayWarningLevel);
        }

        #region RemoteFlightController_Class
        class RemoteFlightController
        {
            public TcpClient client;
            public Thread messageInThread;

            public event AddMessageDelegate messageRecieved;
            public event ControllerUpdateSent controllerUpdated;
            public event WarningCodeDanger warningCodeUnsafe;

            //The function responsible for sending control updates to the flight simulation,
            //first taking the parsed throttle and pitch values set by the user and converting into a Control_Update object 
            //this object is then serialized and sent via the client socket
            public void sendJSON(double throttle, double pitch)
            {
                Controls_Update controlsUpdate = new Controls_Update();
                controlsUpdate.Throttle = throttle;
                controlsUpdate.ElevatorPitch = pitch / 20.0;

                string JSON = new JavaScriptSerializer().Serialize(controlsUpdate); 
                try
                {
                    NetworkStream stream = client.GetStream();
                    byte[] outgoingMsg = Encoding.ASCII.GetBytes(JSON);
                    stream.Write(outgoingMsg, 0, outgoingMsg.Length);
                    //If successful the controllerUpdated event is invoked, displaying the sent information on-screen for the User
                    controllerUpdated.Invoke(controlsUpdate);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problem sending JSON information!");
                }
            }
            //The function responsible for recieving incoming JSON information and deserializing into a Telemtry_Updates object type
            //success in converting to the new object type, will in turn invoke the messageRecieved event, again parsing this object to its
            //publishers and displaying the information on-screen in the DataGridView table
            public void receiveIncomingJSON()
            {
                NetworkStream stream = this.client.GetStream();
                byte[] incomingMsg = new byte[256];
                while (this.client != null)
                {
                    int count;
                    try
                    {
                        count = stream.Read(incomingMsg, 0, 256);

                        string str = Encoding.ASCII.GetString(incomingMsg, 0, count);

                        Telemetry_Update telemetry_Update = new JavaScriptSerializer().Deserialize<Telemetry_Update>(str);
                        messageRecieved.Invoke(telemetry_Update);

                        if (telemetry_Update.WarningCode > 0)
                            warningCodeUnsafe.Invoke(telemetry_Update.WarningCode.ToString());
                        else
                            warningCodeUnsafe.Invoke("0");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error when recieving JSON information!");
                        break;
                    }
                }
            }
            //Connects the RemoteFlightController to the chosen client via a socket, success in doing so then assigns the recieveIncomingMessage
            //function to its own thread, allowing the main thread to continue handling logic/performing actions
            //Returning true if connection is established
            public bool connectClient(IPAddress ip, int port)
            {
                try
                {
                    client = new TcpClient();
                    client.Connect(ip, port);
                    messageInThread = new Thread(new ThreadStart(receiveIncomingJSON));
                    messageInThread.Start();
                    return true;
                }
                catch(Exception)
                {
                    MessageBox.Show("Unable to Connect!");
                    return false;
                }
            }
        }
        #endregion



        //Populates the comboBox with available local IPAddresses 
        public void getIPAddress()
        {
            foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    this.cbo_IPAddresses.Items.Add((object)address);
            }
            if (this.cbo_IPAddresses.Items.Count <= 0)
                throw new Exception("Local IP Address Not Found!");
            this.cbo_IPAddresses.SelectedIndex = 0;
        }

        //When messageRecieved event is invoked, this function is called, taking the newly converted JSON string
        //and displaying its relevant information onto the GUI for the User to see 
        public void displayRecievedJSON(Telemetry_Update telemetry_Update)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AddMessageDelegate(displayRecievedJSON), new object[] { telemetry_Update });
            }
            else
            {
                lbl_JSONRecieved.Text = new JavaScriptSerializer().Serialize(telemetry_Update);
                //Logic for restricting the row count in the DataGridView table, done to restrict overload of information for the user
                //can be changed by changing the ROW_COUNT const
                if (this.tab_TelemetryDisplay.RowCount > ROW_COUNT)
                    this.tab_TelemetryDisplay.Rows.RemoveAt(this.tab_TelemetryDisplay.RowCount - 2);

                //Inserts incoming telemetry data to DataGridView table top-down 
                this.tab_TelemetryDisplay.Rows.Insert
                    (0, new object[] {telemetry_Update.Altitude, telemetry_Update.Speed, telemetry_Update.Pitch,
                    telemetry_Update.VerticalSpeed, telemetry_Update.Throttle, telemetry_Update.ElevatorPitch, telemetry_Update.WarningCode });

                //Updates appropriate display labels, formatted to have 3 d.p.
                this.lbl_DATA_AltitudeDisplay.Text = telemetry_Update.Altitude.ToString("0.000");
                this.lbl_DATA_SpeedDisplay.Text = telemetry_Update.Speed.ToString("0.000");
                this.lbl_DATA_PitchDisplay.Text = telemetry_Update.Pitch.ToString("0.000");
                this.lbl_DATA_VSpeedDisplay.Text = telemetry_Update.VerticalSpeed.ToString("0.000");
                this.lbl_DATA_ThrottleDisplay.Text = telemetry_Update.Throttle.ToString("0.000");
                this.lbl_DATA_ElevationDisplay.Text = telemetry_Update.ElevatorPitch.ToString("0.000");
                this.lbl_WarningCodeDisplay.Text = telemetry_Update.WarningCode.ToString("0.000");
            }
        }
        //Upon invoking of the controllerUpdated event, displays the JSON information on-screen
        public void displayOutgoingJSON(Controls_Update controls_Update)
        {
            this.lbl_JSONSent.Text = new JavaScriptSerializer().Serialize(controls_Update);
        }
        //When warningCodeUnsafe event is invoked, performs checks on the value parsed, if of importance to the flight simulation
        //displays the code for the user on-screen, and a small description regarding the codes meaning
        public void displayWarningLevel(string warningLevel)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new WarningCodeDanger(displayWarningLevel), new object[] { warningLevel });
            }
            else
            {
                if (Int16.Parse(warningLevel) == 1)
                    this.lbl_WarningCodeDisplay.Text = warningLevel + " - WARNING: AirCraft too Low!";
                else if (Int16.Parse(warningLevel) == 2)
                    this.lbl_WarningCodeDisplay.Text = warningLevel + " - WARNING: AirCraft Stall risk!";
                else
                    this.lbl_WarningCodeDisplay.Text = "-";
            }
        }

        //All below functions handles interactions between the user and the GUI
        #region Form_Events 
        
        //Upon clicking of the 'Connect' button, the connect function is called, if successful and the function returns true
        //the 'Connect' button is then disabled and a messageBox confirms the connection status
        private void btnClick_Connect(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(cbo_IPAddresses.SelectedItem.ToString());
            if (flightController.connectClient(ip, Int16.Parse(txt_Port.Text)))
            {
                string cl_IPAddress = ((IPEndPoint)flightController.client.Client.RemoteEndPoint).Address.ToString();
                this.lbl_ConnectionDisplayStatus.Text = cl_IPAddress;
                MessageBox.Show("Connected to " + cl_IPAddress);
                this.btn_Connect.Enabled = false;
            }
            else
                this.lbl_ConnectionDisplayStatus.Text = "Waiting for a Connection!";
        }
        //Parses the value of the trackBars, each representing the user-decided throttle and elevation pitch
        private void btnClick_Send(object sender, EventArgs e)
        {
            flightController.sendJSON(this.trk_ThrottleControl.Value, this.trk_PitchControl.Value);
        }
        //updates lable adjacent to the track bars, confirming to the user the value chosen
        private void trkChange_UpdatePitchDisplay(object sender, EventArgs e)
        {
            this.lbl_ElevationDisplay.Text = ((double)this.trk_PitchControl.Value / 20.0).ToString("0.00");
        }
        private void trkChange_UpdateThrottleDisplay(object sender, EventArgs e)
        {
            this.lbl_ThrottleDisplay.Text = this.trk_ThrottleControl.Value.ToString("0.0") + "%";
        }
        //Upon closing of the form, ensures the messageInThread thread is closed correctly
        private void FormClosing_Form1(object sender, FormClosingEventArgs e)
        {
            flightController.messageInThread?.Abort();
        }

        #endregion
    }
}
