namespace hbys_winApp
{
    partial class showRecipeDatas
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
            this.listRecipe = new System.Windows.Forms.Button();
            this.DGVrecipe = new System.Windows.Forms.DataGridView();
            this.addRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVrecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // listRecipe
            // 
            this.listRecipe.Location = new System.Drawing.Point(13, 13);
            this.listRecipe.Name = "listRecipe";
            this.listRecipe.Size = new System.Drawing.Size(115, 23);
            this.listRecipe.TabIndex = 0;
            this.listRecipe.Text = "List All Recipe Datas";
            this.listRecipe.UseVisualStyleBackColor = true;
            this.listRecipe.Click += new System.EventHandler(this.listRecipe_Click);
            // 
            // DGVrecipe
            // 
            this.DGVrecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVrecipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVrecipe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGVrecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVrecipe.Location = new System.Drawing.Point(13, 53);
            this.DGVrecipe.Name = "DGVrecipe";
            this.DGVrecipe.ReadOnly = true;
            this.DGVrecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVrecipe.Size = new System.Drawing.Size(708, 365);
            this.DGVrecipe.TabIndex = 1;
            // 
            // addRecipe
            // 
            this.addRecipe.Location = new System.Drawing.Point(585, 13);
            this.addRecipe.Name = "addRecipe";
            this.addRecipe.Size = new System.Drawing.Size(136, 23);
            this.addRecipe.TabIndex = 2;
            this.addRecipe.Text = "Add New Recipe Value";
            this.addRecipe.UseVisualStyleBackColor = true;
            this.addRecipe.Click += new System.EventHandler(this.addRecipe_Click);
            // 
            // showRecipeDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 430);
            this.Controls.Add(this.addRecipe);
            this.Controls.Add(this.DGVrecipe);
            this.Controls.Add(this.listRecipe);
            this.Name = "showRecipeDatas";
            this.Text = "showRecipeDatas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVrecipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listRecipe;
        private System.Windows.Forms.DataGridView DGVrecipe;
        private System.Windows.Forms.Button addRecipe;
    }
}