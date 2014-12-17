using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addSurvey2Exam : Form
    {
        public addSurvey2Exam()
        {
            InitializeComponent();
        }

        private void addSurvey2Exam_Load(object sender, EventArgs e)
        {
             DataSet surveyDataSet = new DataSet();
            hbys_winApp.hisLib surveyHisLib = new hisLib();
            surveyDataSet = surveyHisLib.showSurveyList();
            comboSurvey.Items.Clear();
            for (int i = 0; i < surveyDataSet.Tables[0].Rows.Count; i++)
            {
                titleBoxItem surveyBoxItem = new titleBoxItem();
                surveyBoxItem.Txt = surveyDataSet.Tables[0].Rows[i]["SurveyName"].ToString();
                surveyBoxItem.Val = surveyDataSet.Tables[0].Rows[i]["SurveyNo"].ToString();
                comboSurvey.Items.Add(surveyBoxItem);
            } 
            
            if (comboSurvey.Items.Count > 0)
                comboSurvey.SelectedIndex = 0;
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int SurveyNo = Convert.ToInt32(((titleBoxItem)comboSurvey.SelectedItem).Val);
            int ExamNo = Convert.ToInt32(lblExamNo.Text);
            hbys_winApp.hisLib hl = new hisLib();
            string res = hl.addExamSurveyDatas(0, ExamNo, SurveyNo);
            if (res == "1")
                MessageBox.Show("Successfully Added","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("An error has occured","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

    }
}
