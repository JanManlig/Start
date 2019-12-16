using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalender2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Password_field_focus(object sender, EventArgs e)
        {
            if (Password.Focused && Password.Text != "")
            {
                Password.Text = "";
                Password.PasswordChar = '*';
            }
            else if(!Password.Focused && Password.Text == "")
            {
                Password.PasswordChar = '\0';
                Password.Text = "Password";
            }
            else if (Password.Focused && Password.Text == "Password")
            {
                    Password.Text = "";
            }
        }
        private void E_Mail_focus(object sender, EventArgs e)
        {
            if (!Email.Focused)
            {
                if (Email.Text == "")
                {
                    Email.Text = "E-Mail";
                }
            }
            if (Email.Focused)
            {
                if (Email.Text == "E-Mail")
                {
                    Email.Text = "";
                }
            }
        }

        private void Password_secret(object sender, EventArgs e)
        {

        }
    }
}
