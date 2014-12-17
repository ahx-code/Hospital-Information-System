namespace hbys_winApp
{
    partial class showSurveyNamesForm
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
            this.components = new System.ComponentModel.Container();
            this.btnList = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.DGVsurvey = new System.Windows.Forms.DataGridView();
            this.update_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updatedeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsurvey)).BeginInit();
            this.update_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(13, 13);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(128, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List All Survey Names";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(315, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(133, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Add New Survey Name";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // DGVsurvey
            // 
            this.DGVsurvey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVsurvey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVsurvey.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DGVsurvey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVsurvey.ContextMenuStrip = this.update_delete;
            this.DGVsurvey.Location = new System.Drawing.Point(13, 63);
            this.DGVsurvey.Name = "DGVsurvey";
            this.DGVsurvey.ReadOnly = true;
            this.DGVsurvey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVsurvey.Size = new System.Drawing.Size(435, 319);
            this.DGVsurvey.TabIndex = 2;
            this.DGVsurvey.DoubleClick += new System.EventHandler(this.DGVsurvey_DoubleClick);
            // 
            // update_delete
            // 
            this.update_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatedeleteToolStripMenuItem});
            this.update_delete.Name = "update_delete";
            this.update_delete.Size = new System.Drawing.Size(153, 48);
            // 
            // updatedeleteToolStripMenuItem
            // 
            this.updatedeleteToolStripMenuItem.Name = "updatedeleteToolStripMenuItem";
            this.updatedeleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updatedeleteToolStripMenuItem.Text = "update\\delete";
            this.updatedeleteToolStripMenuItem.Click += new System.EventHandler(this.DGVsurvey_DoubleClick);
            // 
            // showSurveyNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 431);
            this.Controls.Add(this.DGVsurvey);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnNew);
            this.Name = "showSurveyNamesForm";
            this.Text = "ShowSurveyNamesForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVsurvey)).EndInit();
            this.update_delete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView DGVsurvey;
        private System.Windows.Forms.ContextMenuStrip update_delete;
        private System.Windows.Forms.ToolStripMenuItem updatedeleteToolStripMenuItem;
    }
}