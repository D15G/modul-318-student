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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(47, 27);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 17);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Von";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(682, 27);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(41, 17);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Nach";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::App.Properties.Resources.exchange1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(453, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Exchange_Click);
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(50, 48);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(245, 24);
            this.cmbFrom.TabIndex = 5;
            this.cmbFrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Autocomplete_KeyUp);
            // 
            // cmbTo
            // 
            this.cmbTo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(685, 48);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(245, 24);
            this.cmbTo.TabIndex = 6;
            this.cmbTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Autocomplete_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(302, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(377, 28);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(302, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 17);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Datum";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(305, 162);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(153, 22);
            this.dtpDate.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(523, 141);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 17);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Zeit";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(526, 162);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(153, 22);
            this.dtpTime.TabIndex = 11;
            // 
            // dgtConnections
            // 
            this.dgtConnections.AllowUserToAddRows = false;
            this.dgtConnections.AllowUserToDeleteRows = false;
            this.dgtConnections.AllowUserToResizeColumns = false;
            this.dgtConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtConnections.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.dgtConnections.Location = new System.Drawing.Point(14, 247);
            this.dgtConnections.Name = "dgtConnections";
            this.dgtConnections.ReadOnly = true;
            this.dgtConnections.RowHeadersVisible = false;
            this.dgtConnections.RowTemplate.Height = 24;
            this.dgtConnections.Size = new System.Drawing.Size(949, 363);
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
            this.dgtBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtBoard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.dgtBoard.Location = new System.Drawing.Point(12, 247);
            this.dgtBoard.Name = "dgtBoard";
            this.dgtBoard.ReadOnly = true;
            this.dgtBoard.RowHeadersVisible = false;
            this.dgtBoard.RowTemplate.Height = 24;
            this.dgtBoard.Size = new System.Drawing.Size(949, 363);
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
            this.lblDateAndTimeFromSearch.Location = new System.Drawing.Point(305, 208);
            this.lblDateAndTimeFromSearch.Name = "lblDateAndTimeFromSearch";
            this.lblDateAndTimeFromSearch.Size = new System.Drawing.Size(0, 17);
            this.lblDateAndTimeFromSearch.TabIndex = 14;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(975, 622);
            this.Controls.Add(this.lblDateAndTimeFromSearch);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dgtConnections);
            this.Controls.Add(this.dgtBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concheck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}

