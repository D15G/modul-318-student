namespace App
{
    partial class DepartureBoard
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
            this.lblStation = new System.Windows.Forms.Label();
            this.datStationBoard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datStationBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(12, 9);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(66, 13);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "stationName";
            // 
            // datStationBoard
            // 
            this.datStationBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datStationBoard.BackgroundColor = System.Drawing.Color.White;
            this.datStationBoard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datStationBoard.Location = new System.Drawing.Point(12, 44);
            this.datStationBoard.Name = "datStationBoard";
            this.datStationBoard.RowHeadersVisible = false;
            this.datStationBoard.Size = new System.Drawing.Size(776, 394);
            this.datStationBoard.TabIndex = 2;
            this.datStationBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datStationBoard_CellContentClick);
            // 
            // DepartureBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datStationBoard);
            this.Controls.Add(this.lblStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DepartureBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abfahrtstafel";
            this.Load += new System.EventHandler(this.DepartureBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datStationBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.DataGridView datStationBoard;
    }
}