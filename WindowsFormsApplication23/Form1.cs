using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if(user=="student"&&pass=="123")
            {
                MessageBox.Show("Login Successfully");
                Form2 fm2 = new Form2();
                fm2.Show();
                this.Hide();
               
            }
            else if(user=="")
            {
                MessageBox.Show("Plzz Fill Username Txt Filed");
            }
            else if(pass=="")
            {
                MessageBox.Show("Plzz Fill Password Txt Filed");
            }
            else
            {
                MessageBox.Show("Incorrect Username & Password");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
