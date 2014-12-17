using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addSurveyNames : Form
    {
        public addSurveyNames()
        {
            InitializeComponent();
        }

        private void btn_Save_Survey_Name_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib surveyName = new hisLib();
            string result;

            if (lblSurveyNo.Text == "0")
            {

                result = surveyName.addSurveyName(tbSurvey.Text);

                if (result == "addSurveyName")
                    MessageBox.Show("Succesfully added", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry a Problem has occured :  " + result, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                result = surveyName.updateSurveyName(tbSurvey.Text, Int32.Parse(lblSurveyNo.Text));

                if (result == "updateSurveyName")
                    MessageBox.Show("Succesfully updated", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry a Problem has occured :  " + result, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void addSurveyNames_Load(object sender, EventArgs e)
        {
            if (lblSurveyNo.Text == "0")
                btnDelete.Visible = false;
            else
                btnDelete.Visible = true;
            //****************************************


            if (lblSurveyNo.Text != "0")
            {
                hbys_winApp.hisLib getData = new hisLib();
                DataSet ds = getData.getSingleSurveyList(Int32.Parse(lblSurveyNo.Text));


                tbSurvey.Text = ds.Tables[0].Rows[0]["SurveyName"].ToString();
            }//end save


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            hbys_winApp.hisLib delete_command = new hisLib();

            string del_str = delete_command.deleteTitleName(Int32.Parse(lblSurveyNo.Text));
            if (del_str == "deleteTitleName")
                MessageBox.Show("Successfully Deleted ","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error has occured :" +del_str,"Sorry",MessageBoxButtons.OK,MessageBoxIcon.Information);



        }
    }
}
