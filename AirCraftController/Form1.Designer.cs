
namespace AirCraftController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBox_Connection = new System.Windows.Forms.GroupBox();
            this.cbo_IPAddresses = new System.Windows.Forms.ComboBox();
            this.lbl_ConnectionDisplayStatus = new System.Windows.Forms.Label();
            this.lbl_ConnectionStatus = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_IPAdress = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.grpBox_Console = new System.Windows.Forms.GroupBox();
            this.lbl_ElevationDisplay = new System.Windows.Forms.Label();
            this.lbl_ThrottleDisplay = new System.Windows.Forms.Label();
            this.lbl_ElevatorPitch = new System.Windows.Forms.Label();
            this.lbl_Throttle = new System.Windows.Forms.Label();
            this.btn_AutoTakeoff = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.trk_PitchControl = new System.Windows.Forms.TrackBar();
            this.trk_ThrottleControl = new System.Windows.Forms.TrackBar();
            this.tab_TelemetryDisplay = new System.Windows.Forms.DataGridView();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerticalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Throttle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElevatorPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarningCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_DataRecieved = new System.Windows.Forms.GroupBox();
            this.lbl_DATA_ElevationDisplay = new System.Windows.Forms.Label();
            this.lbl_DATA_ThrottleDisplay = new System.Windows.Forms.Label();
            this.lbl_DATA_VSpeedDisplay = new System.Windows.Forms.Label();
            this.lbl_DATA_PitchDisplay = new System.Windows.Forms.Label();
            this.lbl_DATA_SpeedDisplay = new System.Windows.Forms.Label();
            this.lbl_DATA_AltitudeDisplay = new System.Windows.Forms.Label();
            this.lbl_DATA_Elevator = new System.Windows.Forms.Label();
            this.lbl_DATA_Throttle = new System.Windows.Forms.Label();
            this.lbl_DATA_VSpeed = new System.Windows.Forms.Label();
            this.lbl_DATA_Pitch = new System.Windows.Forms.Label();
            this.lbl_DATA_Speed = new System.Windows.Forms.Label();
            this.lbl_DATA_Altitude = new System.Windows.Forms.Label();
            this.grp_JSONSent = new System.Windows.Forms.GroupBox();
            this.lbl_JSONSent = new System.Windows.Forms.Label();
            this.grp_JSONRecieved = new System.Windows.Forms.GroupBox();
            this.lbl_JSONRecieved = new System.Windows.Forms.Label();
            this.grp_WarningBox = new System.Windows.Forms.GroupBox();
            this.lbl_WarningCodeDisplay = new System.Windows.Forms.Label();
            this.grpBox_Connection.SuspendLayout();
            this.grpBox_Console.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_PitchControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ThrottleControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_TelemetryDisplay)).BeginInit();
            this.grp_DataRecieved.SuspendLayout();
            this.grp_JSONSent.SuspendLayout();
            this.grp_JSONRecieved.SuspendLayout();
            this.grp_WarningBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Connection
            // 
            this.grpBox_Connection.Controls.Add(this.cbo_IPAddresses);
            this.grpBox_Connection.Controls.Add(this.lbl_ConnectionDisplayStatus);
            this.grpBox_Connection.Controls.Add(this.lbl_ConnectionStatus);
            this.grpBox_Connection.Controls.Add(this.btn_Connect);
            this.grpBox_Connection.Controls.Add(this.lbl_Port);
            this.grpBox_Connection.Controls.Add(this.lbl_IPAdress);
            this.grpBox_Connection.Controls.Add(this.txt_Port);
            this.grpBox_Connection.Location = new System.Drawing.Point(9, 10);
            this.grpBox_Connection.Name = "grpBox_Connection";
            this.grpBox_Connection.Size = new System.Drawing.Size(425, 82);
            this.grpBox_Connection.TabIndex = 0;
            this.grpBox_Connection.TabStop = false;
            this.grpBox_Connection.Text = "Connection Details";
            // 
            // cbo_IPAddresses
            // 
            this.cbo_IPAddresses.FormattingEnabled = true;
            this.cbo_IPAddresses.Location = new System.Drawing.Point(85, 27);
            this.cbo_IPAddresses.Name = "cbo_IPAddresses";
            this.cbo_IPAddresses.Size = new System.Drawing.Size(111, 21);
            this.cbo_IPAddresses.TabIndex = 8;
            // 
            // lbl_ConnectionDisplayStatus
            // 
            this.lbl_ConnectionDisplayStatus.AutoSize = true;
            this.lbl_ConnectionDisplayStatus.Location = new System.Drawing.Point(119, 58);
            this.lbl_ConnectionDisplayStatus.Name = "lbl_ConnectionDisplayStatus";
            this.lbl_ConnectionDisplayStatus.Size = new System.Drawing.Size(73, 13);
            this.lbl_ConnectionDisplayStatus.TabIndex = 7;
            this.lbl_ConnectionDisplayStatus.Text = "Disconnected";
            // 
            // lbl_ConnectionStatus
            // 
            this.lbl_ConnectionStatus.AutoSize = true;
            this.lbl_ConnectionStatus.Location = new System.Drawing.Point(15, 58);
            this.lbl_ConnectionStatus.Name = "lbl_ConnectionStatus";
            this.lbl_ConnectionStatus.Size = new System.Drawing.Size(97, 13);
            this.lbl_ConnectionStatus.TabIndex = 6;
            this.lbl_ConnectionStatus.Text = "Connection Status:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(283, 53);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(88, 23);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btnClick_Connect);
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(236, 31);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(29, 13);
            this.lbl_Port.TabIndex = 4;
            this.lbl_Port.Text = "Port:";
            // 
            // lbl_IPAdress
            // 
            this.lbl_IPAdress.AutoSize = true;
            this.lbl_IPAdress.Location = new System.Drawing.Point(15, 30);
            this.lbl_IPAdress.Name = "lbl_IPAdress";
            this.lbl_IPAdress.Size = new System.Drawing.Size(64, 13);
            this.lbl_IPAdress.TabIndex = 3;
            this.lbl_IPAdress.Text = "IP Address: ";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(271, 27);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(111, 20);
            this.txt_Port.TabIndex = 2;
            // 
            // grpBox_Console
            // 
            this.grpBox_Console.Controls.Add(this.lbl_ElevationDisplay);
            this.grpBox_Console.Controls.Add(this.lbl_ThrottleDisplay);
            this.grpBox_Console.Controls.Add(this.lbl_ElevatorPitch);
            this.grpBox_Console.Controls.Add(this.lbl_Throttle);
            this.grpBox_Console.Controls.Add(this.btn_AutoTakeoff);
            this.grpBox_Console.Controls.Add(this.btn_Send);
            this.grpBox_Console.Controls.Add(this.trk_PitchControl);
            this.grpBox_Console.Controls.Add(this.trk_ThrottleControl);
            this.grpBox_Console.Location = new System.Drawing.Point(10, 237);
            this.grpBox_Console.Name = "grpBox_Console";
            this.grpBox_Console.Size = new System.Drawing.Size(423, 252);
            this.grpBox_Console.TabIndex = 1;
            this.grpBox_Console.TabStop = false;
            this.grpBox_Console.Text = "Console";
            // 
            // lbl_ElevationDisplay
            // 
            this.lbl_ElevationDisplay.AutoSize = true;
            this.lbl_ElevationDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ElevationDisplay.Location = new System.Drawing.Point(321, 109);
            this.lbl_ElevationDisplay.Name = "lbl_ElevationDisplay";
            this.lbl_ElevationDisplay.Size = new System.Drawing.Size(19, 20);
            this.lbl_ElevationDisplay.TabIndex = 12;
            this.lbl_ElevationDisplay.Text = "0";
            // 
            // lbl_ThrottleDisplay
            // 
            this.lbl_ThrottleDisplay.AutoSize = true;
            this.lbl_ThrottleDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThrottleDisplay.Location = new System.Drawing.Point(135, 109);
            this.lbl_ThrottleDisplay.Name = "lbl_ThrottleDisplay";
            this.lbl_ThrottleDisplay.Size = new System.Drawing.Size(19, 20);
            this.lbl_ThrottleDisplay.TabIndex = 11;
            this.lbl_ThrottleDisplay.Text = "0";
            // 
            // lbl_ElevatorPitch
            // 
            this.lbl_ElevatorPitch.AutoSize = true;
            this.lbl_ElevatorPitch.Location = new System.Drawing.Point(251, 16);
            this.lbl_ElevatorPitch.Name = "lbl_ElevatorPitch";
            this.lbl_ElevatorPitch.Size = new System.Drawing.Size(73, 13);
            this.lbl_ElevatorPitch.TabIndex = 10;
            this.lbl_ElevatorPitch.Text = "Elevator Pitch";
            // 
            // lbl_Throttle
            // 
            this.lbl_Throttle.AutoSize = true;
            this.lbl_Throttle.Location = new System.Drawing.Point(81, 18);
            this.lbl_Throttle.Name = "lbl_Throttle";
            this.lbl_Throttle.Size = new System.Drawing.Size(43, 13);
            this.lbl_Throttle.TabIndex = 8;
            this.lbl_Throttle.Text = "Throttle";
            // 
            // btn_AutoTakeoff
            // 
            this.btn_AutoTakeoff.Location = new System.Drawing.Point(238, 216);
            this.btn_AutoTakeoff.Name = "btn_AutoTakeoff";
            this.btn_AutoTakeoff.Size = new System.Drawing.Size(88, 23);
            this.btn_AutoTakeoff.TabIndex = 9;
            this.btn_AutoTakeoff.Text = "Auto-TakeOff";
            this.btn_AutoTakeoff.UseVisualStyleBackColor = true;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(53, 216);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(88, 23);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btnClick_Send);
            // 
            // trk_PitchControl
            // 
            this.trk_PitchControl.Location = new System.Drawing.Point(270, 34);
            this.trk_PitchControl.Maximum = 100;
            this.trk_PitchControl.Minimum = -100;
            this.trk_PitchControl.Name = "trk_PitchControl";
            this.trk_PitchControl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trk_PitchControl.Size = new System.Drawing.Size(45, 176);
            this.trk_PitchControl.TabIndex = 1;
            this.trk_PitchControl.TickFrequency = 5;
            this.trk_PitchControl.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trk_PitchControl.ValueChanged += new System.EventHandler(this.trkChange_UpdatePitchDisplay);
            // 
            // trk_ThrottleControl
            // 
            this.trk_ThrottleControl.Location = new System.Drawing.Point(84, 34);
            this.trk_ThrottleControl.Maximum = 100;
            this.trk_ThrottleControl.Name = "trk_ThrottleControl";
            this.trk_ThrottleControl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trk_ThrottleControl.Size = new System.Drawing.Size(45, 176);
            this.trk_ThrottleControl.TabIndex = 0;
            this.trk_ThrottleControl.TickFrequency = 10;
            this.trk_ThrottleControl.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trk_ThrottleControl.ValueChanged += new System.EventHandler(this.trkChange_UpdateThrottleDisplay);
            // 
            // tab_TelemetryDisplay
            // 
            this.tab_TelemetryDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_TelemetryDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Altitude,
            this.Speed,
            this.Pitch,
            this.VerticalSpeed,
            this.Throttle,
            this.ElevatorPitch,
            this.WarningCode});
            this.tab_TelemetryDisplay.Location = new System.Drawing.Point(450, 189);
            this.tab_TelemetryDisplay.Name = "tab_TelemetryDisplay";
            this.tab_TelemetryDisplay.Size = new System.Drawing.Size(734, 297);
            this.tab_TelemetryDisplay.TabIndex = 13;
            // 
            // Altitude
            // 
            this.Altitude.HeaderText = "Altitude";
            this.Altitude.Name = "Altitude";
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            // 
            // Pitch
            // 
            this.Pitch.HeaderText = "Pitch";
            this.Pitch.Name = "Pitch";
            // 
            // VerticalSpeed
            // 
            this.VerticalSpeed.HeaderText = "VerticalSpeed";
            this.VerticalSpeed.Name = "VerticalSpeed";
            // 
            // Throttle
            // 
            this.Throttle.HeaderText = "Throttle";
            this.Throttle.Name = "Throttle";
            // 
            // ElevatorPitch
            // 
            this.ElevatorPitch.HeaderText = "Elevator Pitch";
            this.ElevatorPitch.Name = "ElevatorPitch";
            // 
            // WarningCode
            // 
            this.WarningCode.HeaderText = "Warning Code";
            this.WarningCode.Name = "WarningCode";
            // 
            // grp_DataRecieved
            // 
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_ElevationDisplay);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_ThrottleDisplay);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_VSpeedDisplay);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_PitchDisplay);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_SpeedDisplay);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_AltitudeDisplay);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_Elevator);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_Throttle);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_VSpeed);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_Pitch);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_Speed);
            this.grp_DataRecieved.Controls.Add(this.lbl_DATA_Altitude);
            this.grp_DataRecieved.Location = new System.Drawing.Point(10, 98);
            this.grp_DataRecieved.Name = "grp_DataRecieved";
            this.grp_DataRecieved.Size = new System.Drawing.Size(424, 137);
            this.grp_DataRecieved.TabIndex = 14;
            this.grp_DataRecieved.TabStop = false;
            this.grp_DataRecieved.Text = "Data Recieved";
            // 
            // lbl_DATA_ElevationDisplay
            // 
            this.lbl_DATA_ElevationDisplay.AutoSize = true;
            this.lbl_DATA_ElevationDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DATA_ElevationDisplay.Location = new System.Drawing.Point(324, 105);
            this.lbl_DATA_ElevationDisplay.Name = "lbl_DATA_ElevationDisplay";
            this.lbl_DATA_ElevationDisplay.Size = new System.Drawing.Size(15, 15);
            this.lbl_DATA_ElevationDisplay.TabIndex = 18;
            this.lbl_DATA_ElevationDisplay.Text = "0";
            // 
            // lbl_DATA_ThrottleDisplay
            // 
            this.lbl_DATA_ThrottleDisplay.AutoSize = true;
            this.lbl_DATA_ThrottleDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DATA_ThrottleDisplay.Location = new System.Drawing.Point(324, 66);
            this.lbl_DATA_ThrottleDisplay.Name = "lbl_DATA_ThrottleDisplay";
            this.lbl_DATA_ThrottleDisplay.Size = new System.Drawing.Size(15, 15);
            this.lbl_DATA_ThrottleDisplay.TabIndex = 17;
            this.lbl_DATA_ThrottleDisplay.Text = "0";
            // 
            // lbl_DATA_VSpeedDisplay
            // 
            this.lbl_DATA_VSpeedDisplay.AutoSize = true;
            this.lbl_DATA_VSpeedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DATA_VSpeedDisplay.Location = new System.Drawing.Point(324, 30);
            this.lbl_DATA_VSpeedDisplay.Name = "lbl_DATA_VSpeedDisplay";
            this.lbl_DATA_VSpeedDisplay.Size = new System.Drawing.Size(15, 15);
            this.lbl_DATA_VSpeedDisplay.TabIndex = 16;
            this.lbl_DATA_VSpeedDisplay.Text = "0";
            // 
            // lbl_DATA_PitchDisplay
            // 
            this.lbl_DATA_PitchDisplay.AutoSize = true;
            this.lbl_DATA_PitchDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DATA_PitchDisplay.Location = new System.Drawing.Point(67, 107);
            this.lbl_DATA_PitchDisplay.Name = "lbl_DATA_PitchDisplay";
            this.lbl_DATA_PitchDisplay.Size = new System.Drawing.Size(15, 15);
            this.lbl_DATA_PitchDisplay.TabIndex = 15;
            this.lbl_DATA_PitchDisplay.Text = "0";
            // 
            // lbl_DATA_SpeedDisplay
            // 
            this.lbl_DATA_SpeedDisplay.AutoSize = true;
            this.lbl_DATA_SpeedDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DATA_SpeedDisplay.Location = new System.Drawing.Point(67, 68);
            this.lbl_DATA_SpeedDisplay.Name = "lbl_DATA_SpeedDisplay";
            this.lbl_DATA_SpeedDisplay.Size = new System.Drawing.Size(15, 15);
            this.lbl_DATA_SpeedDisplay.TabIndex = 14;
            this.lbl_DATA_SpeedDisplay.Text = "0";
            // 
            // lbl_DATA_AltitudeDisplay
            // 
            this.lbl_DATA_AltitudeDisplay.AutoSize = true;
            this.lbl_DATA_AltitudeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DATA_AltitudeDisplay.Location = new System.Drawing.Point(67, 30);
            this.lbl_DATA_AltitudeDisplay.Name = "lbl_DATA_AltitudeDisplay";
            this.lbl_DATA_AltitudeDisplay.Size = new System.Drawing.Size(15, 15);
            this.lbl_DATA_AltitudeDisplay.TabIndex = 13;
            this.lbl_DATA_AltitudeDisplay.Text = "0";
            // 
            // lbl_DATA_Elevator
            // 
            this.lbl_DATA_Elevator.AutoSize = true;
            this.lbl_DATA_Elevator.Location = new System.Drawing.Point(228, 107);
            this.lbl_DATA_Elevator.Name = "lbl_DATA_Elevator";
            this.lbl_DATA_Elevator.Size = new System.Drawing.Size(76, 13);
            this.lbl_DATA_Elevator.TabIndex = 13;
            this.lbl_DATA_Elevator.Text = "Elevator Pitch:";
            // 
            // lbl_DATA_Throttle
            // 
            this.lbl_DATA_Throttle.AutoSize = true;
            this.lbl_DATA_Throttle.Location = new System.Drawing.Point(228, 68);
            this.lbl_DATA_Throttle.Name = "lbl_DATA_Throttle";
            this.lbl_DATA_Throttle.Size = new System.Drawing.Size(46, 13);
            this.lbl_DATA_Throttle.TabIndex = 12;
            this.lbl_DATA_Throttle.Text = "Throttle:";
            // 
            // lbl_DATA_VSpeed
            // 
            this.lbl_DATA_VSpeed.AutoSize = true;
            this.lbl_DATA_VSpeed.Location = new System.Drawing.Point(228, 30);
            this.lbl_DATA_VSpeed.Name = "lbl_DATA_VSpeed";
            this.lbl_DATA_VSpeed.Size = new System.Drawing.Size(79, 13);
            this.lbl_DATA_VSpeed.TabIndex = 11;
            this.lbl_DATA_VSpeed.Text = "Vertical Speed:";
            // 
            // lbl_DATA_Pitch
            // 
            this.lbl_DATA_Pitch.AutoSize = true;
            this.lbl_DATA_Pitch.Location = new System.Drawing.Point(16, 107);
            this.lbl_DATA_Pitch.Name = "lbl_DATA_Pitch";
            this.lbl_DATA_Pitch.Size = new System.Drawing.Size(34, 13);
            this.lbl_DATA_Pitch.TabIndex = 10;
            this.lbl_DATA_Pitch.Text = "Pitch:";
            // 
            // lbl_DATA_Speed
            // 
            this.lbl_DATA_Speed.AutoSize = true;
            this.lbl_DATA_Speed.Location = new System.Drawing.Point(16, 68);
            this.lbl_DATA_Speed.Name = "lbl_DATA_Speed";
            this.lbl_DATA_Speed.Size = new System.Drawing.Size(41, 13);
            this.lbl_DATA_Speed.TabIndex = 9;
            this.lbl_DATA_Speed.Text = "Speed:";
            // 
            // lbl_DATA_Altitude
            // 
            this.lbl_DATA_Altitude.AutoSize = true;
            this.lbl_DATA_Altitude.Location = new System.Drawing.Point(16, 30);
            this.lbl_DATA_Altitude.Name = "lbl_DATA_Altitude";
            this.lbl_DATA_Altitude.Size = new System.Drawing.Size(45, 13);
            this.lbl_DATA_Altitude.TabIndex = 8;
            this.lbl_DATA_Altitude.Text = "Altitude:";
            // 
            // grp_JSONSent
            // 
            this.grp_JSONSent.Controls.Add(this.lbl_JSONSent);
            this.grp_JSONSent.Location = new System.Drawing.Point(450, 17);
            this.grp_JSONSent.Name = "grp_JSONSent";
            this.grp_JSONSent.Size = new System.Drawing.Size(734, 41);
            this.grp_JSONSent.TabIndex = 15;
            this.grp_JSONSent.TabStop = false;
            this.grp_JSONSent.Text = "JSON Sent";
            // 
            // lbl_JSONSent
            // 
            this.lbl_JSONSent.AutoSize = true;
            this.lbl_JSONSent.Location = new System.Drawing.Point(3, 25);
            this.lbl_JSONSent.Name = "lbl_JSONSent";
            this.lbl_JSONSent.Size = new System.Drawing.Size(10, 13);
            this.lbl_JSONSent.TabIndex = 1;
            this.lbl_JSONSent.Text = "-";
            // 
            // grp_JSONRecieved
            // 
            this.grp_JSONRecieved.Controls.Add(this.lbl_JSONRecieved);
            this.grp_JSONRecieved.Location = new System.Drawing.Point(450, 68);
            this.grp_JSONRecieved.Name = "grp_JSONRecieved";
            this.grp_JSONRecieved.Size = new System.Drawing.Size(734, 41);
            this.grp_JSONRecieved.TabIndex = 16;
            this.grp_JSONRecieved.TabStop = false;
            this.grp_JSONRecieved.Text = "JSON Recieved";
            // 
            // lbl_JSONRecieved
            // 
            this.lbl_JSONRecieved.AutoSize = true;
            this.lbl_JSONRecieved.Location = new System.Drawing.Point(3, 25);
            this.lbl_JSONRecieved.Name = "lbl_JSONRecieved";
            this.lbl_JSONRecieved.Size = new System.Drawing.Size(10, 13);
            this.lbl_JSONRecieved.TabIndex = 0;
            this.lbl_JSONRecieved.Text = "-";
            // 
            // grp_WarningBox
            // 
            this.grp_WarningBox.Controls.Add(this.lbl_WarningCodeDisplay);
            this.grp_WarningBox.Location = new System.Drawing.Point(450, 128);
            this.grp_WarningBox.Name = "grp_WarningBox";
            this.grp_WarningBox.Size = new System.Drawing.Size(432, 44);
            this.grp_WarningBox.TabIndex = 17;
            this.grp_WarningBox.TabStop = false;
            this.grp_WarningBox.Text = "Warning Code";
            // 
            // lbl_WarningCodeDisplay
            // 
            this.lbl_WarningCodeDisplay.AutoSize = true;
            this.lbl_WarningCodeDisplay.Location = new System.Drawing.Point(3, 28);
            this.lbl_WarningCodeDisplay.Name = "lbl_WarningCodeDisplay";
            this.lbl_WarningCodeDisplay.Size = new System.Drawing.Size(10, 13);
            this.lbl_WarningCodeDisplay.TabIndex = 0;
            this.lbl_WarningCodeDisplay.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 498);
            this.Controls.Add(this.grp_WarningBox);
            this.Controls.Add(this.grp_JSONRecieved);
            this.Controls.Add(this.grp_JSONSent);
            this.Controls.Add(this.grp_DataRecieved);
            this.Controls.Add(this.tab_TelemetryDisplay);
            this.Controls.Add(this.grpBox_Console);
            this.Controls.Add(this.grpBox_Connection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing_Form1);
            this.grpBox_Connection.ResumeLayout(false);
            this.grpBox_Connection.PerformLayout();
            this.grpBox_Console.ResumeLayout(false);
            this.grpBox_Console.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_PitchControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_ThrottleControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_TelemetryDisplay)).EndInit();
            this.grp_DataRecieved.ResumeLayout(false);
            this.grp_DataRecieved.PerformLayout();
            this.grp_JSONSent.ResumeLayout(false);
            this.grp_JSONSent.PerformLayout();
            this.grp_JSONRecieved.ResumeLayout(false);
            this.grp_JSONRecieved.PerformLayout();
            this.grp_WarningBox.ResumeLayout(false);
            this.grp_WarningBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Connection;
        private System.Windows.Forms.Label lbl_ConnectionDisplayStatus;
        private System.Windows.Forms.Label lbl_ConnectionStatus;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_IPAdress;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.GroupBox grpBox_Console;
        private System.Windows.Forms.Label lbl_ThrottleDisplay;
        private System.Windows.Forms.Label lbl_ElevatorPitch;
        private System.Windows.Forms.Label lbl_Throttle;
        private System.Windows.Forms.Button btn_AutoTakeoff;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TrackBar trk_PitchControl;
        private System.Windows.Forms.TrackBar trk_ThrottleControl;
        private System.Windows.Forms.Label lbl_ElevationDisplay;
        private System.Windows.Forms.DataGridView tab_TelemetryDisplay;
        private System.Windows.Forms.ComboBox cbo_IPAddresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerticalSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Throttle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElevatorPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarningCode;
        private System.Windows.Forms.GroupBox grp_DataRecieved;
        private System.Windows.Forms.Label lbl_DATA_ElevationDisplay;
        private System.Windows.Forms.Label lbl_DATA_ThrottleDisplay;
        private System.Windows.Forms.Label lbl_DATA_VSpeedDisplay;
        private System.Windows.Forms.Label lbl_DATA_PitchDisplay;
        private System.Windows.Forms.Label lbl_DATA_SpeedDisplay;
        private System.Windows.Forms.Label lbl_DATA_AltitudeDisplay;
        private System.Windows.Forms.Label lbl_DATA_Elevator;
        private System.Windows.Forms.Label lbl_DATA_Throttle;
        private System.Windows.Forms.Label lbl_DATA_VSpeed;
        private System.Windows.Forms.Label lbl_DATA_Pitch;
        private System.Windows.Forms.Label lbl_DATA_Speed;
        private System.Windows.Forms.Label lbl_DATA_Altitude;
        private System.Windows.Forms.GroupBox grp_JSONSent;
        private System.Windows.Forms.Label lbl_JSONSent;
        private System.Windows.Forms.GroupBox grp_JSONRecieved;
        private System.Windows.Forms.Label lbl_JSONRecieved;
        private System.Windows.Forms.GroupBox grp_WarningBox;
        private System.Windows.Forms.Label lbl_WarningCodeDisplay;
    }
}

