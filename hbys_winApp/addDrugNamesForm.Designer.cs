namespace hbys_winApp
{
    partial class addDrugNamesForm
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
            this.tbDrug = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.lblDrugNo = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Drug Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drug Name";
            // 
            // tbDrug
            // 
            this.tbDrug.Location = new System.Drawing.Point(111, 42);
            this.tbDrug.Name = "tbDrug";
            this.tbDrug.Size = new System.Drawing.Size(100, 20);
            this.tbDrug.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(44, 123);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // lblDrugNo
            // 
            this.lblDrugNo.AutoSize = true;
            this.lblDrugNo.Location = new System.Drawing.Point(-2, 249);
            this.lblDrugNo.Name = "lblDrugNo";
            this.lblDrugNo.Size = new System.Drawing.Size(13, 13);
            this.lblDrugNo.TabIndex = 4;
            this.lblDrugNo.Text = "..";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(136, 123);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // addDrugNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 262);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblDrugNo);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.tbDrug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addDrugNamesForm";
            this.Text = "addDrugNamesForm";
            this.Load += new System.EventHandler(this.addDrugNamesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDrug;
        private System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.Label lblDrugNo;
        private System.Windows.Forms.Button btnDel;
    }
}