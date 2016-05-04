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

namespace FormProfile
{
    public partial class FormEditExpirience : Form
    {
        User myUserProfile = null;
        List<Expirience> lstExpirience;
        int _expForEdite = -1;
        public FormEditExpirience(User myUserProfile)
        {
            InitializeComponent();
            this.myUserProfile = myUserProfile;
            rtbExpirienceInfo.Text = "";
            ReadExp();
        }

        private void ReadExp()
        {
            lblPrefferedExp.Text = myUserProfile.PrintPreferedExpirience();
            lboxExpirience.Items.Clear();
            lstExpirience = (List<Expirience>)Expirience.PrintExp(myUserProfile.UserID);
            if(lstExpirience != null)
            {
                foreach(var exp in lstExpirience)
                {
                    lboxExpirience.Items.Add(exp);
                }
            }
            lstExpirience = null;
        }

        private void btnAddExp_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpFrom.Value;
            DateTime dateTo = dtpTo.Value;

            tbCompany.ForeColor = Color.Black;
            tbPost.ForeColor = Color.Black;
            bool mistake = false;
            if (tbCompany.CheckField(20, @"[A-Za-z0-1 ]"))
                mistake = true;
            if (tbPost.CheckField(20, @"[A-Za-z0-1 ]"))
                mistake = true;
            if (dateFrom.ToShortDateString() == dateTo.ToShortDateString())
            {
                MessageBox.Show("Start and end dates should be different");
                mistake = true;
            }
            if(mistake)
                return;
            
            string report = Expirience.AddExp(myUserProfile, tbCompany.Text, tbPost.Text, dtpFrom.Value, dtpTo.Value, _expForEdite);
            if (report != "OK")
                MessageBox.Show(report);
            else
            {
                MessageBox.Show("Work is done!");
                tbCompany.Clear();
                tbPost.Clear();
                dtpFrom.Value = DateTime.Now;
                dtpTo.Value = DateTime.Now;
                btnAddExp.Text = "Add Expirience";
                btnAddExp.ForeColor = Color.Blue;
                _expForEdite = -1;
                ReadExp();
            }
        }

        private void tbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void tbPost_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void btnAddSelectedExpToTitle_Click(object sender, EventArgs e)
        {
            if (lboxExpirience.SelectedItem != null)
            {
                Expirience exp = (Expirience)lboxExpirience.SelectedItem;
                string report = exp.AddPreferredExpirience();
                if (report != "OK")
                {
                    MessageBox.Show(report);
                }
                else
                {
                    lblPrefferedExp.Text = exp.ToString();
                }
            }
        }

        private void btnDelSelectedExp_Click(object sender, EventArgs e)
        {
            if (lboxExpirience.SelectedItem != null)
            {
                Expirience exp = (Expirience)lboxExpirience.SelectedItem;
                exp.DelExp();
                rtbExpirienceInfo.Clear();
                ReadExp();
            }
        }

        private void btnEditSelectedExp_Click(object sender, EventArgs e)
        {
            if (btnAddExp.Text == "Add Expirience" && lboxExpirience.SelectedItem != null)
            {
                Expirience exp = (Expirience)lboxExpirience.SelectedItem;
                _expForEdite = exp.ExpID;
                btnAddExp.Text = "Edite Expirience";
                btnAddExp.ForeColor = Color.DarkViolet;
                tbCompany.Text = exp.Company;
                tbPost.Text = exp.Post;
                dtpFrom.Value = exp.DateFrom;
                dtpFrom.Update();
                dtpTo.Value = exp.DateTo;
                dtpTo.Update();
            }
            else
            {
                _expForEdite = -1;
                btnAddExp.Text = "Add Expirience";
                btnAddExp.ForeColor = Color.Blue;
                tbCompany.Clear();
                tbPost.Clear();
                dtpFrom.Value = DateTime.Now;
                dtpTo.Value = DateTime.Now;
            }
        }

        private void lboxExpirience_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxExpirience.SelectedItem != null)
            {
                Expirience exp = (Expirience)lboxExpirience.SelectedItem;

                rtbExpirienceInfo.Text = String.Format("Company: {0}\nPost: {1}\nFrom: {2}\nTo: {3}",
                    exp.Company, exp.Post, exp.DateFrom.ToShortDateString(), exp.DateTo.ToShortDateString());
            }
        }
    }
}
