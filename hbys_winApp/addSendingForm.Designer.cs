namespace hbys_winApp
{
    partial class addSendingForm
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
            this.lblSendingHeader = new System.Windows.Forms.Label();
            this.lblSendingNo = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblEstablishmentName = new System.Windows.Forms.Label();
            this.comboBoxEstablishment = new System.Windows.Forms.ComboBox();
            this.comboBoxPatientName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSendingHeader
            // 
            this.lblSendingHeader.AutoSize = true;
            this.lblSendingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSendingHeader.Location = new System.Drawing.Point(13, 13);
            this.lblSendingHeader.Name = "lblSendingHeader";
            this.lblSendingHeader.Size = new System.Drawing.Size(117, 24);
            this.lblSendingHeader.TabIndex = 0;
            this.lblSendingHeader.Text = "This is Title";
            // 
            // lblSendingNo
            // 
            this.lblSendingNo.AutoSize = true;
            this.lblSendingNo.Location = new System.Drawing.Point(13, 443);
            this.lblSendingNo.Name = "lblSendingNo";
            this.lblSendingNo.Size = new System.Drawing.Size(100, 13);
            this.lblSendingNo.TabIndex = 1;
            this.lblSendingNo.Text = "This is Secret Label";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(16, 132);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(71, 13);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblEstablishmentName
            // 
            this.lblEstablishmentName.AutoSize = true;
            this.lblEstablishmentName.Location = new System.Drawing.Point(16, 187);
            this.lblEstablishmentName.Name = "lblEstablishmentName";
            this.lblEstablishmentName.Size = new System.Drawing.Size(103, 13);
            this.lblEstablishmentName.TabIndex = 5;
            this.lblEstablishmentName.Text = "Establishment Name";
            // 
            // comboBoxEstablishment
            // 
            this.comboBoxEstablishment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstablishment.FormattingEnabled = true;
            this.comboBoxEstablishment.Location = new System.Drawing.Point(159, 179);
            this.comboBoxEstablishment.Name = "comboBoxEstablishment";
            this.comboBoxEstablishment.Size = new System.Drawing.Size(244, 21);
            this.comboBoxEstablishment.TabIndex = 6;
            // 
            // comboBoxPatientName
            // 
            this.comboBoxPatientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatientName.FormattingEnabled = true;
            this.comboBoxPatientName.Location = new System.Drawing.Point(159, 124);
            this.comboBoxPatientName.Name = "comboBoxPatientName";
            this.comboBoxPatientName.Size = new System.Drawing.Size(244, 21);
            this.comboBoxPatientName.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Mr. Button";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(205, 273);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // addSendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 468);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxPatientName);
            this.Controls.Add(this.comboBoxEstablishment);
            this.Controls.Add(this.lblEstablishmentName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblSendingNo);
            this.Controls.Add(this.lblSendingHeader);
            this.Name = "addSendingForm";
            this.Text = "addSendingForm";
            this.Load += new System.EventHandler(this.addSendingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSendingNo;
        public System.Windows.Forms.Label lblSendingHeader;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblEstablishmentName;
        private System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox comboBoxEstablishment;
        public System.Windows.Forms.ComboBox comboBoxPatientName;
    }
}