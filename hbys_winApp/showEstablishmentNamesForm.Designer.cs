namespace hbys_winApp
{
    partial class showEstablishmentNamesForm
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
            this.DGVestablishment = new System.Windows.Forms.DataGridView();
            this.update_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updatedeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVestablishment)).BeginInit();
            this.update_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(13, 13);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(165, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List All Establishment Names";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(293, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(171, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Add New Establishment Names";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // DGVestablishment
            // 
            this.DGVestablishment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVestablishment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVestablishment.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DGVestablishment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVestablishment.ContextMenuStrip = this.update_delete;
            this.DGVestablishment.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.DGVestablishment.Location = new System.Drawing.Point(12, 59);
            this.DGVestablishment.Name = "DGVestablishment";
            this.DGVestablishment.ReadOnly = true;
            this.DGVestablishment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVestablishment.Size = new System.Drawing.Size(452, 323);
            this.DGVestablishment.TabIndex = 2;
            this.DGVestablishment.DoubleClick += new System.EventHandler(this.DGVestablishment_DoubleClick);
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
            this.updatedeleteToolStripMenuItem.Click += new System.EventHandler(this.DGVestablishment_DoubleClick);
            // 
            // showEstablishmentNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 404);
            this.Controls.Add(this.DGVestablishment);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnNew);
            this.Name = "showEstablishmentNamesForm";
            this.Text = "showEstablishmentNamesForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVestablishment)).EndInit();
            this.update_delete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView DGVestablishment;
        private System.Windows.Forms.ContextMenuStrip update_delete;
        private System.Windows.Forms.ToolStripMenuItem updatedeleteToolStripMenuItem;
    }
}