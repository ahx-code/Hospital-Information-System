using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showExaminationDatas : Form
    {
        public showExaminationDatas()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib show = new hisLib();
            DGVex.DataSource = show.showExaminationDatas(0).Tables[0];
            
        }

        private void DGVex_DoubleClick(object sender, EventArgs e)
        {
            string data = DGVex.SelectedRows[0].Cells["ExaminationNo"].Value.ToString();
            addExaminationDatas add = new addExaminationDatas();
            add.lblExNo.Text = data;
            add.lblex.Text = "Update or Delete Information";
            add.btnDel.Visible = true;
            add.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addExaminationDatas apdf = new addExaminationDatas();
            apdf.lblExNo.Text = "0";
            apdf.lblex.Text = "New personal Information";
            apdf.btnDel.Visible = false;
            apdf.ShowDialog();
        }

        private void addDiagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addDiagtoExam adnf = new addDiagtoExam();
            string examNo = DGVex.SelectedRows[0].Cells["ExaminationNo"].Value.ToString();
            adnf.lblExamNo.Text = examNo;
            adnf.ShowDialog();


            DGVex_Click(sender , e);
        }

        private void addRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSurvey2Exam asnf = new addSurvey2Exam();
            string examNo = DGVex.SelectedRows[0].Cells["ExaminationNo"].Value.ToString();
            asnf.lblExamNo.Text = examNo;
            asnf.ShowDialog();


            DGVex_Click(sender, e);
        }

        private void addRecipeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addRecipe2Exam are = new addRecipe2Exam();
            string examNo = DGVex.SelectedRows[0].Cells["ExaminationNo"].Value.ToString();
            are.lblExamNo.Text = examNo;
            are.ShowDialog();


            DGVex_Click(sender, e);

        }

        private void DGVex_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib show = new hisLib();
            string examNo = DGVex.SelectedRows[0].Cells["ExaminationNo"].Value.ToString();
            DGVdiagnosis.DataSource = show.showDiagnosisListByExamNo(Convert.ToInt32(examNo)).Tables[0];
            DGVsurvey.DataSource = show.showSurveyListByExamNo(Convert.ToInt32(examNo)).Tables[0];
            DGVrecipe.DataSource = show.showRecipeDatasByExamNo(Convert.ToInt32(examNo)).Tables[0];

            DGVrecipe_Click(sender, e);

        }

        private void addDrugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addDrug2Recipe are = new addDrug2Recipe();
            string recipeNo = DGVrecipe.SelectedRows[0].Cells["RecipeNo"].Value.ToString();
            are.lblRecipeNo.Text = recipeNo;
            are.ShowDialog();


            DGVrecipe_Click(sender , e);

            
        }

        private void DGVrecipe_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib show = new hisLib();
            string recipeNo = DGVrecipe.SelectedRows[0].Cells["RecipeNo"].Value.ToString();
            DGVdrug.DataSource = show.DrugListByRecipeNo(Convert.ToInt32(recipeNo)).Tables[0];
        }

        private void DGVex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

       

       

      

       
    }
}
