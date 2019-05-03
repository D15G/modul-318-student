namespace App
{
    partial class App
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dgtConnections = new System.Windows.Forms.DataGridView();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtBoard = new System.Windows.Forms.DataGridView();
            this.boardDeparting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardEndstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDateAndTimeFromSearch = new System.Windows.Forms.Label();
            this.btnGoogleMaps = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.pbToMap = new System.Windows.Forms.PictureBox();
            this.pbFromMap = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbExchange = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFromMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(35, 22);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(26, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Von";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(512, 22);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Nach";
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(38, 39);
            this.cmbFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(185, 21);
            this.cmbFrom.TabIndex = 5;
            this.cmbFrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Autocomplete_KeyUp);
            // 
            // cmbTo
            // 
            this.cmbTo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(514, 39);
            this.cmbTo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(185, 21);
            this.cmbTo.TabIndex = 6;
            this.cmbTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Autocomplete_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(226, 72);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(283, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(223, 153);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Datum";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(226, 168);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(116, 20);
            this.dtpDate.TabIndex = 10;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(390, 152);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(25, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Zeit";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(393, 169);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(116, 20);
            this.dtpTime.TabIndex = 11;
            // 
            // dgtConnections
            // 
            this.dgtConnections.AllowUserToAddRows = false;
            this.dgtConnections.AllowUserToDeleteRows = false;
            this.dgtConnections.AllowUserToResizeColumns = false;
            this.dgtConnections.AllowUserToResizeRows = false;
            this.dgtConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtConnections.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtConnections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departure,
            this.platformDeparture,
            this.endStation,
            this.arrival,
            this.tripLength});
            this.dgtConnections.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgtConnections.Location = new System.Drawing.Point(-1, 217);
            this.dgtConnections.Margin = new System.Windows.Forms.Padding(2);
            this.dgtConnections.Name = "dgtConnections";
            this.dgtConnections.ReadOnly = true;
            this.dgtConnections.RowHeadersVisible = false;
            this.dgtConnections.RowTemplate.Height = 24;
            this.dgtConnections.Size = new System.Drawing.Size(735, 292);
            this.dgtConnections.TabIndex = 12;
            // 
            // departure
            // 
            this.departure.HeaderText = "Abfahrt";
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            // 
            // platformDeparture
            // 
            this.platformDeparture.HeaderText = "Gleis Abfahrt";
            this.platformDeparture.Name = "platformDeparture";
            this.platformDeparture.ReadOnly = true;
            // 
            // endStation
            // 
            this.endStation.HeaderText = "Endstation";
            this.endStation.Name = "endStation";
            this.endStation.ReadOnly = true;
            // 
            // arrival
            // 
            this.arrival.HeaderText = "Ankunft";
            this.arrival.Name = "arrival";
            this.arrival.ReadOnly = true;
            // 
            // tripLength
            // 
            this.tripLength.HeaderText = "Fahrdauer";
            this.tripLength.Name = "tripLength";
            this.tripLength.ReadOnly = true;
            // 
            // dgtBoard
            // 
            this.dgtBoard.AllowUserToAddRows = false;
            this.dgtBoard.AllowUserToDeleteRows = false;
            this.dgtBoard.AllowUserToResizeColumns = false;
            this.dgtBoard.AllowUserToResizeRows = false;
            this.dgtBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtBoard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgtBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boardDeparting,
            this.boardPlatform,
            this.boardEndstation});
            this.dgtBoard.Location = new System.Drawing.Point(-1, 217);
            this.dgtBoard.Margin = new System.Windows.Forms.Padding(2);
            this.dgtBoard.Name = "dgtBoard";
            this.dgtBoard.ReadOnly = true;
            this.dgtBoard.RowHeadersVisible = false;
            this.dgtBoard.RowTemplate.Height = 24;
            this.dgtBoard.Size = new System.Drawing.Size(735, 292);
            this.dgtBoard.TabIndex = 13;
            // 
            // boardDeparting
            // 
            this.boardDeparting.HeaderText = "Abfahrt";
            this.boardDeparting.Name = "boardDeparting";
            this.boardDeparting.ReadOnly = true;
            // 
            // boardPlatform
            // 
            this.boardPlatform.HeaderText = "Gleis Abfahrt";
            this.boardPlatform.Name = "boardPlatform";
            this.boardPlatform.ReadOnly = true;
            // 
            // boardEndstation
            // 
            this.boardEndstation.HeaderText = "Endstation";
            this.boardEndstation.Name = "boardEndstation";
            this.boardEndstation.ReadOnly = true;
            // 
            // lblDateAndTimeFromSearch
            // 
            this.lblDateAndTimeFromSearch.AutoSize = true;
            this.lblDateAndTimeFromSearch.Location = new System.Drawing.Point(223, 202);
            this.lblDateAndTimeFromSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateAndTimeFromSearch.Name = "lblDateAndTimeFromSearch";
            this.lblDateAndTimeFromSearch.Size = new System.Drawing.Size(0, 13);
            this.lblDateAndTimeFromSearch.TabIndex = 14;
            // 
            // btnGoogleMaps
            // 
            this.btnGoogleMaps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoogleMaps.Location = new System.Drawing.Point(226, 99);
            this.btnGoogleMaps.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoogleMaps.Name = "btnGoogleMaps";
            this.btnGoogleMaps.Size = new System.Drawing.Size(283, 23);
            this.btnGoogleMaps.TabIndex = 8;
            this.btnGoogleMaps.Text = "Route auf Google Maps";
            this.btnGoogleMaps.UseVisualStyleBackColor = true;
            this.btnGoogleMaps.Click += new System.EventHandler(this.BtnGoogleMaps_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCopyright.Location = new System.Drawing.Point(635, 187);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(84, 13);
            this.lblCopyright.TabIndex = 19;
            this.lblCopyright.Text = "© David Gataric";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(226, 127);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(283, 23);
            this.btnSendMail.TabIndex = 9;
            this.btnSendMail.Text = "Daten an Freund versenden";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // pbToMap
            // 
            this.pbToMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbToMap.Image = global::App.Properties.Resources.maps_and_flags__2_;
            this.pbToMap.Location = new System.Drawing.Point(485, 32);
            this.pbToMap.Margin = new System.Windows.Forms.Padding(2);
            this.pbToMap.Name = "pbToMap";
            this.pbToMap.Size = new System.Drawing.Size(24, 26);
            this.pbToMap.TabIndex = 17;
            this.pbToMap.TabStop = false;
            this.pbToMap.Click += new System.EventHandler(this.MapTo_Click);
            // 
            // pbFromMap
            // 
            this.pbFromMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFromMap.Image = global::App.Properties.Resources.maps_and_flags__2_;
            this.pbFromMap.Location = new System.Drawing.Point(226, 32);
            this.pbFromMap.Margin = new System.Windows.Forms.Padding(2);
            this.pbFromMap.Name = "pbFromMap";
            this.pbFromMap.Size = new System.Drawing.Size(24, 26);
            this.pbFromMap.TabIndex = 16;
            this.pbFromMap.TabStop = false;
            this.pbFromMap.Click += new System.EventHandler(this.MapFrom_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App.Properties.Resources.train_icon;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 87);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pbExchange
            // 
            this.pbExchange.BackgroundImage = global::App.Properties.Resources.exchange_arrows;
            this.pbExchange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbExchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExchange.Location = new System.Drawing.Point(353, 30);
            this.pbExchange.Margin = new System.Windows.Forms.Padding(2);
            this.pbExchange.Name = "pbExchange";
            this.pbExchange.Size = new System.Drawing.Size(33, 28);
            this.pbExchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExchange.TabIndex = 4;
            this.pbExchange.TabStop = false;
            this.pbExchange.Click += new System.EventHandler(this.Exchange_Click);
            // 
            // App
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(731, 515);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnGoogleMaps);
            this.Controls.Add(this.pbToMap);
            this.Controls.Add(this.pbFromMap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDateAndTimeFromSearch);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.pbExchange);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dgtConnections);
            this.Controls.Add(this.dgtBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concheck";
            ((System.ComponentModel.ISupportInitialize)(this.dgtConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFromMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExchange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.PictureBox pbExchange;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DataGridView dgtConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripLength;
        private System.Windows.Forms.DataGridView dgtBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardDeparting;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardEndstation;
        private System.Windows.Forms.Label lblDateAndTimeFromSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbFromMap;
        private System.Windows.Forms.PictureBox pbToMap;
        private System.Windows.Forms.Button btnGoogleMaps;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnSendMail;
    }
}

