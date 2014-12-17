using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showTitleNamesForm : Form
    {
        public showTitleNamesForm()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib hl = new hisLib();
            DGVtitle.DataSource = hl.showTitleList().Tables[0];
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addTitleName aTN = new addTitleName();
            aTN.lblTitleNo.Text = "0";
            aTN.ShowDialog();
        }

        private void DGVtitle_DoubleClick(object sender, EventArgs e)
        {
            string surveyNoStr = DGVtitle.SelectedRows[0].Cells["TitleNo"].Value.ToString();//MessageBox.Show(drugNoStr);
            addTitleName add = new addTitleName();
            add.lblTitleNo.Text = surveyNoStr; //drugNoStr > 0 :  update
            add.lblTitleHeader.Text = "Update or Delete Title Name";
            add.ShowDialog();
        }




      



       






    }//end class
}//end namespace
