using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addDiagtoExam : Form
    {
        public addDiagtoExam()
        {
            InitializeComponent();
        }

        private void addDiagtoExam_Load(object sender, EventArgs e)
        {
            DataSet diagDataSet = new DataSet();
            hbys_winApp.hisLib diagHisLib = new hisLib();
            diagDataSet = diagHisLib.showDiagnosisList();
            comboDiag.Items.Clear();
            for (int i = 0; i < diagDataSet.Tables[0].Rows.Count; i++)
            {
                titleBoxItem diagBoxItem = new titleBoxItem();
                diagBoxItem.Txt = diagDataSet.Tables[0].Rows[i]["Diagnosis Name"].ToString();
                diagBoxItem.Val = diagDataSet.Tables[0].Rows[i]["Diagnosis No"].ToString();
                comboDiag.Items.Add(diagBoxItem);
            } 
            
            if (comboDiag.Items.Count > 0)
                comboDiag.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int DiagNo = Convert.ToInt32(((titleBoxItem)comboDiag.SelectedItem).Val);
            int ExamNo = Convert.ToInt32(lblExamNo.Text);
            hbys_winApp.hisLib hl = new hisLib();
            string res = hl.addExamDiagDatas(0,ExamNo,DiagNo);
            if (res == "1")
                MessageBox.Show("Successfully Added","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);

            else
                MessageBox.Show("An error has occured :" +res,"Sorry",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

      

        
    }
}
