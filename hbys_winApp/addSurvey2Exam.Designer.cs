namespace hbys_winApp
{
    partial class addSurvey2Exam
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboSurvey = new System.Windows.Forms.ComboBox();
            this.lblExamNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Survey";
            // 
            // comboSurvey
            // 
            this.comboSurvey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSurvey.FormattingEnabled = true;
            this.comboSurvey.Location = new System.Drawing.Point(17, 63);
            this.comboSurvey.Name = "comboSurvey";
            this.comboSurvey.Size = new System.Drawing.Size(121, 21);
            this.comboSurvey.TabIndex = 1;
            // 
            // lblExamNo
            // 
            this.lblExamNo.AutoSize = true;
            this.lblExamNo.Location = new System.Drawing.Point(13, 237);
            this.lblExamNo.Name = "lblExamNo";
            this.lblExamNo.Size = new System.Drawing.Size(22, 13);
            this.lblExamNo.TabIndex = 2;
            this.lblExamNo.Text = ".....";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addSurvey2Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblExamNo);
            this.Controls.Add(this.comboSurvey);
            this.Controls.Add(this.label1);
            this.Name = "addSurvey2Exam";
            this.Text = "addSurvey2Exam";
            this.Load += new System.EventHandler(this.addSurvey2Exam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboSurvey;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblExamNo;
    }
}