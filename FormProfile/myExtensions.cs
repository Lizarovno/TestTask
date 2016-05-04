using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace FormProfile
{
    public static class myExtensions
    {
        public static bool CheckField(this TextBox textBox, int length, string pattern)
        {
            bool mistake = false;

            if (textBox.Text == "Field is too long!" || textBox.Text == "Field must be filled!" || textBox.Text == "Permission system message!" || textBox.Text == "Writing with mistakes!")
            {
                textBox.ForeColor = Color.DarkRed;
                textBox.Text = "Permission system message!";
                return true;
            }

            if (textBox.Text.Length > 20)
            {
                textBox.ForeColor = Color.DarkRed;
                textBox.Text = "Field is too long!";
                return true;
            }

            if (String.IsNullOrEmpty(textBox.Text))
            {
                textBox.ForeColor = Color.DarkRed;
                textBox.Text = "Field must be filled!";
                return true;
            }

            if (pattern != "noPattern")
            {
                if (!Regex.IsMatch(textBox.Text, pattern))
                {
                    textBox.ForeColor = Color.DarkRed;
                    textBox.Text = "Writing with mistakes!";
                    return true;
                }
            }

            return mistake;
        }
    }
}
