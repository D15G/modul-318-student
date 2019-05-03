namespace App
{
    partial class MailDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailDialog));
            this.lblMailService = new System.Windows.Forms.Label();
            this.cmbMailService = new System.Windows.Forms.ComboBox();
            this.lblMailAdress = new System.Windows.Forms.Label();
            this.txtMailAddress = new System.Windows.Forms.TextBox();
            this.lblMailPassword = new System.Windows.Forms.Label();
            this.txtMailPassword = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMailTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMailService
            // 
            this.lblMailService.AutoSize = true;
            this.lblMailService.Location = new System.Drawing.Point(12, 9);
            this.lblMailService.Name = "lblMailService";
            this.lblMailService.Size = new System.Drawing.Size(151, 13);
            this.lblMailService.TabIndex = 0;
            this.lblMailService.Text = "Wählen Sie Ihren Anbieter aus";
            // 
            // cmbMailService
            // 
            this.cmbMailService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMailService.FormattingEnabled = true;
            this.cmbMailService.Items.AddRange(new object[] {
            "Outlook",
            "Gmail"});
            this.cmbMailService.Location = new System.Drawing.Point(12, 25);
            this.cmbMailService.Name = "cmbMailService";
            this.cmbMailService.Size = new System.Drawing.Size(239, 21);
            this.cmbMailService.TabIndex = 1;
            // 
            // lblMailAdress
            // 
            this.lblMailAdress.AutoSize = true;
            this.lblMailAdress.Location = new System.Drawing.Point(12, 86);
            this.lblMailAdress.Name = "lblMailAdress";
            this.lblMailAdress.Size = new System.Drawing.Size(94, 13);
            this.lblMailAdress.TabIndex = 2;
            this.lblMailAdress.Text = "Ihre Email-Adresse";
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.Location = new System.Drawing.Point(12, 102);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(239, 20);
            this.txtMailAddress.TabIndex = 3;
            // 
            // lblMailPassword
            // 
            this.lblMailPassword.AutoSize = true;
            this.lblMailPassword.Location = new System.Drawing.Point(12, 138);
            this.lblMailPassword.Name = "lblMailPassword";
            this.lblMailPassword.Size = new System.Drawing.Size(50, 13);
            this.lblMailPassword.TabIndex = 4;
            this.lblMailPassword.Text = "Passwort";
            // 
            // txtMailPassword
            // 
            this.txtMailPassword.Location = new System.Drawing.Point(15, 154);
            this.txtMailPassword.Name = "txtMailPassword";
            this.txtMailPassword.Size = new System.Drawing.Size(236, 20);
            this.txtMailPassword.TabIndex = 5;
            this.txtMailPassword.UseSystemPasswordChar = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(176, 197);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Senden";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtMailTo
            // 
            this.txtMailTo.Location = new System.Drawing.Point(289, 102);
            this.txtMailTo.Name = "txtMailTo";
            this.txtMailTo.Size = new System.Drawing.Size(239, 20);
            this.txtMailTo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "An";
            // 
            // MailDialog
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMailTo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMailPassword);
            this.Controls.Add(this.lblMailPassword);
            this.Controls.Add(this.txtMailAddress);
            this.Controls.Add(this.lblMailAdress);
            this.Controls.Add(this.cmbMailService);
            this.Controls.Add(this.lblMailService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MailDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Email versenden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMailService;
        private System.Windows.Forms.ComboBox cmbMailService;
        private System.Windows.Forms.Label lblMailAdress;
        private System.Windows.Forms.TextBox txtMailAddress;
        private System.Windows.Forms.Label lblMailPassword;
        private System.Windows.Forms.TextBox txtMailPassword;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMailTo;
        private System.Windows.Forms.Label label1;
    }
}