using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace VP_11
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"");
        SqlCommand cmd;
        SqlDataReader sdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            conn.Open();
            string qu="Insert into UserData (UserID,Fname,Lname) values ('"+tbUserid.Text+"','"+tbName.Text+"','"+tbLname.Text+"')";
            string qu2 = "Insert into LoginInfo values ('" + tbUserid.Text + "','" + tbPassword.Text + "')";
            cmd = new SqlCommand(qu, conn);
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                MessageBox.Show("Error occured, try again.");
            }
            else
            { MessageBox.Show("Account Added!"); }
            conn.Close();
            conn.Open();
            cmd = new SqlCommand(qu2, conn);
            sdr = cmd.ExecuteReader();
            conn.Close();

        }
    }
}
