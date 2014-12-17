namespace hbys_winApp
{
    partial class addSurveyNames
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbSurvey = new System.Windows.Forms.TextBox();
            this.btn_Save_Survey_Name = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSurveyNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Survey Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Survey Name";
            // 
            // tbSurvey
            // 
            this.tbSurvey.Location = new System.Drawing.Point(125, 51);
            this.tbSurvey.Name = "tbSurvey";
            this.tbSurvey.Size = new System.Drawing.Size(100, 20);
            this.tbSurvey.TabIndex = 2;
            // 
            // btn_Save_Survey_Name
            // 
            this.btn_Save_Survey_Name.Location = new System.Drawing.Point(46, 126);
            this.btn_Save_Survey_Name.Name = "btn_Save_Survey_Name";
            this.btn_Save_Survey_Name.Size = new System.Drawing.Size(75, 23);
            this.btn_Save_Survey_Name.TabIndex = 3;
            this.btn_Save_Survey_Name.Text = "Save";
            this.btn_Save_Survey_Name.UseVisualStyleBackColor = true;
            this.btn_Save_Survey_Name.Click += new System.EventHandler(this.btn_Save_Survey_Name_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(154, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSurveyNo
            // 
            this.lblSurveyNo.AutoSize = true;
            this.lblSurveyNo.Location = new System.Drawing.Point(0, 280);
            this.lblSurveyNo.Name = "lblSurveyNo";
            this.lblSurveyNo.Size = new System.Drawing.Size(13, 13);
            this.lblSurveyNo.TabIndex = 5;
            this.lblSurveyNo.Text = "..";
            // 
            // addSurveyNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 295);
            this.Controls.Add(this.lblSurveyNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_Save_Survey_Name);
            this.Controls.Add(this.tbSurvey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addSurveyNames";
            this.Text = "addSurveyNames";
            this.Load += new System.EventHandler(this.addSurveyNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSurvey;
        private System.Windows.Forms.Button btn_Save_Survey_Name;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblSurveyNo;
    }
}