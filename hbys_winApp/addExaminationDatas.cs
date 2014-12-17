using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addExaminationDatas : Form
    {
        public addExaminationDatas()
        {
            InitializeComponent();
        }

        private void addExaminationDatas_Load(object sender, EventArgs e)
        {
            //------------------------------------------------
            DataSet ds = new DataSet();
            hbys_winApp.hisLib myObj = new hisLib();
            ds = myObj.showPersonalDatas(0);
            comboPersonal.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                titleBoxItem mbi = new titleBoxItem();
                mbi.Txt = ds.Tables[0].Rows[i]["Fname"].ToString() +" " +  ds.Tables[0].Rows[i]["Sname"].ToString();
                mbi.Val = ds.Tables[0].Rows[i]["PersonalNo"].ToString();
                comboPersonal.Items.Add(mbi);
            }
            if (comboPersonal.Items.Count > 0)
                comboPersonal.SelectedIndex = 0;

            //------------------------------------------------
            ds = myObj.showServiceNames();
            comboService.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                titleBoxItem mbi = new titleBoxItem();
                mbi.Txt = ds.Tables[0].Rows[i]["ServiceName"].ToString();
                mbi.Val = ds.Tables[0].Rows[i]["ServiceNo"].ToString();
                comboService.Items.Add(mbi);
            }
            if (comboService.Items.Count > 0)
                comboService.SelectedIndex = 0;
            


            //------------------------------------------------

            ds = myObj.patientList();
            comboPatient.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                titleBoxItem mbi = new titleBoxItem();
                mbi.Txt = ds.Tables[0].Rows[i]["FName"].ToString() + " " + ds.Tables[0].Rows[i]["Sname"].ToString() + "(" + ds.Tables[0].Rows[i]["TCNo"].ToString() + ")";
                mbi.Val = ds.Tables[0].Rows[i]["PatientNo"].ToString();
                comboPatient.Items.Add(mbi);
            }
            if (comboPatient.Items.Count > 0)
                comboPatient.SelectedIndex = 0;
            




            //------------------------------------------------
            if (lblExNo.Text != "0")
            {

             
               hbys_winApp.hisLib getData = new hisLib();
               ds = getData.showExaminationDatas(Int32.Parse(lblExNo.Text));


                string perNo = ds.Tables[0].Rows[0]["PersonalNo"].ToString();
                string serNo = ds.Tables[0].Rows[0]["ServiceNo"].ToString();                
                string patNo = ds.Tables[0].Rows[0]["PatientNo"].ToString();
                DateTime d = Convert.ToDateTime(ds.Tables[0].Rows[0]["ExaminationDate"].ToString());


                //------------------------------
                for (int i = 0; i < comboPatient.Items.Count; i++)
                {


                    if (((titleBoxItem)comboPatient.Items[i]).Val == patNo)
                    {
                        comboPatient.SelectedIndex = i;
                        break;
                    }
                }
                //------------------------------

                for (int i = 0; i < comboService.Items.Count; i++)
                {


                    if (((titleBoxItem)comboService.Items[i]).Val == serNo)
                    {
                        comboService.SelectedIndex = i;
                        break;
                    }
                }

                //------------------------------


                for (int i = 0; i < comboPersonal.Items.Count; i++)
                {


                    if (((titleBoxItem)comboPersonal.Items[i]).Val == perNo)
                    {
                        comboPersonal.SelectedIndex = i;
                        break;
                    }
                }
                //------------------------------



                dateExam.Value = d;
                //------------------------------

               
                

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int patientNo = Convert.ToInt32(((titleBoxItem)comboPatient.SelectedItem).Val);
            int serviceNo = Convert.ToInt32(((titleBoxItem)comboService.SelectedItem).Val);
            int personalNo = Convert.ToInt32(((titleBoxItem)comboPersonal.SelectedItem).Val);
            DateTime d = dateExam.Value;

            //-----------------//

            hbys_winApp.hisLib addExamDatasSave = new hisLib();
            string result;

            
                result = addExamDatasSave.addExaminationDatas(Convert.ToInt32(lblExNo.Text),patientNo, serviceNo, personalNo, d);

                if (result == "1")
                    MessageBox.Show("Succesfully added", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorry a Problem has occured :  " + result, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


           }

        private void btnDel_Click(object sender, EventArgs e)
        {

            hbys_winApp.hisLib delete_command = new hisLib();

            string del_str = delete_command.deleteExamData(Int32.Parse(lblExNo.Text));
            if (del_str == "1")
                MessageBox.Show("Successfully Deleted ","Congratulations",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("An error has occured.:" + del_str,"Sorry",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //-----------------------------//
    }
}
