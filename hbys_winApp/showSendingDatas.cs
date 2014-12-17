using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showSendingDatas : Form
    {
        public showSendingDatas()
        {
            InitializeComponent();
        }

        private void listAllSendingDatas_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib showSendingDatas = new hisLib();
            DGVsending.DataSource = showSendingDatas.showSendingDatas(0).Tables[0];
        }

        private void addSendingData_Click(object sender, EventArgs e)
        {
            addSendingForm objectSendingForm = new addSendingForm();
            objectSendingForm.lblSendingNo.Text = "0";
            objectSendingForm.lblSendingHeader.Text = "Add Sending Data";
            objectSendingForm.btnSave.Text = "Save";
            objectSendingForm.ShowDialog();
        }

        private void DGVsending_DoubleClick(object sender, EventArgs e)
        {
            string getDatafromDGV = DGVsending.SelectedRows[0].Cells["SendingNo"].ToString();
            addSendingForm aSD = new addSendingForm();
            aSD.lblSendingNo.Text = getDatafromDGV;
            aSD.lblSendingHeader.Text = "Update or Delete Datas";
            aSD.btnSave.Text = "Update";
            aSD.ShowDialog();
        }

        

       
       

        
    }
}
