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

    public delegate void ReturnUserID(int userID);
    public partial class FormProfile : Form
    {
        User myUserProfile = new User();
        public FormProfile()
        {
            InitializeComponent();
            rtbSkillsInfo.Text = "";
            rtbAboutMe.Text = "";
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

            FormSwitchUser dialog = new FormSwitchUser(new ReturnUserID(CatchUserID));
            if (dialog.ShowDialog() != DialogResult.OK)
                this.Close();
            else
                FillProfile();
        }
        void CatchUserID(int userID)
        {
            myUserProfile = User.ReturnUserByID(userID);
        }

        void FillProfile()
        {
            myUserProfile = User.ReturnUserByID(myUserProfile.UserID);
            lblName.Text = myUserProfile.FullName;
            lblEducation.Text = myUserProfile.PrintPreferedEducation();
            lblPrevious.Text = myUserProfile.PrintPreferedExpirience();
            //pbAvatar.Image = Image.FromFile(myUserProfile.GetAvatar().FileName); 

            rtbSkillsInfo.Text = "";
            List<Skill> lstSkill = Skill.PrintSkills(myUserProfile.UserID);
            foreach (var skill in lstSkill)
            {
                rtbSkillsInfo.Text += skill + "; ";
            }

            tbEmail.ForeColor = SystemColors.GrayText;
            tbPhone.ForeColor = SystemColors.GrayText;
            tbAddress.ForeColor = SystemColors.GrayText;
            tbSkype.ForeColor = SystemColors.GrayText;
            rtbAboutMe.ForeColor = SystemColors.GrayText;
            rtbAboutMe.Text = myUserProfile.AboutMe;
            tbEmail.Text = myUserProfile.Email;
            tbPhone.Text = myUserProfile.Phone;
            tbAddress.Text = myUserProfile.Address;
            tbSkype.Text = myUserProfile.Skype;
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            FormEditName dialog = new FormEditName(myUserProfile);
            dialog.ShowDialog();
            FillProfile();
        }

        private void btnEditEducation_Click(object sender, EventArgs e)
        {
            FormEditEducation dialog = new FormEditEducation(myUserProfile);
            dialog.ShowDialog();
            FillProfile();
        }

        private void btnEditPreviousExp_Click(object sender, EventArgs e)
        {
            FormEditExpirience dialog = new FormEditExpirience(myUserProfile);
            dialog.ShowDialog();
            FillProfile();
        }

        private void btnEditSkills_Click(object sender, EventArgs e)
        {
            FormEditeSkills dialog = new FormEditeSkills(myUserProfile);
            dialog.ShowDialog();
            FillProfile();
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FilterIndex = 2;
            ofd.Filter = "Image Files (JPG,PNG,ICO)|*.JPG;*.PNG;*.ICO";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                string fileName = Path.GetFileName(ofd.FileName);
                string pathTo = @"../../../Images/";


                try
                {
                    File.Copy(ofd.FileName, pathTo + fileName);
                    myUserProfile.AddAvatar(pathTo + fileName);
                }
                catch
                {
                    MessageBox.Show("Фаил с таким именем уже сцществует!");
                }

            }
        }

        private void btnEditAboutMe_Click(object sender, EventArgs e)
        {
            myUserProfile.EditeAboutMe(rtbAboutMe.Text);
            FillProfile();
        }

        private void btnEditeEmail_Click(object sender, EventArgs e)
        {
            bool mistake = tbEmail.CheckField(40, @"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)");
            if (mistake)
                return;
            myUserProfile.EditeEmail(tbEmail.Text);
            FillProfile();
        }

        private void btnEditePhone_Click(object sender, EventArgs e)
        {
            bool mistake = tbPhone.CheckField(15, @"^[0-9\-\+]{6,15}$");
            if (mistake)
                return;
            myUserProfile.EditePhone(tbPhone.Text);
            FillProfile();
        }

        private void btnEditeAddress_Click(object sender, EventArgs e)
        {
            bool mistake = tbAddress.CheckField(30, @"^[a-zA-Z0-9 ]+$");
            if (mistake)
                return;
            myUserProfile.EditeAddress(tbAddress.Text);
            FillProfile();
        }

        private void btnEditeSkype_Click(object sender, EventArgs e)
        {
            bool mistake = tbSkype.CheckField(20, @"[a-zA-Z][a-zA-Z0-9\.,\-_]{5,31}");
            if (mistake)
                return;
            myUserProfile.EditeSkype(tbSkype.Text);
            FillProfile();
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void tbPhone_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void tbAddress_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void tbSkype_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void rtbAboutMe_KeyDown(object sender, KeyEventArgs e)
        {
            RichTextBox tb = sender as RichTextBox;
            tb.ForeColor = Color.Black;
        }
    }
}
