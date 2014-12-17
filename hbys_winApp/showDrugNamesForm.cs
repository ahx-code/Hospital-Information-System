using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showDrugNamesForm : Form
    {
        public showDrugNamesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib hospital_drug_name = new hisLib();
            DGVdrug.DataSource = hospital_drug_name.DrugList().Tables[0];
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            addDrugNamesForm add = new addDrugNamesForm();
            add.lblDrugNo.Text = "0"; //0 insert
            add.ShowDialog();
        }

        private void DGVdrug_DoubleClick(object sender, EventArgs e)
        {
            string drugNoStr = DGVdrug.SelectedRows[0].Cells["DrugNo"].Value.ToString();//MessageBox.Show(drugNoStr);
            addDrugNamesForm add = new addDrugNamesForm();
            add.lblDrugNo.Text = drugNoStr; //drugNoStr > 0 :  update
            add.ShowDialog();
        }

                
    }
}
