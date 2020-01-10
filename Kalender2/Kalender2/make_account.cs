using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kalender2
{
    public partial class make_account : Form
    {
        public make_account()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void make_account_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "programmieren123DataSet.Nutzer". Sie können sie bei Bedarf verschieben oder entfernen.
            this.nutzerTableAdapter.Fill(this.programmieren123DataSet.Nutzer);

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
