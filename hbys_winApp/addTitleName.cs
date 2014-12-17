using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addTitleName : Form
    {
        public addTitleName()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib addTitleNam = new hisLib();
            string result;

            if (lblTitleNo.Text == "0")
            {

                result = addTitleNam.addTitleName(tbTitle.Text);

                if (result == "addTitleName")
                    MessageBox.Show("Succesfully added", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An error has occured :  " + result, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                result = addTitleNam.updateTitleName(tbTitle.Text, Int32.Parse(lblTitleNo.Text));

                if (result == "updateTitleName")
                    MessageBox.Show("Succesfully updated", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An error has occured :  " + result, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//end else




        }

        private void addTitleName_Load(object sender, EventArgs e)
        {
            if (lblTitleNo.Text == "0")
                btnDelete.Visible = false;
            else
                btnDelete.Visible = true;
            //****************************************


            if (lblTitleNo.Text != "0")
            {
                hbys_winApp.hisLib getData = new hisLib();
                DataSet ds = getData.getSingleTitleName(Int32.Parse(lblTitleNo.Text));


                tbTitle.Text = ds.Tables[0].Rows[0]["TitleName"].ToString();

            }
                



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib delete_command = new hisLib();

            string del_str = delete_command.deleteTitleName(Int32.Parse(lblTitleNo.Text));
            if (del_str == "deleteTitleName")
                MessageBox.Show("Successfully Deleted ","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("An Error has occured.","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }//end method






    }
}