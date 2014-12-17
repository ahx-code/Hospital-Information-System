using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addDrug2Recipe : Form
    {
        public addDrug2Recipe()
        {
            InitializeComponent();
        }

        private void addDrug2Recipe_Load(object sender, EventArgs e)
        {

            DataSet drugDataSet = new DataSet();
            hbys_winApp.hisLib drugHisLib = new hisLib();
            drugDataSet = drugHisLib.DrugList();
            comboDrug.Items.Clear();
            for (int i = 0; i < drugDataSet.Tables[0].Rows.Count; i++)
            {
                titleBoxItem drugBoxItem = new titleBoxItem();
                drugBoxItem.Txt = drugDataSet.Tables[0].Rows[i]["DrugName"].ToString();
                drugBoxItem.Val = drugDataSet.Tables[0].Rows[i]["DrugNo"].ToString();
                comboDrug.Items.Add(drugBoxItem);
            }

            if (comboDrug.Items.Count > 0)
                comboDrug.SelectedIndex = 0;
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int drugNo = Convert.ToInt32(((titleBoxItem)comboDrug.SelectedItem).Val);
            int recipeNo = Convert.ToInt32(lblRecipeNo.Text);
            hbys_winApp.hisLib hl = new hisLib();
            string res = hl.addDrug2Recipe(recipeNo, drugNo);
            if (res == "1")
                MessageBox.Show("Successfully Added","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("An error has occured","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
