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
using System.Data.Entity;

namespace FormProfile
{
    public partial class FormSwitchUser : Form
    {
        ReturnUserID returnUserID;
        public FormSwitchUser(ReturnUserID sender)
        {
            InitializeComponent();
            returnUserID = sender;
            ReadUsers();
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

            string checkForMistakes = User.CreateUser(tbFamilyName.Text, tbFirstName.Text, tbPatronymic.Text);
            if (checkForMistakes != "OK")
                MessageBox.Show(checkForMistakes);
            else
                MessageBox.Show("All is OK!");

            ReadUsers();
        }

        private void ReadUsers()
        {
            lvUsers.Items.Clear();
            List<User> lstUsers = (List<User>)User.PrintUsers();
            if (lstUsers != null)
            {
                foreach (var user in lstUsers)
                {
                    ListViewItem item = new ListViewItem(new string[] { user.UserID.ToString(), user.FullName }, 0);

                    this.lvUsers.FullRowSelect = true;     //Возвращает или задает значение, указывающее, выбираются ли при щелчке элемента все его подэлементы.
                    this.lvUsers.GridLines = true;         //Возвращает или задает значение, указывающее, будут ли видны в элементе управления
                    //линии сетки между строками и столбцами, содержащими составляющие элементы и подэлементы.
                    this.lvUsers.Items.Add(item);
                    this.lvUsers.View = View.Details;      //Возвращает или задает способ отображения составляющих элементов в данном элементе управления.
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int id = -1;
                if (!Int32.TryParse(lvUsers.SelectedItems[0].Text, out id))
                    return;
                returnUserID(id);
                this.DialogResult = DialogResult.OK;
            }
            catch { }
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
