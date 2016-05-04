using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Models;
using System.IO;

namespace FormProfile
{
    public partial class FormEditEducation : Form
    {
        User myUserProfile = null;
        List<Education> lstEducation;
        int _educationForEdite = -1;
        public FormEditEducation(User myUserProfile)
        {
            InitializeComponent();
            this.myUserProfile = myUserProfile;
            rtbEducationInfo.Text = "";
            ReadEducationce();
        }

        private void ReadEducationce()
        {
            lblPrefferedEduc.Text = myUserProfile.PrintPreferedEducation();
            lboxEducation.Items.Clear();
            lstEducation = (List<Education>)Education.PrintEducation(myUserProfile.UserID);
            if (lstEducation != null)
            {
                foreach (var educ in lstEducation)
                {
                    lboxEducation.Items.Add(educ);
                }
            }
            lstEducation = null;
        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpFrom.Value;
            DateTime dateTo = dtpTo.Value;

            tbInstitution.ForeColor = Color.Black;
            tbSpecialty.ForeColor = Color.Black;
            bool mistake = false;
            if (tbInstitution.CheckField(20, @"^[a-zA-Z0-9 ]+$"))
                mistake = true;
            if (tbSpecialty.CheckField(20, @"^[a-zA-Z0-9 ]+$"))
                mistake = true;
            if (dateFrom.ToShortDateString() == dateTo.ToShortDateString())
            {
                MessageBox.Show("Start and end dates should be different of the date should be different");
                mistake = true;
            }


            if (mistake)
            {
                return;
            }

            string report = Education.AddEducation(myUserProfile, tbSpecialty.Text, tbInstitution.Text, dateFrom, dateTo, _educationForEdite);
            if (report != "OK")
                MessageBox.Show(report);
            else
            {
                MessageBox.Show("Work is done!");
                tbInstitution.Clear();
                tbSpecialty.Clear();
                dtpFrom.Value = DateTime.Now;
                dtpTo.Value = DateTime.Now;
                btnAddEducation.Text = "Add Education";
                btnAddEducation.ForeColor = Color.Blue;
                _educationForEdite = -1;
                ReadEducationce();
            }
        }


        private void tbInstitution_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void tbSpecialty_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void lboxEducation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxEducation.SelectedItem != null)
            {
                Education educ = (Education)lboxEducation.SelectedItem;

                rtbEducationInfo.Text = String.Format("Institution: {0}\nSpecialty: {1}\nFrom: {2}\nTo: {3}",
                    educ.Institution, educ.Specialty, educ.DateFrom.ToShortDateString(), educ.DateTo.ToShortDateString());
            }
        }

        private void btnAddSelectedEducationToTitle_Click(object sender, EventArgs e)
        {
            if(lboxEducation.SelectedItem != null)
            {
                Education educ = (Education)lboxEducation.SelectedItem;
                string report = educ.AddPreferredEducation();
                if(report != "OK")
                {
                    MessageBox.Show(report);
                }
                else
                {
                    lblPrefferedEduc.Text = educ.ToString();
                }
            }
        }

        private void btnDelSelectedEducation_Click(object sender, EventArgs e)
        {
            if (lboxEducation.SelectedItem != null)
            {
                Education educ = (Education)lboxEducation.SelectedItem;
                educ.DelEducation();
                rtbEducationInfo.Clear();
                ReadEducationce();
            }
        }

        private void btnEditSelectedEducation_Click(object sender, EventArgs e)
        {
            if(btnAddEducation.Text == "Add Education" && lboxEducation.SelectedItem != null)
            {
                Education educ = (Education)lboxEducation.SelectedItem;
                _educationForEdite = educ.EducationID;
                btnAddEducation.Text = "Edite Education";
                btnAddEducation.ForeColor = Color.DarkViolet;
                tbInstitution.Text = educ.Institution;
                tbSpecialty.Text = educ.Specialty;
                dtpFrom.Value = educ.DateFrom;
                dtpFrom.Update();
                dtpTo.Value = educ.DateTo;
                dtpTo.Update();
            }
            else
            {
                _educationForEdite = -1;
                btnAddEducation.Text = "Add Education";
                btnAddEducation.ForeColor = Color.Blue;
                tbInstitution.Clear();
                tbSpecialty.Clear();
                dtpFrom.Value = DateTime.Now;
                dtpTo.Value = DateTime.Now;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            _educationForEdite = -1;
            btnAddEducation.Text = "Add Education";
            btnAddEducation.ForeColor = Color.Blue;
            tbInstitution.Clear();
            tbSpecialty.Clear();
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }


    }
}
