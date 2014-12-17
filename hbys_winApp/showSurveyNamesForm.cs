using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showSurveyNamesForm : Form
    {
        public showSurveyNamesForm()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {

            hbys_winApp.hisLib hl = new hisLib();
            DGVsurvey.DataSource = hl.showSurveyList().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            addSurveyNames aSN = new addSurveyNames();
            aSN.lblSurveyNo.Text = "0";
            aSN.ShowDialog();




        }

        private void DGVsurvey_DoubleClick(object sender, EventArgs e)
        {

            string surveyNoStr = DGVsurvey.SelectedRows[0].Cells["SurveyNo"].Value.ToString();//MessageBox.Show(drugNoStr);
            addSurveyNames add = new addSurveyNames();
            add.lblSurveyNo.Text = surveyNoStr; //drugNoStr > 0 :  update
            add.ShowDialog();
        }

       
      
    }
}
