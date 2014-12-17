namespace hbys_winApp
{
    partial class showDiagnosisNamesForm
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
            this.DGVdiagnosis = new System.Windows.Forms.DataGridView();
            this.update_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updatedeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdiagnosis)).BeginInit();
            this.update_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(132, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List All Diagnosis Name";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(390, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Add New Diagnosis Name";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // DGVdiagnosis
            // 
            this.DGVdiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVdiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVdiagnosis.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DGVdiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdiagnosis.ContextMenuStrip = this.update_delete;
            this.DGVdiagnosis.Location = new System.Drawing.Point(13, 72);
            this.DGVdiagnosis.Name = "DGVdiagnosis";
            this.DGVdiagnosis.ReadOnly = true;
            this.DGVdiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVdiagnosis.Size = new System.Drawing.Size(520, 434);
            this.DGVdiagnosis.TabIndex = 2;
            this.DGVdiagnosis.DoubleClick += new System.EventHandler(this.DGVdiagnosis_DoubleClick);
            // 
            // update_delete
            // 
            this.update_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatedeleteToolStripMenuItem});
            this.update_delete.Name = "update_delete";
            this.update_delete.Size = new System.Drawing.Size(153, 48);
            this.update_delete.DoubleClick += new System.EventHandler(this.DGVdiagnosis_DoubleClick);
            // 
            // updatedeleteToolStripMenuItem
            // 
            this.updatedeleteToolStripMenuItem.Name = "updatedeleteToolStripMenuItem";
            this.updatedeleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updatedeleteToolStripMenuItem.Text = "update/delete";
            this.updatedeleteToolStripMenuItem.Click += new System.EventHandler(this.DGVdiagnosis_DoubleClick);
            // 
            // showDiagnosisNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 519);
            this.Controls.Add(this.DGVdiagnosis);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnList);
            this.Name = "showDiagnosisNamesForm";
            this.Text = "showDiagnosisNamesForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVdiagnosis)).EndInit();
            this.update_delete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView DGVdiagnosis;
        private System.Windows.Forms.ContextMenuStrip update_delete;
        private System.Windows.Forms.ToolStripMenuItem updatedeleteToolStripMenuItem;
    }
}