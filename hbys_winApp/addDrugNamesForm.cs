using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addDrugNamesForm : Form
    {
        public addDrugNamesForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //hbys_winApp.hisLib addDrugName = new hisLib();
            //string result = addDrugName.addDrugName(tbDrug.Text);
            //if (result == "drugNameAdded")
            //    MessageBox.Show("Succesfully Saved", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Sorry a problem has occured","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);

            hbys_winApp.hisLib myLibObj = new hisLib();
            string result ="";

            if (lblDrugNo.Text == "0")
            {
                result = myLibObj.addDrugName(tbDrug.Text);
            }
            else {
                result = myLibObj.updateDrugName(Int32.Parse(lblDrugNo.Text),tbDrug.Text);
            }
            if (result == "drugNameAdded")
                MessageBox.Show("Succesfully Saved", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sorry a problem has occured " + result, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void addDrugNamesForm_Load(object sender, EventArgs e)
        {
            if (lblDrugNo.Text != "0")
            {
                hbys_winApp.hisLib myLibObj = new hisLib();
                DataSet ds = myLibObj.getDrugSingle(Int32.Parse(lblDrugNo.Text));


                tbDrug.Text = ds.Tables[0].Rows[0]["DrugName"].ToString();
                btnDel.Visible = true;
            }
            else
                btnDel.Visible = false;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib delete_command = new hisLib();
            string res = "";
            if (lblDrugNo.Text != "0")
            {
                res = delete_command.deleteDrugName(Int32.Parse(lblDrugNo.Text));

            }
            if (res == "drugNameDeleted")
                MessageBox.Show("Succesfully Deleted", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sorry a problem has occured   " + res, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


        }
    }
}
