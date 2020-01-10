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
    public partial class Login : Form
    {
        public Login()
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
                    Email.Text = "E_Mail";
                }
            }
            if (Email.Focused)
            {
                if (Email.Text == "E_Mail")
                {
                    Email.Text = "";
                }
            }
        }

        private void Password_secret(object sender, EventArgs e)
        {

        }

        private void New_user_Click(object sender, EventArgs e)
        {
            make_account m = new make_account();
            this.Hide();
            m.ShowDialog();
            this.Close();

        }
    }
}
