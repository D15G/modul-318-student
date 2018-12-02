namespace App
{
    partial class Application
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.datConnections = new System.Windows.Forms.DataGridView();
            this.connectionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.btnFromStationBoard = new System.Windows.Forms.Button();
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTipStationBoard = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFrom
            // 
            this.cboFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboFrom.DataSource = this.stationBindingSource;
            this.cboFrom.DisplayMember = "Name";
            this.cboFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.ItemHeight = 13;
            this.cboFrom.Location = new System.Drawing.Point(12, 31);
            this.cboFrom.MaxDropDownItems = 10;
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(158, 21);
            this.cboFrom.TabIndex = 0;
            this.cboFrom.ValueMember = "Id";
            this.cboFrom.Click += new System.EventHandler(this.cboFrom_Click);
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(SwissTransport.Station);
            // 
            // cboTo
            // 
            this.cboTo.DataSource = this.stationBindingSource;
            this.cboTo.DisplayMember = "Name";
            this.cboTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(273, 31);
            this.cboTo.MaxDropDownItems = 10;
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(158, 21);
            this.cboTo.TabIndex = 1;
            this.cboTo.ValueMember = "Id";
            this.cboTo.Click += new System.EventHandler(this.cboTo_Click);
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(446, 29);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(147, 23);
            this.btnSearchConnections.TabIndex = 2;
            this.btnSearchConnections.Text = "Verbindungen suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // datConnections
            // 
            this.datConnections.AllowUserToAddRows = false;
            this.datConnections.AllowUserToDeleteRows = false;
            this.datConnections.AllowUserToOrderColumns = true;
            this.datConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datConnections.BackgroundColor = System.Drawing.Color.White;
            this.datConnections.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datConnections.Location = new System.Drawing.Point(12, 250);
            this.datConnections.Name = "datConnections";
            this.datConnections.RowHeadersVisible = false;
            this.datConnections.Size = new System.Drawing.Size(776, 188);
            this.datConnections.TabIndex = 3;
            // 
            // connectionListBindingSource
            // 
            this.connectionListBindingSource.DataMember = "ConnectionList";
            this.connectionListBindingSource.DataSource = this.connectionsBindingSource;
            // 
            // connectionsBindingSource
            // 
            this.connectionsBindingSource.DataSource = typeof(SwissTransport.Connections);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDepartureDate);
            this.panel1.Controls.Add(this.dtpDepartureTime);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.lstFrom);
            this.panel1.Controls.Add(this.btnFromStationBoard);
            this.panel1.Controls.Add(this.cboFrom);
            this.panel1.Controls.Add(this.btnSearchConnections);
            this.panel1.Controls.Add(this.cboTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureDate.Location = new System.Drawing.Point(12, 78);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDepartureDate.TabIndex = 9;
            this.dtpDepartureDate.Value = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDepartureTime.Location = new System.Drawing.Point(218, 78);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(78, 20);
            this.dtpDepartureTime.TabIndex = 8;
            this.dtpDepartureTime.Value = new System.DateTime(2018, 12, 1, 23, 25, 11, 0);
            // 
            // txtFrom
            // 
            this.txtFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(12, 104);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(229, 19);
            this.txtFrom.TabIndex = 6;
            this.txtFrom.Text = "Von";
            this.txtFrom.Click += new System.EventHandler(this.txtFrom_Click);
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            this.txtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFrom_KeyDown);
            this.txtFrom.Leave += new System.EventHandler(this.txtFrom_Leave);
            // 
            // lstFrom
            // 
            this.lstFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.ItemHeight = 20;
            this.lstFrom.Location = new System.Drawing.Point(12, 129);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.Size = new System.Drawing.Size(229, 100);
            this.lstFrom.TabIndex = 7;
            this.lstFrom.TabStop = false;
            this.lstFrom.Visible = false;
            this.lstFrom.Click += new System.EventHandler(this.lstFrom_Click);
            this.lstFrom.SelectedIndexChanged += new System.EventHandler(this.lstFrom_SelectedIndexChanged);
            this.lstFrom.Enter += new System.EventHandler(this.lstFrom_Enter);
            this.lstFrom.Leave += new System.EventHandler(this.lstFrom_Leave);
            // 
            // btnFromStationBoard
            // 
            this.btnFromStationBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFromStationBoard.BackgroundImage")));
            this.btnFromStationBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFromStationBoard.FlatAppearance.BorderSize = 0;
            this.btnFromStationBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnFromStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromStationBoard.Location = new System.Drawing.Point(176, 21);
            this.btnFromStationBoard.Name = "btnFromStationBoard";
            this.btnFromStationBoard.Size = new System.Drawing.Size(37, 38);
            this.btnFromStationBoard.TabIndex = 4;
            this.toolTipStationBoard.SetToolTip(this.btnFromStationBoard, "Abfahrstafel abrufen");
            this.btnFromStationBoard.UseVisualStyleBackColor = true;
            this.btnFromStationBoard.Click += new System.EventHandler(this.btnFromStationBoard_Click);
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(SwissTransport.Connection);
            // 
            // Application
            // 
            this.AcceptButton = this.btnSearchConnections;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datConnections);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖV-App";
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.DataGridView datConnections;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFromStationBoard;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.BindingSource connectionsBindingSource;
        private System.Windows.Forms.BindingSource connectionListBindingSource;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private System.Windows.Forms.BindingSource connectionBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.ToolTip toolTipStationBoard;
    }
}

