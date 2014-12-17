namespace hbys_winApp
{
    partial class showDrugNamesForm
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
            this.DGVdrug = new System.Windows.Forms.DataGridView();
            this.delete_update = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdrug)).BeginInit();
            this.delete_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(13, 13);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(111, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List All  Drug name";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(382, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(119, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Add New Drug Name";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // DGVdrug
            // 
            this.DGVdrug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVdrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVdrug.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DGVdrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdrug.ContextMenuStrip = this.delete_update;
            this.DGVdrug.Location = new System.Drawing.Point(13, 63);
            this.DGVdrug.Name = "DGVdrug";
            this.DGVdrug.ReadOnly = true;
            this.DGVdrug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVdrug.Size = new System.Drawing.Size(488, 382);
            this.DGVdrug.TabIndex = 2;
            this.DGVdrug.DoubleClick += new System.EventHandler(this.DGVdrug_DoubleClick);
            // 
            // delete_update
            // 
            this.delete_update.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.delete_update.Name = "delete_update";
            this.delete_update.Size = new System.Drawing.Size(151, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update/Delete";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.DGVdrug_DoubleClick);
            // 
            // showDrugNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 494);
            this.Controls.Add(this.DGVdrug);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnNew);
            this.Name = "showDrugNamesForm";
            this.Text = "showDrugNamesForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVdrug)).EndInit();
            this.delete_update.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView DGVdrug;
        private System.Windows.Forms.ContextMenuStrip delete_update;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;

    }
}