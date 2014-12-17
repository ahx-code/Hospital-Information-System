using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class showEstablishmentNamesForm : Form
    {
        public showEstablishmentNamesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib show_all_estab = new hisLib();
            DGVestablishment.DataSource = show_all_estab.showEstablishment().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addEstablishmentNames aEN = new addEstablishmentNames();
            aEN.lblEstabNo.Text = "0";
            aEN.ShowDialog(); 
        }

        private void DGVestablishment_DoubleClick(object sender, EventArgs e)
        {
            string establishmentNoStr = DGVestablishment.SelectedRows[0].Cells["EstablishmentNo"].Value.ToString();//MessageBox.Show(drugNoStr);
            addEstablishmentNames add = new addEstablishmentNames();
            add.lblEstabNo.Text = establishmentNoStr; //drugNoStr > 0 :  update
            add.lblEstablishmentHeader.Text = "Update or Delete Establishment Name";
            add.ShowDialog();
        }
    }
}
