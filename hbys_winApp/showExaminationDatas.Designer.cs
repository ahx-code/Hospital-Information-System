namespace hbys_winApp
{
    partial class showExaminationDatas
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.DGVex = new System.Windows.Forms.DataGridView();
            this.update_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updatedeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDiagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVdiagnosis = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.DGVsurvey = new System.Windows.Forms.DataGridView();
            this.DGVrecipe = new System.Windows.Forms.DataGridView();
            this.recipe_update_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDrugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVdrug = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVex)).BeginInit();
            this.update_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsurvey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVrecipe)).BeginInit();
            this.recipe_update_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdrug)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(13, 13);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(146, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List All Examination Datas";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(828, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New Examination Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DGVex
            // 
            this.DGVex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVex.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVex.ContextMenuStrip = this.update_delete;
            this.DGVex.Location = new System.Drawing.Point(13, 56);
            this.DGVex.Name = "DGVex";
            this.DGVex.ReadOnly = true;
            this.DGVex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVex.Size = new System.Drawing.Size(1034, 254);
            this.DGVex.TabIndex = 2;
            this.DGVex.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVex_CellContentClick);
            this.DGVex.Click += new System.EventHandler(this.DGVex_Click);
            this.DGVex.DoubleClick += new System.EventHandler(this.DGVex_DoubleClick);
            // 
            // update_delete
            // 
            this.update_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatedeleteToolStripMenuItem,
            this.addDiagToolStripMenuItem,
            this.addRecipeToolStripMenuItem,
            this.addRecipeToolStripMenuItem1});
            this.update_delete.Name = "contextMenuStrip1";
            this.update_delete.Size = new System.Drawing.Size(149, 92);
            // 
            // updatedeleteToolStripMenuItem
            // 
            this.updatedeleteToolStripMenuItem.Name = "updatedeleteToolStripMenuItem";
            this.updatedeleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.updatedeleteToolStripMenuItem.Text = "update/delete";
            this.updatedeleteToolStripMenuItem.Click += new System.EventHandler(this.DGVex_DoubleClick);
            // 
            // addDiagToolStripMenuItem
            // 
            this.addDiagToolStripMenuItem.Name = "addDiagToolStripMenuItem";
            this.addDiagToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addDiagToolStripMenuItem.Text = "add Diagnosis";
            this.addDiagToolStripMenuItem.Click += new System.EventHandler(this.addDiagToolStripMenuItem_Click);
            // 
            // addRecipeToolStripMenuItem
            // 
            this.addRecipeToolStripMenuItem.Name = "addRecipeToolStripMenuItem";
            this.addRecipeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addRecipeToolStripMenuItem.Text = "add Survey";
            this.addRecipeToolStripMenuItem.Click += new System.EventHandler(this.addRecipeToolStripMenuItem_Click);
            // 
            // addRecipeToolStripMenuItem1
            // 
            this.addRecipeToolStripMenuItem1.Name = "addRecipeToolStripMenuItem1";
            this.addRecipeToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.addRecipeToolStripMenuItem1.Text = "add Recipe";
            this.addRecipeToolStripMenuItem1.Click += new System.EventHandler(this.addRecipeToolStripMenuItem1_Click);
            // 
            // DGVdiagnosis
            // 
            this.DGVdiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVdiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVdiagnosis.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVdiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdiagnosis.Location = new System.Drawing.Point(12, 329);
            this.DGVdiagnosis.Name = "DGVdiagnosis";
            this.DGVdiagnosis.ReadOnly = true;
            this.DGVdiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVdiagnosis.Size = new System.Drawing.Size(293, 285);
            this.DGVdiagnosis.TabIndex = 3;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 313);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Diagnosis";
            // 
            // DGVsurvey
            // 
            this.DGVsurvey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVsurvey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVsurvey.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVsurvey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVsurvey.Location = new System.Drawing.Point(311, 329);
            this.DGVsurvey.Name = "DGVsurvey";
            this.DGVsurvey.ReadOnly = true;
            this.DGVsurvey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVsurvey.Size = new System.Drawing.Size(312, 285);
            this.DGVsurvey.TabIndex = 5;
            // 
            // DGVrecipe
            // 
            this.DGVrecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVrecipe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVrecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVrecipe.ContextMenuStrip = this.recipe_update_delete;
            this.DGVrecipe.Location = new System.Drawing.Point(629, 329);
            this.DGVrecipe.Name = "DGVrecipe";
            this.DGVrecipe.ReadOnly = true;
            this.DGVrecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVrecipe.Size = new System.Drawing.Size(418, 117);
            this.DGVrecipe.TabIndex = 6;
            this.DGVrecipe.Click += new System.EventHandler(this.DGVrecipe_Click);
            // 
            // recipe_update_delete
            // 
            this.recipe_update_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDrugToolStripMenuItem});
            this.recipe_update_delete.Name = "recipe_update_delete";
            this.recipe_update_delete.Size = new System.Drawing.Size(126, 26);
            // 
            // addDrugToolStripMenuItem
            // 
            this.addDrugToolStripMenuItem.Name = "addDrugToolStripMenuItem";
            this.addDrugToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addDrugToolStripMenuItem.Text = "Add Drug";
            this.addDrugToolStripMenuItem.Click += new System.EventHandler(this.addDrugToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Survey";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(758, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Recipe";
            // 
            // DGVdrug
            // 
            this.DGVdrug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVdrug.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVdrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdrug.Location = new System.Drawing.Point(630, 452);
            this.DGVdrug.Name = "DGVdrug";
            this.DGVdrug.Size = new System.Drawing.Size(417, 161);
            this.DGVdrug.TabIndex = 9;
            // 
            // showExaminationDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 626);
            this.Controls.Add(this.DGVrecipe);
            this.Controls.Add(this.DGVdrug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVsurvey);
            this.Controls.Add(this.DGVex);
            this.Controls.Add(this.label);
            this.Controls.Add(this.DGVdiagnosis);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnAdd);
            this.Name = "showExaminationDatas";
            this.Text = "showExaminationDatas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVex)).EndInit();
            this.update_delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsurvey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVrecipe)).EndInit();
            this.recipe_update_delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdrug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView DGVex;
        private System.Windows.Forms.ContextMenuStrip update_delete;
        private System.Windows.Forms.ToolStripMenuItem updatedeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDiagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGVdiagnosis;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView DGVsurvey;
        private System.Windows.Forms.DataGridView DGVrecipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem1;
        private System.Windows.Forms.DataGridView DGVdrug;
        private System.Windows.Forms.ContextMenuStrip recipe_update_delete;
        private System.Windows.Forms.ToolStripMenuItem addDrugToolStripMenuItem;
    }
}