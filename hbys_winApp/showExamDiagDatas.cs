using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showExamDiagDatas : Form
    {
        public showExamDiagDatas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib examDiag = new hisLib();
            DGVexamDiag.DataSource = examDiag.showExamDiagDatas(0).Tables[0];
        }
    }
}
