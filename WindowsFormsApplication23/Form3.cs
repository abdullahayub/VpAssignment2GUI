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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


         public void  SearchById(string []id, string []name, string []smster, double []cgpa, string []dep, string []uni,ref int size)
         {
             string id1=txtBoxSearch.Text;
             string st="";
             int found=0;
             if (id1 == "")
             {
                 MessageBox.Show("Plzz Enter ID in Blank Text Field");
             }
             else
             {
                 st += "ID" + "\t" + "Name" + "\t" + "Smester" + "\t" + "CGPA" + "\t" + "Dept" + "\t" + "Uni" + "\n";

                 for (int i = 0; i < size; i++)
                 {

                     if (id[i] == id1)
                     {
                         st += id[i] + "\t" + name[i] + "\t" + smster[i] + "\t" + cgpa[i] + "\t" + dep[i] + "\t" + uni[i] + "\n";
                         found = 1;
                     }

                 }
                 if (found == 0)
                 {
                     MessageBox.Show("Record Not Found");
                 }
                 else
                 {
                     richTextBox1.Text = st;
                 }
             }
                 found = 0;
         }
         public void SearchByName(string[] id, string[] name, string[] smster, double[] cgpa, string[] dep, string[] uni, ref int size)
         {
             string stName = txtBoxSearch.Text;
             string st = "";
             int found = 0;
             if (stName == "")
             {
                 MessageBox.Show("Plzz Enter Name in Blank Text Field");
             }
             else
             {
                 st += "ID" + "\t" + "Name" + "\t" + "Smester" + "\t" + "CGPA" + "\t" + "Dept" + "\t" + "Uni" + "\n";
                 for (int i = 0; i < size; i++)
                 {
                     if (name[i] == stName)
                     {
                         st += id[i] + "\t" + name[i] + "\t" + smster[i] + "\t" + cgpa[i] + "\t" + dep[i] + "\t" + uni[i] + "\n";

                         found = 1;
                     }

                 }
                 if (found == 0)
                 {
                     MessageBox.Show("Record Not Found");
                 }
                 else
                 {
                     richTextBox1.Text = st;
                 }
             }
             found = 0;
         }
        public void SearchByList(string[] id, string[] name, string[] smster, double[] cgpa, string[] dep, string[] uni, ref int size)
         {
             string st = "";
             st += "ID" + "\t" + "Name" + "\t" + "Smester" + "\t" + "CGPA" + "\t" + "Dept" + "\t" + "Uni" + "\n";
             for (int i = 0; i < size; i++)
             {
                 st += id[i] + "\t" + name[i] + "\t" + smster[i] + "\t" + cgpa[i] + "\t" + dep[i] + "\t" + uni[i] + "\n";
             }
             richTextBox1.Text = st;
         }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnId_Click(object sender, EventArgs e)
        {
            string[] id = new string[10];
            string[] name = new string[10];
            string[] smster = new string[10];
            double[] cgpa = new double[10];
            string[] dep = new string[10];
            string[] uni = new string[10];
            int size;
            id = Form2.id;
            name = Form2.name;
            smster = Form2.smster;
            cgpa = Form2.cgpa;
            dep = Form2.dep;
            uni = Form2.uni;
            size = Form2.size;
            SearchById(id,name,smster,cgpa,dep,uni,ref size);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();     
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string[] id = new string[10];
            string[] name = new string[10];
            string[] smster = new string[10];
            double[] cgpa = new double[10];
            string[] dep = new string[10];
            string[] uni = new string[10];
            int size;
            id = Form2.id;
            name = Form2.name;
            smster = Form2.smster;
            cgpa = Form2.cgpa;
            dep = Form2.dep;
            uni = Form2.uni;
            size = Form2.size;
            SearchByName(id, name, smster, cgpa, dep, uni, ref size);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string[] id = new string[10];
            string[] name = new string[10];
            string[] smster = new string[10];
            double[] cgpa = new double[10];
            string[] dep = new string[10];
            string[] uni = new string[10];
            int size;
            id = Form2.id;
            name = Form2.name;
            smster = Form2.smster;
            cgpa = Form2.cgpa;
            dep = Form2.dep;
            uni = Form2.uni;
            size = Form2.size;
            SearchByList(id, name, smster, cgpa, dep, uni, ref size);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
