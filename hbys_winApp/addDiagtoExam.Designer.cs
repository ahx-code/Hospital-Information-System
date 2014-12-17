namespace hbys_winApp
{
    partial class addDiagtoExam
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
            this.comboDiag = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExamNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboDiag
            // 
            this.comboDiag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDiag.FormattingEnabled = true;
            this.comboDiag.Location = new System.Drawing.Point(81, 27);
            this.comboDiag.Name = "comboDiag";
            this.comboDiag.Size = new System.Drawing.Size(121, 21);
            this.comboDiag.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(81, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diagnosis";
            // 
            // lblExamNo
            // 
            this.lblExamNo.AutoSize = true;
            this.lblExamNo.Location = new System.Drawing.Point(5, 193);
            this.lblExamNo.Name = "lblExamNo";
            this.lblExamNo.Size = new System.Drawing.Size(22, 13);
            this.lblExamNo.TabIndex = 3;
            this.lblExamNo.Text = ".....";
            // 
            // addDiagtoExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 218);
            this.Controls.Add(this.lblExamNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboDiag);
            this.Name = "addDiagtoExam";
            this.Text = "addDiagtoExam";
            this.Load += new System.EventHandler(this.addDiagtoExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDiag;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblExamNo;
    }
}