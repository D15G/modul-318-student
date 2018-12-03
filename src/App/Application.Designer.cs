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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplication));
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.datConnections = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnToStationBoard = new System.Windows.Forms.Button();
            this.btnIsArrivalTime = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.btnFromStationBoard = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.toolTipStationBoard = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datConnections)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFrom
            // 
            this.cboFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboFrom.BackColor = System.Drawing.Color.Silver;
            this.cboFrom.DisplayMember = "Name";
            this.cboFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.ItemHeight = 20;
            this.cboFrom.Location = new System.Drawing.Point(12, 42);
            this.cboFrom.MaxDropDownItems = 10;
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(305, 28);
            this.cboFrom.TabIndex = 0;
            this.cboFrom.ValueMember = "Id";
            this.cboFrom.TextChanged += new System.EventHandler(this.cboFrom_TextChanged);
            this.cboFrom.Click += new System.EventHandler(this.cboFrom_Click);
            // 
            // cboTo
            // 
            this.cboTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboTo.BackColor = System.Drawing.Color.Silver;
            this.cboTo.DisplayMember = "Name";
            this.cboTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(421, 42);
            this.cboTo.MaxDropDownItems = 10;
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(314, 28);
            this.cboTo.TabIndex = 1;
            this.cboTo.ValueMember = "Id";
            this.cboTo.TextChanged += new System.EventHandler(this.cboTo_TextChanged);
            this.cboTo.Click += new System.EventHandler(this.cboTo_Click);
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.BackColor = System.Drawing.Color.Silver;
            this.btnSearchConnections.FlatAppearance.BorderSize = 0;
            this.btnSearchConnections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSearchConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchConnections.Location = new System.Drawing.Point(641, 146);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(147, 20);
            this.btnSearchConnections.TabIndex = 2;
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
            this.datConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datConnections.BackgroundColor = System.Drawing.Color.White;
            this.datConnections.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datConnections.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datConnections.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datConnections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.datConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datConnections.DefaultCellStyle = dataGridViewCellStyle14;
            this.datConnections.Location = new System.Drawing.Point(12, 172);
            this.datConnections.Name = "datConnections";
            this.datConnections.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datConnections.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.datConnections.RowHeadersVisible = false;
            this.datConnections.Size = new System.Drawing.Size(776, 266);
            this.datConnections.TabIndex = 3;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cboFrom);
            this.pnlMain.Controls.Add(this.datConnections);
            this.pnlMain.Controls.Add(this.btnToStationBoard);
            this.pnlMain.Controls.Add(this.btnIsArrivalTime);
            this.pnlMain.Controls.Add(this.dtpDate);
            this.pnlMain.Controls.Add(this.dtpTime);
            this.pnlMain.Controls.Add(this.txtFrom);
            this.pnlMain.Controls.Add(this.lstFrom);
            this.pnlMain.Controls.Add(this.btnFromStationBoard);
            this.pnlMain.Controls.Add(this.btnSearchConnections);
            this.pnlMain.Controls.Add(this.cboTo);
            this.pnlMain.Location = new System.Drawing.Point(0, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 423);
            this.pnlMain.TabIndex = 4;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // btnToStationBoard
            // 
            this.btnToStationBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToStationBoard.BackgroundImage")));
            this.btnToStationBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToStationBoard.FlatAppearance.BorderSize = 0;
            this.btnToStationBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnToStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToStationBoard.Location = new System.Drawing.Point(741, 40);
            this.btnToStationBoard.Name = "btnToStationBoard";
            this.btnToStationBoard.Size = new System.Drawing.Size(32, 30);
            this.btnToStationBoard.TabIndex = 11;
            this.toolTipStationBoard.SetToolTip(this.btnToStationBoard, "Abfahrstafel abrufen");
            this.btnToStationBoard.UseVisualStyleBackColor = true;
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
            this.btnIsArrivalTime.Location = new System.Drawing.Point(12, 78);
            this.btnIsArrivalTime.Name = "btnIsArrivalTime";
            this.btnIsArrivalTime.Size = new System.Drawing.Size(138, 26);
            this.btnIsArrivalTime.TabIndex = 10;
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
            this.dtpDate.Location = new System.Drawing.Point(226, 78);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(158, 26);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.Value = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpTime.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(156, 78);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(64, 26);
            this.dtpTime.TabIndex = 8;
            this.dtpTime.Value = new System.DateTime(2018, 12, 3, 0, 0, 0, 0);
            // 
            // txtFrom
            // 
            this.txtFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFrom.BackColor = System.Drawing.Color.Silver;
            this.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(331, 110);
            this.txtFrom.MinimumSize = new System.Drawing.Size(229, 28);
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
            this.lstFrom.Location = new System.Drawing.Point(331, 137);
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
            this.btnFromStationBoard.Location = new System.Drawing.Point(323, 40);
            this.btnFromStationBoard.Name = "btnFromStationBoard";
            this.btnFromStationBoard.Size = new System.Drawing.Size(32, 30);
            this.btnFromStationBoard.TabIndex = 4;
            this.toolTipStationBoard.SetToolTip(this.btnFromStationBoard, "Abfahrstafel abrufen");
            this.btnFromStationBoard.UseVisualStyleBackColor = true;
            this.btnFromStationBoard.Click += new System.EventHandler(this.btnFromStationBoard_Click);
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
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Controls.Add(this.lblTitle);
            this.pnlHead.Controls.Add(this.btnMinimize);
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(800, 30);
            this.pnlHead.TabIndex = 15;
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
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
            this.Load += new System.EventHandler(this.Application_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.datConnections)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.DataGridView datConnections;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnFromStationBoard;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ToolTip toolTipStationBoard;
        private System.Windows.Forms.Button btnIsArrivalTime;
        private System.Windows.Forms.Button btnToStationBoard;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}

