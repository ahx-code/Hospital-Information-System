namespace hbys_winApp
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveyAltDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosisAltIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.establishmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examDiagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.drugsToolStripMenuItem,
            this.surveyAltDToolStripMenuItem,
            this.diagnosisAltIToolStripMenuItem,
            this.titleToolStripMenuItem,
            this.establishmentToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.examinationToolStripMenuItem,
            this.sendingToolStripMenuItem,
            this.examDiagToolStripMenuItem,
            this.recipeToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // drugsToolStripMenuItem
            // 
            this.drugsToolStripMenuItem.Name = "drugsToolStripMenuItem";
            this.drugsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.drugsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.drugsToolStripMenuItem.Text = "Drugs";
            this.drugsToolStripMenuItem.Click += new System.EventHandler(this.drugsToolStripMenuItem_Click);
            // 
            // surveyAltDToolStripMenuItem
            // 
            this.surveyAltDToolStripMenuItem.Name = "surveyAltDToolStripMenuItem";
            this.surveyAltDToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.surveyAltDToolStripMenuItem.Text = "Survey    ";
            this.surveyAltDToolStripMenuItem.Click += new System.EventHandler(this.surveyAltDToolStripMenuItem_Click);
            // 
            // diagnosisAltIToolStripMenuItem
            // 
            this.diagnosisAltIToolStripMenuItem.Name = "diagnosisAltIToolStripMenuItem";
            this.diagnosisAltIToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.diagnosisAltIToolStripMenuItem.Text = "Diagnosis ";
            this.diagnosisAltIToolStripMenuItem.Click += new System.EventHandler(this.diagnosisAltIToolStripMenuItem_Click);
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.titleToolStripMenuItem.Text = "Title";
            this.titleToolStripMenuItem.Click += new System.EventHandler(this.titleToolStripMenuItem_Click);
            // 
            // establishmentToolStripMenuItem
            // 
            this.establishmentToolStripMenuItem.Name = "establishmentToolStripMenuItem";
            this.establishmentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.establishmentToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.establishmentToolStripMenuItem.Text = "Establishment";
            this.establishmentToolStripMenuItem.Click += new System.EventHandler(this.establishmentToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // examinationToolStripMenuItem
            // 
            this.examinationToolStripMenuItem.Name = "examinationToolStripMenuItem";
            this.examinationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.examinationToolStripMenuItem.Text = "Examination";
            this.examinationToolStripMenuItem.Click += new System.EventHandler(this.examinationToolStripMenuItem_Click);
            // 
            // sendingToolStripMenuItem
            // 
            this.sendingToolStripMenuItem.Name = "sendingToolStripMenuItem";
            this.sendingToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sendingToolStripMenuItem.Text = "Sending";
            this.sendingToolStripMenuItem.Click += new System.EventHandler(this.sendingToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // patientReportsToolStripMenuItem
            // 
            this.patientReportsToolStripMenuItem.Name = "patientReportsToolStripMenuItem";
            this.patientReportsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.patientReportsToolStripMenuItem.Text = "Patient Reports";
            // 
            // examDiagToolStripMenuItem
            // 
            this.examDiagToolStripMenuItem.Name = "examDiagToolStripMenuItem";
            this.examDiagToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.examDiagToolStripMenuItem.Text = "ExamDiag";
            this.examDiagToolStripMenuItem.Click += new System.EventHandler(this.examDiagToolStripMenuItem_Click);
            // 
            // recipeToolStripMenuItem
            // 
            this.recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            this.recipeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.recipeToolStripMenuItem.Text = "Recipe";
            this.recipeToolStripMenuItem.Click += new System.EventHandler(this.recipeToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 525);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Hospital Information System";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surveyAltDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosisAltIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem establishmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examDiagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeToolStripMenuItem;
    }
}

