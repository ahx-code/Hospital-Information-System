namespace hbys_winApp
{
    partial class showSendingDatas
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
            this.listAllSendingDatas = new System.Windows.Forms.Button();
            this.DGVsending = new System.Windows.Forms.DataGridView();
            this.addSendingData = new System.Windows.Forms.Button();
            this.UPDATE_DELETE = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updatedeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsending)).BeginInit();
            this.UPDATE_DELETE.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAllSendingDatas
            // 
            this.listAllSendingDatas.Location = new System.Drawing.Point(13, 13);
            this.listAllSendingDatas.Name = "listAllSendingDatas";
            this.listAllSendingDatas.Size = new System.Drawing.Size(131, 23);
            this.listAllSendingDatas.TabIndex = 0;
            this.listAllSendingDatas.Text = "List All Sending Datas";
            this.listAllSendingDatas.UseVisualStyleBackColor = true;
            this.listAllSendingDatas.Click += new System.EventHandler(this.listAllSendingDatas_Click);
            // 
            // DGVsending
            // 
            this.DGVsending.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVsending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVsending.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVsending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVsending.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DGVsending.Location = new System.Drawing.Point(13, 58);
            this.DGVsending.Name = "DGVsending";
            this.DGVsending.ReadOnly = true;
            this.DGVsending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVsending.Size = new System.Drawing.Size(784, 370);
            this.DGVsending.TabIndex = 1;
            this.DGVsending.DoubleClick += new System.EventHandler(this.DGVsending_DoubleClick);
            // 
            // addSendingData
            // 
            this.addSendingData.Location = new System.Drawing.Point(669, 12);
            this.addSendingData.Name = "addSendingData";
            this.addSendingData.Size = new System.Drawing.Size(128, 23);
            this.addSendingData.TabIndex = 2;
            this.addSendingData.Text = "Add Sending Data";
            this.addSendingData.UseVisualStyleBackColor = true;
            this.addSendingData.Click += new System.EventHandler(this.addSendingData_Click);
            // 
            // UPDATE_DELETE
            // 
            this.UPDATE_DELETE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatedeleteToolStripMenuItem});
            this.UPDATE_DELETE.Name = "UPDATE_DELETE";
            this.UPDATE_DELETE.Size = new System.Drawing.Size(149, 26);
            // 
            // updatedeleteToolStripMenuItem
            // 
            this.updatedeleteToolStripMenuItem.Name = "updatedeleteToolStripMenuItem";
            this.updatedeleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.updatedeleteToolStripMenuItem.Text = "update/delete";
            // 
            // showSendingDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 440);
            this.Controls.Add(this.addSendingData);
            this.Controls.Add(this.DGVsending);
            this.Controls.Add(this.listAllSendingDatas);
            this.Name = "showSendingDatas";
            this.Text = "showSendingDatas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVsending)).EndInit();
            this.UPDATE_DELETE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listAllSendingDatas;
        private System.Windows.Forms.DataGridView DGVsending;
        private System.Windows.Forms.Button addSendingData;
        private System.Windows.Forms.ContextMenuStrip UPDATE_DELETE;
        private System.Windows.Forms.ToolStripMenuItem updatedeleteToolStripMenuItem;
    }
}