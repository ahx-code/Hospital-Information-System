namespace hbys_winApp
{
    partial class addDiagnosisNamesForm
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
            this.lblDiagnosisHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDiagnosis = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDiagNo = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiagnosisHeader
            // 
            this.lblDiagnosisHeader.AutoSize = true;
            this.lblDiagnosisHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiagnosisHeader.Location = new System.Drawing.Point(13, 13);
            this.lblDiagnosisHeader.Name = "lblDiagnosisHeader";
            this.lblDiagnosisHeader.Size = new System.Drawing.Size(153, 13);
            this.lblDiagnosisHeader.TabIndex = 0;
            this.lblDiagnosisHeader.Text = "Add New Diagnosis Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diagnosis Name";
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.Location = new System.Drawing.Point(123, 54);
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.Size = new System.Drawing.Size(118, 20);
            this.tbDiagnosis.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDiagNo
            // 
            this.lblDiagNo.AutoSize = true;
            this.lblDiagNo.Location = new System.Drawing.Point(12, 240);
            this.lblDiagNo.Name = "lblDiagNo";
            this.lblDiagNo.Size = new System.Drawing.Size(13, 13);
            this.lblDiagNo.TabIndex = 4;
            this.lblDiagNo.Text = "..";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(148, 136);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // addDiagnosisNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 262);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblDiagNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDiagnosis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDiagnosisHeader);
            this.Name = "addDiagnosisNamesForm";
            this.Text = "addNewDiagnosisNamesForm";
            this.Load += new System.EventHandler(this.addDiagnosisNamesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDiagnosis;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblDiagNo;
        private System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Label lblDiagnosisHeader;
    }
}