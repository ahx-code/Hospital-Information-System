using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showServiceNamesForm : Form
    {
        public showServiceNamesForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            addServiceNameForm aSNF = new addServiceNameForm();
            aSNF.lblServiceNo.Text = "0";
            aSNF.ShowDialog();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib showServiceList = new hisLib();
            DGVservice.DataSource = showServiceList.showServiceNames().Tables[0];
        }

        private void DGVservice_DoubleClick(object sender, EventArgs e)
        {
            string serviceNoStr = DGVservice.SelectedRows[0].Cells["ServiceNo"].Value.ToString();//MessageBox.Show(drugNoStr);
            addServiceNameForm aSNF = new addServiceNameForm();
            aSNF.lblServiceNo.Text = serviceNoStr;
            aSNF.lblHeader.Text = "Update or Delete Service Name";
            aSNF.ShowDialog();
        }

        private void DGVservice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
