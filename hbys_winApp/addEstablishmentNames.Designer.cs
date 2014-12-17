namespace hbys_winApp
{
    partial class addEstablishmentNames
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
            this.lblEstablishmentHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEstab = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEstabNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstablishmentHeader
            // 
            this.lblEstablishmentHeader.AutoSize = true;
            this.lblEstablishmentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEstablishmentHeader.Location = new System.Drawing.Point(13, 13);
            this.lblEstablishmentHeader.Name = "lblEstablishmentHeader";
            this.lblEstablishmentHeader.Size = new System.Drawing.Size(182, 13);
            this.lblEstablishmentHeader.TabIndex = 0;
            this.lblEstablishmentHeader.Text = "Add New Establishment Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Establishment Names";
            // 
            // tbEstab
            // 
            this.tbEstab.Location = new System.Drawing.Point(140, 67);
            this.tbEstab.Name = "tbEstab";
            this.tbEstab.Size = new System.Drawing.Size(225, 20);
            this.tbEstab.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(120, 137);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(210, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblEstabNo
            // 
            this.lblEstabNo.AutoSize = true;
            this.lblEstabNo.Location = new System.Drawing.Point(-1, 236);
            this.lblEstabNo.Name = "lblEstabNo";
            this.lblEstabNo.Size = new System.Drawing.Size(13, 13);
            this.lblEstabNo.TabIndex = 5;
            this.lblEstabNo.Text = "..";
            // 
            // addEstablishmentNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 252);
            this.Controls.Add(this.lblEstabNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tbEstab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEstablishmentHeader);
            this.Name = "addEstablishmentNames";
            this.Text = "addEstablishmentNames";
            this.Load += new System.EventHandler(this.addEstablishmentNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEstab;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label lblEstabNo;
        public System.Windows.Forms.Label lblEstablishmentHeader;
    }
}