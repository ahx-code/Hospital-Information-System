using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hbys_winApp
{
    public partial class addSendingForm : Form
    {
        public addSendingForm()
        {
            InitializeComponent();
        }

        private void addSendingForm_Load(object sender, EventArgs e)
        {
            //----------------------------Patient Name in Combo Box-----------------------------------//
            if (lblSendingNo.Text == "0")
                btnDel.Visible = false;
            else
                btnDel.Visible = true;
            DataSet ds = new DataSet();
            hbys_winApp.hisLib objectHisLib = new hisLib();
            ds = objectHisLib.patientList();
            comboBoxPatientName.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                titleBoxItem objectTitle = new titleBoxItem();
                objectTitle.Txt = ds.Tables[0].Rows[i]["FName"].ToString() + "    " + ds.Tables[0].Rows[i]["Sname"].ToString() + "           " + ds.Tables[0].Rows[i]["TCNo"].ToString();
                objectTitle.Val = ds.Tables[0].Rows[i]["PatientNo"].ToString();
                comboBoxPatientName.Items.Add(objectTitle);
            }
            if (comboBoxPatientName.Items.Count > 0)
                comboBoxPatientName.SelectedIndex = 0;

            //----------------------------Patient Establishment in Combo Box-----------------------------------//
            ds = objectHisLib.showEstablishment();
            comboBoxEstablishment.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                titleBoxItem establishmentObject = new titleBoxItem();
                establishmentObject.Txt = ds.Tables[0].Rows[i]["EstablishmentName"].ToString();
                establishmentObject.Val = ds.Tables[0].Rows[i]["EstablishmentNo"].ToString();
                comboBoxEstablishment.Items.Add(establishmentObject);
            }
            if (comboBoxEstablishment.Items.Count > 0)
                comboBoxEstablishment.SelectedIndex = 0;
            //----------------------------Patient Establishment in Combo Box-----------------------------------//
            //----------------------------Update Seciton-------------------------------------------------------//
            if (lblSendingNo.Text != "0")
            {


                hbys_winApp.hisLib getData = new hisLib();
                ds = getData.showSendingDatas(Int32.Parse(lblSendingNo.Text));


                string examinationNo = ds.Tables[0].Rows[0]["PatientNo"].ToString();
                string establishmentNo = ds.Tables[0].Rows[0]["EstablishmentNo"].ToString();

                //------------------------------
                for (int i = 0; i < comboBoxPatientName.Items.Count; i++)
                {


                    if (((titleBoxItem)comboBoxPatientName.Items[i]).Val == examinationNo)
                    {
                        comboBoxPatientName.SelectedIndex = i;
                        break;
                    }
                }
                //------------------------------

                for (int i = 0; i < comboBoxEstablishment.Items.Count; i++)
                {


                    if (((titleBoxItem)comboBoxEstablishment.Items[i]).Val == establishmentNo)
                    {
                        comboBoxEstablishment.SelectedIndex = i;
                        break;
                    }
                }






                //----------------------------Update Section-------------------------------------------------------//
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ExaminationNo = Convert.ToInt32(((titleBoxItem)comboBoxPatientName.SelectedItem).Val);
            int EstablishmentNo = Convert.ToInt32(((titleBoxItem)comboBoxEstablishment.SelectedItem).Val);
            hbys_winApp.hisLib hl = new hisLib();
            string res = hl.addSendingDatas(Int32.Parse(lblSendingNo.Text),ExaminationNo,EstablishmentNo  );
            if (res == "1")
                MessageBox.Show("Datas successfully Saved", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An error has occured","Sorry",MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            hbys_winApp.hisLib delete_command = new hisLib();

            string del_str = delete_command.deleteSending(Int32.Parse(lblSendingNo.Text));
            if (del_str == "1")
                MessageBox.Show("Deleted ");
            else
                MessageBox.Show("Error has occured.");
        }
        
        
        
        

        
    }
}
