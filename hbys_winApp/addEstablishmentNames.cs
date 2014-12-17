using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addEstablishmentNames : Form
    {
        public addEstablishmentNames()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib addPatientDatasSave = new hisLib();
            string result;

            if (lblEstabNo.Text == "0")
            {

                result = addPatientDatasSave.addEstablishmentName(tbEstab.Text);

                if (result == "addEstablishmentName")
                    MessageBox.Show("Succesfully added", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry a Problem has occured :  " + result, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                result = addPatientDatasSave.updateEstablishmentName(tbEstab.Text, Int32.Parse(lblEstabNo.Text));

                if (result == "updateEsta")
                    MessageBox.Show("Succesfully updated", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry a Problem has occured :  " + result, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addEstablishmentNames_Load(object sender, EventArgs e)
        {
            if (lblEstabNo.Text == "0")
                btnDelete.Visible = false;
            else
                btnDelete.Visible = true;
            //****************************************


            if (lblEstabNo.Text != "0")
            {
                hbys_winApp.hisLib getData = new hisLib();
                DataSet ds = getData.getSingleEstablishmentName(Int32.Parse(lblEstabNo.Text));


                tbEstab.Text = ds.Tables[0].Rows[0]["EstablishmentName"].ToString();
            }//end save






        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib delete_command = new hisLib();

            string del_str = delete_command.deleteEstaName(Int32.Parse(lblEstabNo.Text));
            if (del_str == "deleteEsta")
                MessageBox.Show("Successfully Deleted ","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("An error has occured. :" + del_str,"Sorry",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}

