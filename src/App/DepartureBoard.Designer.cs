namespace App
{
    partial class frmDepartureBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartureBoard));
            this.lblStation = new System.Windows.Forms.Label();
            this.datStationBoard = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDeparturBoard = new System.Windows.Forms.Panel();
            this.pnlHead = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datStationBoard)).BeginInit();
            this.pnlDeparturBoard.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.ForeColor = System.Drawing.Color.White;
            this.lblStation.Location = new System.Drawing.Point(12, 4);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(110, 20);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "stationName";
            this.lblStation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // datStationBoard
            // 
            this.datStationBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datStationBoard.BackgroundColor = System.Drawing.Color.White;
            this.datStationBoard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datStationBoard.DefaultCellStyle = dataGridViewCellStyle3;
            this.datStationBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datStationBoard.Location = new System.Drawing.Point(0, 0);
            this.datStationBoard.Name = "datStationBoard";
            this.datStationBoard.RowHeadersVisible = false;
            this.datStationBoard.Size = new System.Drawing.Size(740, 423);
            this.datStationBoard.TabIndex = 2;
            this.datStationBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(710, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlDeparturBoard
            // 
            this.pnlDeparturBoard.Controls.Add(this.datStationBoard);
            this.pnlDeparturBoard.Location = new System.Drawing.Point(0, 27);
            this.pnlDeparturBoard.Name = "pnlDeparturBoard";
            this.pnlDeparturBoard.Size = new System.Drawing.Size(740, 423);
            this.pnlDeparturBoard.TabIndex = 14;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Controls.Add(this.lblStation);
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(740, 30);
            this.pnlHead.TabIndex = 14;
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // frmDepartureBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlDeparturBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepartureBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.datStationBoard)).EndInit();
            this.pnlDeparturBoard.ResumeLayout(false);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.DataGridView datStationBoard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDeparturBoard;
        private System.Windows.Forms.Panel pnlHead;
    }
}