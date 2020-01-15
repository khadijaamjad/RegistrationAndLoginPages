using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VP_11
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"");
        SqlCommand cmd;
        SqlDataReader sdr;

        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM LoginInfo where UserID='" + tbUserid.Text+"' AND UserPassword='"+tbPassword.Text+"'";
            cmd = new SqlCommand(q, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            if (dt.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Successful Login");
            }
            else
            {
                MessageBox.Show("Account does not exist");
            }
        }
    }
}
