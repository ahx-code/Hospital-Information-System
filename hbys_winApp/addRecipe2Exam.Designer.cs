namespace hbys_winApp
{
    partial class addRecipe2Exam
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
            this.dtRecipeDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExamNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtRecipeDate
            // 
            this.dtRecipeDate.Location = new System.Drawing.Point(17, 65);
            this.dtRecipeDate.Name = "dtRecipeDate";
            this.dtRecipeDate.Size = new System.Drawing.Size(200, 20);
            this.dtRecipeDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipe Date";
            // 
            // lblExamNo
            // 
            this.lblExamNo.AutoSize = true;
            this.lblExamNo.Location = new System.Drawing.Point(4, 238);
            this.lblExamNo.Name = "lblExamNo";
            this.lblExamNo.Size = new System.Drawing.Size(10, 13);
            this.lblExamNo.TabIndex = 2;
            this.lblExamNo.Text = ".";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(240, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addRecipe2Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 256);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblExamNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtRecipeDate);
            this.Name = "addRecipe2Exam";
            this.Text = "addRecipe2Exam";
            this.Load += new System.EventHandler(this.addRecipe2Exam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtRecipeDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblExamNo;
    }
}