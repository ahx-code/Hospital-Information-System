namespace hbys_winApp
{
    partial class addExaminationDatas
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
            this.lblExNo = new System.Windows.Forms.Label();
            this.lblex = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPersonal = new System.Windows.Forms.ComboBox();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.comboPatient = new System.Windows.Forms.ComboBox();
            this.dateExam = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblExNo
            // 
            this.lblExNo.AutoSize = true;
            this.lblExNo.Location = new System.Drawing.Point(12, 317);
            this.lblExNo.Name = "lblExNo";
            this.lblExNo.Size = new System.Drawing.Size(17, 13);
            this.lblExNo.TabIndex = 0;
            this.lblExNo.Text = "//";
            // 
            // lblex
            // 
            this.lblex.AutoSize = true;
            this.lblex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblex.Location = new System.Drawing.Point(24, 9);
            this.lblex.Name = "lblex";
            this.lblex.Size = new System.Drawing.Size(165, 13);
            this.lblex.TabIndex = 1;
            this.lblex.Text = "Add new Examination Datas";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(114, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(244, 257);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // comboPersonal
            // 
            this.comboPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPersonal.FormattingEnabled = true;
            this.comboPersonal.Location = new System.Drawing.Point(132, 41);
            this.comboPersonal.Name = "comboPersonal";
            this.comboPersonal.Size = new System.Drawing.Size(187, 21);
            this.comboPersonal.TabIndex = 8;
            // 
            // comboService
            // 
            this.comboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(132, 79);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(187, 21);
            this.comboService.TabIndex = 9;
            // 
            // comboPatient
            // 
            this.comboPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPatient.FormattingEnabled = true;
            this.comboPatient.Location = new System.Drawing.Point(132, 122);
            this.comboPatient.Name = "comboPatient";
            this.comboPatient.Size = new System.Drawing.Size(187, 21);
            this.comboPatient.TabIndex = 10;
            // 
            // dateExam
            // 
            this.dateExam.Location = new System.Drawing.Point(132, 168);
            this.dateExam.Name = "dateExam";
            this.dateExam.Size = new System.Drawing.Size(187, 20);
            this.dateExam.TabIndex = 11;
            // 
            // addExaminationDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 344);
            this.Controls.Add(this.dateExam);
            this.Controls.Add(this.comboPatient);
            this.Controls.Add(this.comboService);
            this.Controls.Add(this.comboPersonal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblex);
            this.Controls.Add(this.lblExNo);
            this.Name = "addExaminationDatas";
            this.Text = "addExaminationDatas";
            this.Load += new System.EventHandler(this.addExaminationDatas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblExNo;
        public System.Windows.Forms.Label lblex;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPersonal;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.ComboBox comboPatient;
        private System.Windows.Forms.DateTimePicker dateExam;

    }
}