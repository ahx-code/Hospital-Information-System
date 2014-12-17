using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addRecipe2Exam : Form
    {
        public addRecipe2Exam()
        {
            InitializeComponent();
        }

        private void addRecipe2Exam_Load(object sender, EventArgs e)
        {
            dtRecipeDate.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ExamNo = Convert.ToInt32(lblExamNo.Text);
            hbys_winApp.hisLib hl = new hisLib();
            string res = "";
            res = hl.addRecipeDatas(0 , dtRecipeDate.Value , ExamNo);
            if (res == "1")
                MessageBox.Show("added");
            else
                MessageBox.Show("not added");
        }
    }
}
