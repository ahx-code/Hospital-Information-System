using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showPatientDatasForm : Form
    {
        public showPatientDatasForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addPatientDatasForm paf = new addPatientDatasForm();
            paf.lblPatientNo.Text = "0";
            paf.ShowDialog();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib hL = new hisLib();
            DGVpatient.DataSource = hL.patientList().Tables[0];
           
        }

      

        private void DGVpatient_DoubleClick(object sender, EventArgs e)
        {
            string patientNoStr = DGVpatient.SelectedRows[0].Cells["PatientNo"].Value.ToString();//MessageBox.Show(drugNoStr);
            addPatientDatasForm add = new addPatientDatasForm();
            add.lblPatientNo.Text = patientNoStr; //drugNoStr > 0 :  update
            add.ShowDialog();
        }

        
       

     
    }
}
