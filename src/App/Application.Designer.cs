namespace App
{
    partial class frmApplication
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
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplication));
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.datConnections = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnToLocation = new System.Windows.Forms.Button();
            this.btnFromLocation = new System.Windows.Forms.Button();
            this.btnChangeStations = new System.Windows.Forms.Button();
            this.pnlFromStation = new System.Windows.Forms.Panel();
            this.txtFromStation = new System.Windows.Forms.TextBox();
            this.btnToStationBoard = new System.Windows.Forms.Button();
            this.btnIsArrivalTime = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lstFromStations = new System.Windows.Forms.ListBox();
            this.btnFromStationBoard = new System.Windows.Forms.Button();
            this.lstToStations = new System.Windows.Forms.ListBox();
            this.pnlToStation = new System.Windows.Forms.Panel();
            this.txtToStation = new System.Windows.Forms.TextBox();
            this.toolTipStationBoard = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnToggleDarkMode = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tmrFromStation = new System.Windows.Forms.Timer(this.components);
            this.tmrToStation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datConnections)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlFromStation.SuspendLayout();
            this.pnlToStation.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.BackColor = System.Drawing.Color.Silver;
            this.btnSearchConnections.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearchConnections.FlatAppearance.BorderSize = 0;
            this.btnSearchConnections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSearchConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConnections.Location = new System.Drawing.Point(602, 59);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(185, 26);
            this.btnSearchConnections.TabIndex = 7;
            this.btnSearchConnections.Text = "Verbindungen suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = false;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // datConnections
            // 
            this.datConnections.AllowUserToAddRows = false;
            this.datConnections.AllowUserToDeleteRows = false;
            this.datConnections.AllowUserToOrderColumns = true;
            this.datConnections.AllowUserToResizeColumns = false;
            this.datConnections.AllowUserToResizeRows = false;
            this.datConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datConnections.BackgroundColor = System.Drawing.Color.White;
            this.datConnections.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datConnections.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datConnections.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datConnections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datConnections.DefaultCellStyle = dataGridViewCellStyle5;
            this.datConnections.Location = new System.Drawing.Point(12, 93);
            this.datConnections.Name = "datConnections";
            this.datConnections.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datConnections.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datConnections.RowHeadersVisible = false;
            this.datConnections.Size = new System.Drawing.Size(776, 318);
            this.datConnections.TabIndex = 0;
            this.datConnections.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnToLocation);
            this.pnlMain.Controls.Add(this.btnFromLocation);
            this.pnlMain.Controls.Add(this.btnChangeStations);
            this.pnlMain.Controls.Add(this.pnlFromStation);
            this.pnlMain.Controls.Add(this.datConnections);
            this.pnlMain.Controls.Add(this.btnToStationBoard);
            this.pnlMain.Controls.Add(this.btnIsArrivalTime);
            this.pnlMain.Controls.Add(this.dtpDate);
            this.pnlMain.Controls.Add(this.dtpTime);
            this.pnlMain.Controls.Add(this.lstFromStations);
            this.pnlMain.Controls.Add(this.btnFromStationBoard);
            this.pnlMain.Controls.Add(this.btnSearchConnections);
            this.pnlMain.Controls.Add(this.lstToStations);
            this.pnlMain.Controls.Add(this.pnlToStation);
            this.pnlMain.Location = new System.Drawing.Point(0, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 423);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // btnToLocation
            // 
            this.btnToLocation.BackColor = System.Drawing.Color.Silver;
            this.btnToLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToLocation.BackgroundImage")));
            this.btnToLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToLocation.FlatAppearance.BorderSize = 0;
            this.btnToLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnToLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLocation.Location = new System.Drawing.Point(762, 21);
            this.btnToLocation.Name = "btnToLocation";
            this.btnToLocation.Size = new System.Drawing.Size(26, 26);
            this.btnToLocation.TabIndex = 0;
            this.btnToLocation.TabStop = false;
            this.toolTipStationBoard.SetToolTip(this.btnToLocation, "Standort anzeigen");
            this.btnToLocation.UseVisualStyleBackColor = false;
            this.btnToLocation.Click += new System.EventHandler(this.btnToLocation_Click);
            // 
            // btnFromLocation
            // 
            this.btnFromLocation.BackColor = System.Drawing.Color.Silver;
            this.btnFromLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFromLocation.BackgroundImage")));
            this.btnFromLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFromLocation.FlatAppearance.BorderSize = 0;
            this.btnFromLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFromLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromLocation.Location = new System.Drawing.Point(334, 21);
            this.btnFromLocation.Name = "btnFromLocation";
            this.btnFromLocation.Size = new System.Drawing.Size(26, 26);
            this.btnFromLocation.TabIndex = 0;
            this.btnFromLocation.TabStop = false;
            this.toolTipStationBoard.SetToolTip(this.btnFromLocation, "Standort anzeigen");
            this.btnFromLocation.UseVisualStyleBackColor = false;
            this.btnFromLocation.Click += new System.EventHandler(this.btnFromLocation_Click);
            // 
            // btnChangeStations
            // 
            this.btnChangeStations.BackColor = System.Drawing.Color.Silver;
            this.btnChangeStations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeStations.BackgroundImage")));
            this.btnChangeStations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangeStations.FlatAppearance.BorderSize = 0;
            this.btnChangeStations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStations.Location = new System.Drawing.Point(387, 21);
            this.btnChangeStations.Name = "btnChangeStations";
            this.btnChangeStations.Size = new System.Drawing.Size(26, 26);
            this.btnChangeStations.TabIndex = 15;
            this.btnChangeStations.UseVisualStyleBackColor = false;
            this.btnChangeStations.Click += new System.EventHandler(this.btnChangeStations_Click);
            // 
            // pnlFromStation
            // 
            this.pnlFromStation.BackColor = System.Drawing.Color.Silver;
            this.pnlFromStation.Controls.Add(this.txtFromStation);
            this.pnlFromStation.Location = new System.Drawing.Point(12, 21);
            this.pnlFromStation.Name = "pnlFromStation";
            this.pnlFromStation.Size = new System.Drawing.Size(296, 26);
            this.pnlFromStation.TabIndex = 0;
            this.pnlFromStation.TabStop = true;
            // 
            // txtFromStation
            // 
            this.txtFromStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFromStation.BackColor = System.Drawing.Color.Silver;
            this.txtFromStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromStation.Location = new System.Drawing.Point(3, 4);
            this.txtFromStation.Name = "txtFromStation";
            this.txtFromStation.Size = new System.Drawing.Size(290, 19);
            this.txtFromStation.TabIndex = 0;
            this.txtFromStation.Text = "Von";
            this.txtFromStation.Click += new System.EventHandler(this.txtFromStation_Enter);
            this.txtFromStation.TextChanged += new System.EventHandler(this.txtFromStation_TextChanged);
            this.txtFromStation.Enter += new System.EventHandler(this.txtFromStation_Enter);
            this.txtFromStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFrom_KeyDown);
            this.txtFromStation.Leave += new System.EventHandler(this.txtFromStation_Leave);
            // 
            // btnToStationBoard
            // 
            this.btnToStationBoard.BackColor = System.Drawing.Color.Silver;
            this.btnToStationBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToStationBoard.BackgroundImage")));
            this.btnToStationBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToStationBoard.FlatAppearance.BorderSize = 0;
            this.btnToStationBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnToStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToStationBoard.Location = new System.Drawing.Point(736, 21);
            this.btnToStationBoard.Name = "btnToStationBoard";
            this.btnToStationBoard.Size = new System.Drawing.Size(26, 26);
            this.btnToStationBoard.TabIndex = 0;
            this.btnToStationBoard.TabStop = false;
            this.toolTipStationBoard.SetToolTip(this.btnToStationBoard, "Abfahrstafel abrufen");
            this.btnToStationBoard.UseVisualStyleBackColor = false;
            this.btnToStationBoard.Click += new System.EventHandler(this.btnToStationBoard_Click);
            // 
            // btnIsArrivalTime
            // 
            this.btnIsArrivalTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnIsArrivalTime.BackColor = System.Drawing.Color.Silver;
            this.btnIsArrivalTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIsArrivalTime.FlatAppearance.BorderSize = 0;
            this.btnIsArrivalTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnIsArrivalTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsArrivalTime.Location = new System.Drawing.Point(12, 59);
            this.btnIsArrivalTime.Name = "btnIsArrivalTime";
            this.btnIsArrivalTime.Size = new System.Drawing.Size(138, 26);
            this.btnIsArrivalTime.TabIndex = 4;
            this.btnIsArrivalTime.TabStop = false;
            this.btnIsArrivalTime.Text = "Abfahrtszeit";
            this.btnIsArrivalTime.UseVisualStyleBackColor = false;
            this.btnIsArrivalTime.Click += new System.EventHandler(this.btnIsArrivalTime_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.dtpDate.CustomFormat = "ddd, dd.MM.yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(226, 59);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(158, 26);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.Value = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpTime.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(156, 59);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(64, 26);
            this.dtpTime.TabIndex = 5;
            this.dtpTime.Value = new System.DateTime(2018, 12, 3, 0, 0, 0, 0);
            // 
            // lstFromStations
            // 
            this.lstFromStations.BackColor = System.Drawing.Color.Silver;
            this.lstFromStations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFromStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFromStations.FormattingEnabled = true;
            this.lstFromStations.ItemHeight = 20;
            this.lstFromStations.Location = new System.Drawing.Point(12, 47);
            this.lstFromStations.Name = "lstFromStations";
            this.lstFromStations.Size = new System.Drawing.Size(296, 80);
            this.lstFromStations.TabIndex = 0;
            this.lstFromStations.TabStop = false;
            this.lstFromStations.UseTabStops = false;
            this.lstFromStations.Visible = false;
            this.lstFromStations.Click += new System.EventHandler(this.lstFromStations_Click);
            this.lstFromStations.SelectedIndexChanged += new System.EventHandler(this.lstFromStations_SelectedIndexChanged);
            this.lstFromStations.Leave += new System.EventHandler(this.lstFromStations_Leave);
            // 
            // btnFromStationBoard
            // 
            this.btnFromStationBoard.BackColor = System.Drawing.Color.Silver;
            this.btnFromStationBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFromStationBoard.BackgroundImage")));
            this.btnFromStationBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFromStationBoard.FlatAppearance.BorderSize = 0;
            this.btnFromStationBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnFromStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromStationBoard.Location = new System.Drawing.Point(308, 21);
            this.btnFromStationBoard.Name = "btnFromStationBoard";
            this.btnFromStationBoard.Size = new System.Drawing.Size(26, 26);
            this.btnFromStationBoard.TabIndex = 0;
            this.btnFromStationBoard.TabStop = false;
            this.toolTipStationBoard.SetToolTip(this.btnFromStationBoard, "Abfahrstafel abrufen");
            this.btnFromStationBoard.UseVisualStyleBackColor = false;
            this.btnFromStationBoard.Click += new System.EventHandler(this.btnFromStationBoard_Click);
            // 
            // lstToStations
            // 
            this.lstToStations.BackColor = System.Drawing.Color.Silver;
            this.lstToStations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstToStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstToStations.FormattingEnabled = true;
            this.lstToStations.ItemHeight = 20;
            this.lstToStations.Location = new System.Drawing.Point(440, 47);
            this.lstToStations.Name = "lstToStations";
            this.lstToStations.Size = new System.Drawing.Size(296, 80);
            this.lstToStations.TabIndex = 14;
            this.lstToStations.TabStop = false;
            this.lstToStations.Visible = false;
            this.lstToStations.Click += new System.EventHandler(this.lstToStations_Click);
            // 
            // pnlToStation
            // 
            this.pnlToStation.BackColor = System.Drawing.Color.Silver;
            this.pnlToStation.Controls.Add(this.txtToStation);
            this.pnlToStation.Location = new System.Drawing.Point(440, 21);
            this.pnlToStation.Name = "pnlToStation";
            this.pnlToStation.Size = new System.Drawing.Size(296, 26);
            this.pnlToStation.TabIndex = 0;
            this.pnlToStation.TabStop = true;
            // 
            // txtToStation
            // 
            this.txtToStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtToStation.BackColor = System.Drawing.Color.Silver;
            this.txtToStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToStation.Location = new System.Drawing.Point(3, 4);
            this.txtToStation.Name = "txtToStation";
            this.txtToStation.Size = new System.Drawing.Size(290, 19);
            this.txtToStation.TabIndex = 2;
            this.txtToStation.Text = "Nach";
            this.txtToStation.Click += new System.EventHandler(this.txtToStation_Enter);
            this.txtToStation.TextChanged += new System.EventHandler(this.txtToStation_TextChanged);
            this.txtToStation.Enter += new System.EventHandler(this.txtToStation_Enter);
            this.txtToStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToStation_KeyDown);
            this.txtToStation.Leave += new System.EventHandler(this.txtToStation_Leave);
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlHead.Controls.Add(this.btnToggleDarkMode);
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Controls.Add(this.lblTitle);
            this.pnlHead.Controls.Add(this.btnMinimize);
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(800, 30);
            this.pnlHead.TabIndex = 15;
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // btnToggleDarkMode
            // 
            this.btnToggleDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleDarkMode.BackgroundImage = global::App.Properties.Resources.sun_small;
            this.btnToggleDarkMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnToggleDarkMode.FlatAppearance.BorderSize = 0;
            this.btnToggleDarkMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnToggleDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleDarkMode.Location = new System.Drawing.Point(706, 0);
            this.btnToggleDarkMode.Name = "btnToggleDarkMode";
            this.btnToggleDarkMode.Size = new System.Drawing.Size(30, 30);
            this.btnToggleDarkMode.TabIndex = 14;
            this.btnToggleDarkMode.TabStop = false;
            this.btnToggleDarkMode.UseVisualStyleBackColor = false;
            this.btnToggleDarkMode.Click += new System.EventHandler(this.btnToggleDarkMode_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(770, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "title";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(741, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // tmrFromStation
            // 
            this.tmrFromStation.Interval = 300;
            this.tmrFromStation.Tick += new System.EventHandler(this.tmrFromStation_Tick);
            // 
            // tmrToStation
            // 
            this.tmrToStation.Interval = 300;
            this.tmrToStation.Tick += new System.EventHandler(this.tmrToStation_Tick);
            // 
            // frmApplication
            // 
            this.AcceptButton = this.btnSearchConnections;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖV-App";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.datConnections)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlFromStation.ResumeLayout(false);
            this.pnlFromStation.PerformLayout();
            this.pnlToStation.ResumeLayout(false);
            this.pnlToStation.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.DataGridView datConnections;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnFromStationBoard;
        private System.Windows.Forms.TextBox txtFromStation;
        private System.Windows.Forms.ListBox lstFromStations;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ToolTip toolTipStationBoard;
        private System.Windows.Forms.Button btnIsArrivalTime;
        private System.Windows.Forms.Button btnToStationBoard;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFromStation;
        private System.Windows.Forms.Panel pnlToStation;
        private System.Windows.Forms.TextBox txtToStation;
        private System.Windows.Forms.ListBox lstToStations;
        private System.Windows.Forms.Timer tmrFromStation;
        private System.Windows.Forms.Timer tmrToStation;
        private System.Windows.Forms.Button btnChangeStations;
        private System.Windows.Forms.Button btnFromLocation;
        private System.Windows.Forms.Button btnToLocation;
        private System.Windows.Forms.Button btnToggleDarkMode;
    }
}

