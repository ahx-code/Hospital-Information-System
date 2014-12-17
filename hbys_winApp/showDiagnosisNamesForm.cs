using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showDiagnosisNamesForm : Form
    {
        public showDiagnosisNamesForm()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib diagName = new hisLib();
            DGVdiagnosis.DataSource = diagName.showDiagnosisList().Tables[0]; 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addDiagnosisNamesForm aDNF = new addDiagnosisNamesForm();
            aDNF.lblDiagNo.Text = "0";
            aDNF.ShowDialog();
        }

        private void DGVdiagnosis_DoubleClick(object sender, EventArgs e)
        {
            string diagnosisNo = DGVdiagnosis.SelectedRows[0].Cells["Diagnosis No"].Value.ToString();//MessageBox.Show(drugNoStr);
            addDiagnosisNamesForm aDNF = new addDiagnosisNamesForm();
            aDNF.lblDiagnosisHeader.Text = "Update or Delete Diagnosis Name";
            aDNF.lblDiagNo.Text = diagnosisNo;
            aDNF.ShowDialog();
        }

       

       

      
  

      
      
       

       
    }
}
