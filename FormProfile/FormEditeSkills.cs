using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;
using DAL.Models;

namespace FormProfile
{
    public partial class FormEditeSkills : Form
    {
        User _myUserProfile;
        List<Skill> lstSkills;
        int _skillForEdite = -1;
        public FormEditeSkills(User myUserProfile)
        {
            InitializeComponent();
            _myUserProfile = myUserProfile;
            ReadSkills();
        }

        private void butSendSkill_Click(object sender, EventArgs e)
        {
            tbSkill.ForeColor = Color.Black;
            bool mistake = tbSkill.CheckField(20, @"^[a-zA-Z0-9 ]+$");
            if (mistake)
                return;
            string report = Skill.AddSkill(_myUserProfile, tbSkill.Text, _skillForEdite);

            if (report != "OK")
                MessageBox.Show(report);
            else
            {
                MessageBox.Show("Work is done!");
                tbSkill.Clear();
                butSendSkill.Text = "Add Skill";
                butSendSkill.ForeColor = Color.Blue;
                _skillForEdite = -1;
            }
            ReadSkills();
        }

        private void ReadSkills()
        {
            lboxSkills.Items.Clear();
            lstSkills = (List<Skill>)Skill.PrintSkills(_myUserProfile.UserID);
            if(lstSkills != null)
            {
                foreach(var skill in lstSkills)
                    lboxSkills.Items.Add(skill);
            }
            lstSkills = null;
        }



        private void btnEditSelectedSkill_Click(object sender, EventArgs e)
        {
            if (butSendSkill.Text == "Add Skill" && lboxSkills.SelectedItem != null)
            {
                Skill skill = (Skill)lboxSkills.SelectedItem;
                _skillForEdite = skill.SkillID;
                butSendSkill.Text = "Edite Skill";
                butSendSkill.ForeColor = Color.DarkViolet;
                tbSkill.Text = skill.SkillName;
            }
            else
            {
                _skillForEdite = -1;
                butSendSkill.Text = "Add Skill";
                butSendSkill.ForeColor = Color.Blue;
                tbSkill.Clear();
            }
        }

        private void tbSkill_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void btnDelSelectedSkill_Click(object sender, EventArgs e)
        {
            if (lboxSkills.SelectedItem != null)
            {
                Skill skill = (Skill)lboxSkills.SelectedItem;
                skill.DelSkill();
                ReadSkills();
            }
        }
    }
}
