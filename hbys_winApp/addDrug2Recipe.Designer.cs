namespace hbys_winApp
{
    partial class addDrug2Recipe
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
            this.comboDrug = new System.Windows.Forms.ComboBox();
            this.lblRecipeNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "drug";
            // 
            // comboDrug
            // 
            this.comboDrug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDrug.FormattingEnabled = true;
            this.comboDrug.Location = new System.Drawing.Point(92, 13);
            this.comboDrug.Name = "comboDrug";
            this.comboDrug.Size = new System.Drawing.Size(121, 21);
            this.comboDrug.TabIndex = 1;
            // 
            // lblRecipeNo
            // 
            this.lblRecipeNo.AutoSize = true;
            this.lblRecipeNo.Location = new System.Drawing.Point(13, 285);
            this.lblRecipeNo.Name = "lblRecipeNo";
            this.lblRecipeNo.Size = new System.Drawing.Size(22, 13);
            this.lblRecipeNo.TabIndex = 2;
            this.lblRecipeNo.Text = ".....";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addDrug2Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 310);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRecipeNo);
            this.Controls.Add(this.comboDrug);
            this.Controls.Add(this.label1);
            this.Name = "addDrug2Recipe";
            this.Text = "addDrug2Recipe";
            this.Load += new System.EventHandler(this.addDrug2Recipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDrug;
        public System.Windows.Forms.Label lblRecipeNo;
        private System.Windows.Forms.Button btnAdd;
    }
}