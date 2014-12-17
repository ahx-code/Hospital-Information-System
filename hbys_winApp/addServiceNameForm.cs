using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addServiceNameForm : Form
    {
        public addServiceNameForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            hbys_winApp.hisLib add = new hisLib();
            string res;
            if (lblServiceNo.Text == "0")
            {

                res = add.addServiceName(tbAddService.Text);
                if (res == "1")
                    MessageBox.Show("Successfully Added", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An error has occured " + res, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//end if
            else
            {
                res = add.updateServiceName(Int32.Parse(lblServiceNo.Text), tbAddService.Text);
                if (res == "1")
                    MessageBox.Show("Successfully Updated", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An error has occured: "+res, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addServiceNameForm_Load(object sender, EventArgs e)
        {
            if (lblServiceNo.Text == "0")
            {
                btnDel.Visible = false;
                btnSave.Text = "Save";
            }
            else
            {
                btnDel.Visible = true;
                btnSave.Text = "Update";
            }

            if (lblServiceNo.Text != "0")
            {
                hbys_winApp.hisLib get = new hisLib();
                DataSet ds = get.getSingleServiceName(Int32.Parse(lblServiceNo.Text));
                tbAddService.Text = ds.Tables[0].Rows[0]["ServiceName"].ToString();
            }//end save
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib hl = new hisLib();
            string res = hl.deleteServiceName(Int32.Parse(lblServiceNo.Text));
            if (res == "1")
                MessageBox.Show("Successfully Deleted", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An error has occured: "+res,"Sorry",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
