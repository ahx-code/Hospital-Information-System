using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addRecipeDatasForm : Form
    {
        public addRecipeDatasForm()
        {
            InitializeComponent();
        }

        private void addRecipeDatasForm_Load(object sender, EventArgs e)
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
            } if (comboDrug.Items.Count > 0)
                comboDrug.SelectedItem = 0;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib objectHisLib = new hisLib();
            int drugNo = Convert.ToInt32(((titleBoxItem)comboDrug.SelectedItem).Val);
            DateTime date = dateTime.Value;
            
            string res = objectHisLib.addRecipeDatas(Int32.Parse(lblRecipeNo.Text) , date , drugNo );
            if (res == "1")
                MessageBox.Show("Succesfully Added", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An error has occured:" + res,"Sorry",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
