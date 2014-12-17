using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showRecipeDatas : Form
    {
        public showRecipeDatas()
        {
            InitializeComponent();
        }

        private void listRecipe_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib recipe = new hisLib();
            DGVrecipe.DataSource = recipe.showRecipeDatas(0).Tables[0];
        }

        private void addRecipe_Click(object sender, EventArgs e)
        {
            addRecipeDatasForm aRPD = new addRecipeDatasForm();
            aRPD.lblRecipeNo.Text = "0";
            aRPD.ShowDialog();
        }
    }
}
