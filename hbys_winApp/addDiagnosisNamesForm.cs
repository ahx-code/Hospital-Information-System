using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addDiagnosisNamesForm : Form
    {
        public addDiagnosisNamesForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib saveDiag = new hisLib();
            string res;
            if (lblDiagNo.Text == "0")
            {
                res = saveDiag.addDiagnosisName(tbDiagnosis.Text);
                if (res == "addDiagnosisName")
                    MessageBox.Show("Successfully Added", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry a Problem has occured :  " + res, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                res = saveDiag.updateDiagnosisName(Int32.Parse(lblDiagNo.Text),tbDiagnosis.Text);
                if (res == "updateDiagnosisName")
                    MessageBox.Show("Succesfully updated", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry a Problem has occured :  " + res, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addDiagnosisNamesForm_Load(object sender, EventArgs e)
        {
            if (lblDiagNo.Text == "0")
            {
                btnDel.Visible = false;
                btnSave.Text = "save";
            }
            else
            {
                btnDel.Visible = true;
                btnSave.Text = "update";
            }

            if (lblDiagNo.Text != "0")
            {
                hbys_winApp.hisLib getData = new hisLib();
                DataSet dataSet = getData.getDiagSingle(Int32.Parse(lblDiagNo.Text));
                tbDiagnosis.Text = dataSet.Tables[0].Rows[0]["DiagName"].ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib del_cmd = new hisLib();
            string del_str = del_cmd.deleteDiagName(Int32.Parse(lblDiagNo.Text));
            if(del_str=="diagNameDeleted")
                MessageBox.Show("Successfully Deleted ", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An error has occured. :" + del_str, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
    }//end class
}
