using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showPersonalDatas : Form
    {
        public showPersonalDatas()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addPersonalDatasForm apdf = new addPersonalDatasForm();
            apdf.lblPersonalNo.Text = "0";
            apdf.lblOp.Text = "New personal Information";
            apdf.btn_delete.Visible = false;
            apdf.ShowDialog();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib hl = new hisLib();
            DGVpersonal.DataSource = hl.showPersonalDatas(0).Tables[0];
        }

        private void DGVpersonal_DoubleClick(object sender, EventArgs e)
        {
            string personalNoStr = DGVpersonal.SelectedRows[0].Cells["PersonalNo"].Value.ToString();//MessageBox.Show(drugNoStr);
            addPersonalDatasForm add = new addPersonalDatasForm();
            add.lblPersonalNo.Text = personalNoStr; //drugNoStr > 0 :  update
            add.lblOp.Text = "Update or Delete personal Information";
            add.btn_delete.Visible = true;                
            add.ShowDialog();
        }

        private void showPersonalDatas_Load(object sender, EventArgs e)
        {
           
        }

       
    }
}
