using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }//end if


            examinationToolStripMenuItem_Click(sender , e);
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPatientDatasForm pLF = new showPatientDatasForm();
            pLF.MdiParent = this;
            pLF.Show();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showServiceNamesForm sLF = new showServiceNamesForm();
            sLF.MdiParent = this;
            sLF.Show();
        }

         private void drugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDrugNamesForm sDNF = new showDrugNamesForm();
            sDNF.MdiParent = this;
            sDNF.Show();
        }

         private void surveyAltDToolStripMenuItem_Click(object sender, EventArgs e)
         {
             showSurveyNamesForm sSNF = new showSurveyNamesForm();
             sSNF.MdiParent = this;
             sSNF.Show();
         }

         private void diagnosisAltIToolStripMenuItem_Click(object sender, EventArgs e)
         {
             showDiagnosisNamesForm sDNF = new showDiagnosisNamesForm();
             sDNF.MdiParent = this;
             sDNF.Show();
         }

         private void establishmentToolStripMenuItem_Click(object sender, EventArgs e)
         {
             showEstablishmentNamesForm sENF = new showEstablishmentNamesForm();
             sENF.MdiParent = this;
             sENF.Show();
         }

         private void titleToolStripMenuItem_Click(object sender, EventArgs e)
         {
             showTitleNamesForm sTNF = new showTitleNamesForm();
             sTNF.MdiParent = this;
             sTNF.Show();
         }

         private void personalToolStripMenuItem_Click(object sender, EventArgs e)
         {
             showPersonalDatas sPD = new showPersonalDatas();
             sPD.MdiParent = this;
             sPD.Show();
         }

         private void examinationToolStripMenuItem_Click(object sender, EventArgs e)
         {
             showExaminationDatas sED = new showExaminationDatas();
             sED.MdiParent = this;
             sED.Show();
         }

         private void sendingToolStripMenuItem_Click(object sender, EventArgs e)
         {
             showSendingDatas showSendingDatas = new showSendingDatas();
             showSendingDatas.MdiParent = this;
             showSendingDatas.Show();
         }

         private void examDiagToolStripMenuItem_Click(object sender, EventArgs e)
         {
             showExamDiagDatas sEDD = new showExamDiagDatas();
             sEDD.MdiParent = this;
             sEDD.Show();
         }

         private void recipeToolStripMenuItem_Click(object sender, EventArgs e)
         {
             showRecipeDatas sRD = new showRecipeDatas();
             sRD.MdiParent = this;
             sRD.Show();
         }

      
         
    }
}
