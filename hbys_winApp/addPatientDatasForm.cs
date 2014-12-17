using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addPatientDatasForm : Form
    {
        public addPatientDatasForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib addPatientDatasSave = new hisLib();
            string result ;

            if (lblPatientNo.Text == "0")
            {

                result = addPatientDatasSave.addPatientDatas(tbFn.Text, tbLn.Text, tbTc.Text);

                if (result == "addPatientDatas")
                    MessageBox.Show("Succesfully added", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry a Problem has occured :  " + result, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                result = addPatientDatasSave.updatePatientDatas(tbFn.Text, tbLn.Text, tbTc.Text, Int32.Parse(lblPatientNo.Text));

                if (result == "updatePatientDatas")
                    MessageBox.Show("Succesfully updated", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry a Problem has occured :  " + result, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

       }

        private void addPatientDatasForm_Load(object sender, EventArgs e)
        {
            if (lblPatientNo.Text == "0")
                btnDelete.Visible = false;
            else            
                btnDelete.Visible = true;
            //****************************************


            if (lblPatientNo.Text != "0")
            {
                hbys_winApp.hisLib getData = new hisLib();
                DataSet ds = getData.getSinglePatient(Int32.Parse(lblPatientNo.Text));


                tbFn.Text = ds.Tables[0].Rows[0]["FName"].ToString();
                tbLn.Text = ds.Tables[0].Rows[0]["SName"].ToString();
                tbTc.Text = ds.Tables[0].Rows[0]["TCNo"].ToString();

            }
                

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            hbys_winApp.hisLib delete_command = new hisLib();
            
            string del_str=delete_command.deletePatientDatas(Int32.Parse(lblPatientNo.Text));
            if (del_str == "deletePatientDatas")
                MessageBox.Show("Successfully Deleted ","Congratulations",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error has occured.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void lblPatientNo_Click(object sender, EventArgs e)
        {

        }//end btnSave_Click
    }//end class
}//end namespace
