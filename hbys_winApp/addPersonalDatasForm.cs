using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addPersonalDatasForm : Form
    {
        public addPersonalDatasForm()
        {
            InitializeComponent();
        }

        private void addPersonalDatasForm_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            hbys_winApp.hisLib myObj = new hisLib();
            ds = myObj.showTitleList();
            cbTitle.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                titleBoxItem mbi = new titleBoxItem();
                mbi.Txt = ds.Tables[0].Rows[i]["TitleName"].ToString();
                mbi.Val = ds.Tables[0].Rows[i]["TitleNo"].ToString();
                cbTitle.Items.Add(mbi);
            }
            if(cbTitle.Items.Count>0)
            cbTitle.SelectedIndex = 0;

            ///////////////////////////////////////////////////////////////
            ds = myObj.showPersonalDatas(Int32.Parse(lblPersonalNo.Text));
            tbFName.Text = ds.Tables[0].Rows[0]["Fname"].ToString();
            tbLName.Text = ds.Tables[0].Rows[0]["Sname"].ToString();
            string titleNo = ds.Tables[0].Rows[0]["TitleNo"].ToString();

            for (int i = 0; i < cbTitle.Items.Count; i++)
            {
                if (((titleBoxItem)cbTitle.Items[i]).Val == titleNo)
                {
                    cbTitle.SelectedIndex = i;
                    break;
                }
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            titleBoxItem tbi = (titleBoxItem)cbTitle.SelectedItem;

            //MessageBox.Show(tbi.Txt + " " + tbi.Val);

            hbys_winApp.hisLib hl = new hisLib();
            
            string res;
            if (lblPersonalNo.Text == "0")
                res = hl.addPersonalDatas(tbFName.Text, tbLName.Text, Int32.Parse(tbi.Val)); //val seçmiş oldupum titleın idsi anlamına geliyor.
            else
                res = hl.updatePersonalDatas(tbFName.Text, tbLName.Text, Int32.Parse(tbi.Val),Int32.Parse(lblPersonalNo.Text));
              
            
             if (res == "1")
                MessageBox.Show("Successfully Saved", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sorry an error has occured" + res , "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib objectHisLib = new hisLib();
            string result = objectHisLib.deletePersonal(Int32.Parse(lblPersonalNo.Text));
            if (result == "1")
                MessageBox.Show("Successfully Deleted", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An error has occured :" + result, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
