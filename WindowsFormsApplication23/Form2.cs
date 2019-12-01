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
using System.Windows;

namespace WindowsFormsApplication23
{
    public partial class Form2 : Form
    {
        string file;
        public static string[] id = new string[10];
        public static string[] name = new string[10];
        public static string[] smster = new string[10];
        public static double[] cgpa = new double[10];
        public static string[] dep = new string[10];
        public static string[] uni = new string[10];
        public static int size;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        public void Heighest(string[] id, string[] name, string[] smster, double[] cgpa, string[] dep, string[] uni, ref int size)
        {
            double max0, temp0;
            string max1, max2, max3, max4, max5;
            string temp1, temp2, temp3, temp4, temp5;
            for (int i = 0; i < size; i++)
            {
                max0 = cgpa[i];
                max1 = id[i];
                max2 = name[i];
                max3 = smster[i];
                max4 = dep[i];
                max5 = uni[i];
                for (int j = i + 1; j < size; j++)
                {
                    if (max0 > cgpa[j])
                    {
                        temp0 = max0;
                        max0 = cgpa[j];
                        cgpa[j] = temp0;
                        temp1 = max1;
                        max1 = id[j];
                        id[j] = temp1;

                        temp2 = max2;
                        max2 = name[j];
                        name[j] = temp2;

                        temp3 = max3;
                        max3 = smster[j];
                        smster[j] = temp3;

                        temp4 = max4;
                        max4 = dep[j];
                        dep[j] = temp4;

                        temp5 = max5;
                        max5 = uni[j];
                        uni[j] = temp5;
                    }

                }
                cgpa[i] = max0;
                id[i] = max1;
                name[i] = max2;
                smster[i] = max3;
                dep[i] = max4;
                uni[i] = max5;
            }
            string str1 = "ID" + "\t" + "Name" + "\t" + "Smester" + "\t" + "CGPA" + "\t" + "Dept" + "\t" + "Uni" + "\n";

            for (int i = size - 1; i >=(size)-3; i--)
            {
                str1 += id[i] + "\t" + name[i] + "\t" + smster[i] + "\t" + cgpa[i] + "\t" + dep[i] + "\t" + uni[i] + "\n";

            }
            richTextBox1.Text = str1;
        }
        public void Delete(string[] id, string[] name, string[] smster, double[] cgpa, string[] dep, string[] uni, ref int size)
        {
            string txtStr;
            txtStr = txtId.Text;
            int count1 = 0;
            if (txtStr == "")
            {
                MessageBox.Show("Plzz Enter ID Text Field");
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (id[i] == txtStr)
                    {
                        for (int j = i; j < (size - 1); j++)
                        {
                            id[j] = id[j + 1];
                            name[j] = name[j + 1];
                            smster[j] = smster[j + 1];
                            cgpa[j] = cgpa[j + 1];
                            dep[j] = dep[j + 1];
                            uni[j] = uni[j + 1];
                        }
                        count1++;
                        size = size - 1;
                        break;
                    }
                }
                if (count1 == 0)
                {
                    MessageBox.Show("Record NOt found");
                }
                else
                {
                    MessageBox.Show("Record Deleted successfully");
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string line;
            
            string a = "", b = "", c = "", dp = "", f = "";
            double d = 0.0;
            int i = 0, count = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                 file= filename;
            }
            StreamReader sr = new StreamReader(file);
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                if (i == 0)
                {
                    a = line;
                    i++;
                }
                else if (i == 1)
                {
                    b = line;
                    i++;
                }
                else if (i == 2)
                {
                    c = line;
                    i++;
                }
                else if (i == 3)
                {
                    d = Convert.ToDouble(line);
                    i++;
                }
                else if (i == 4)
                {
                    dp= line;
                    i++;
                }
                else if (i == 5)
                {

                    f = line;
                    i++;
                    if (i % 6 == 0)
                    {
                        count++;
                        id[count] = a;
                        name[count] = b;
                        smster[count] = c;
                        cgpa[count] = d;
                        dep[count] = dp;
                        uni[count] = f;

                    }
                    i = 0;
                }
            }
            sr.Close();
            size = count + 1;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str1 = "ID" + "\t" + "Name" + "\t" + "Smester" + "\t" + "CGPA" + "\t" + "Dept" + "\t" + "Uni"+"\n";
            for(int i=0;i<5;i++)
            {
                str1+= id[i] + "\t" + name[i] + "\t" + smster[i] + "\t" + cgpa[i] + "\t" + dep[i] + "\t" + uni[i] + "\n";

            }
            richTextBox1.Text = str1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Heighest(id, name, smster, cgpa, dep, uni, ref size);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Delete(id,name,smster,cgpa,dep,uni, ref size);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
