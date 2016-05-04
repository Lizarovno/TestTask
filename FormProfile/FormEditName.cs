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
    public partial class FormEditName : Form
    {
        User _myUserProfile;
        public FormEditName(User user)
        {
            InitializeComponent();
            _myUserProfile = user;
            tbFirstName.Text = _myUserProfile.FirstName;
            tbFamilyName.Text = _myUserProfile.FamilyName;
            tbPatronymic.Text = _myUserProfile.Patronymic;
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            bool[] mistakes = new bool[3];
            string pattern = @"^[a-zA-Z]+${3,10}";

            mistakes[0] = tbFamilyName.CheckField(10, pattern);
            mistakes[1] = tbFirstName.CheckField(10, pattern);
            mistakes[2] = tbPatronymic.CheckField(10, pattern);

            foreach (var mistake in mistakes)
            {
                if (mistake)
                    return;
            }

            _myUserProfile.ChangeName( tbFirstName.Text, tbFamilyName.Text, tbPatronymic.Text);
            this.Close();
        }

        private void tbFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void tbFamilyName_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void tbPatronymic_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }
    }
}
