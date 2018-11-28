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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.datConnections = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datConnections)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFrom
            // 
            this.cboFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(12, 31);
            this.cboFrom.MaxDropDownItems = 10;
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(158, 21);
            this.cboFrom.TabIndex = 0;
            this.cboFrom.Text = "Von";
            this.cboFrom.Click += new System.EventHandler(this.cboFrom_Click);
            // 
            // cboTo
            // 
            this.cboTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(198, 31);
            this.cboTo.MaxDropDownItems = 10;
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(158, 21);
            this.cboTo.TabIndex = 1;
            this.cboTo.Text = "Nach";
            this.cboTo.Click += new System.EventHandler(this.cboTo_Click);
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(371, 29);
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
            this.datConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datConnections.Location = new System.Drawing.Point(12, 139);
            this.datConnections.Name = "datConnections";
            this.datConnections.Size = new System.Drawing.Size(776, 299);
            this.datConnections.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBinh);
            this.panel1.Controls.Add(this.cboFrom);
            this.panel1.Controls.Add(this.btnSearchConnections);
            this.panel1.Controls.Add(this.cboTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // btnBinh
            // 
            this.btnBinh.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBinh.Location = new System.Drawing.Point(662, 12);
            this.btnBinh.Name = "btnBinh";
            this.btnBinh.Size = new System.Drawing.Size(126, 23);
            this.btnBinh.TabIndex = 3;
            this.btnBinh.Text = "IM A TEST BUTTON";
            this.btnBinh.UseVisualStyleBackColor = true;
            this.btnBinh.Click += new System.EventHandler(this.btnBinh_Click);
            // 
            // UI
            // 
            this.AcceptButton = this.btnSearchConnections;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datConnections);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖV-App";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datConnections)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.DataGridView datConnections;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBinh;
    }
}

