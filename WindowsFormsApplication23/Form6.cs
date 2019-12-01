using System;
using System.IO;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int size;
            size = Form2.size;
            string path = "attend.txt";
            string str = "";
            using (StreamReader sw = new StreamReader(path))
            {
                str += "ID" + "\t" + "Name" + "\t" + "Attendance" + "\n";
                
                for (int i = 0; i < size; i++)
                {
                    str += sw.ReadLine() + "\n";
                }
                richTextBox1.Text = str;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
