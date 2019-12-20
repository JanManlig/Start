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
            string strConnect = @"Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\schule\source\repos\JanManlig\Start\Kalender2\datenbank\Programmieren.accdb; Persist Security Info=False;";
            using (OleDbConnection con = new OleDbConnection(strConnect))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Nutzer", con))
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    table_Nutzer.DataSource = dt;
                }
            }


            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
