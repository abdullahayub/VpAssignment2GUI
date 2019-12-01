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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] id = new string[10];
            string[] name = new string[10];
            int size;
            id = Form2.id;
            name = Form2.name;
            size = Form2.size;
            DataTable dtTable = new DataTable();
            dtTable.Columns.Add("ID", typeof(string));
            dtTable.Columns.Add("Name", typeof(string));
            dtTable.Columns.Add("Mark", System.Type.GetType("System.Boolean"));
            for (int i = 0; i < size; i++)
            {
                DataRow col = dtTable.NewRow();
                col[0] = id[i];
                col[1] = name[i];
                col[2] = false;
                dtTable.Rows.Add(col);
            }

            dataGridView1.DataSource = dtTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText("attend.txt", String.Empty);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                string id1 = dataGridView1.Rows[i].Cells["ID"].Value.ToString();
                string studentname = dataGridView1.Rows[i].Cells["Name"].Value.ToString();
                bool isCellChecked = (bool)dataGridView1.Rows[i].Cells["Mark"].Value;
                string status = "";
                if (isCellChecked == true)
                {
                    status = "P";
                 
                }
                else
                {
                     status = "A";
                   
                }
                string path = "attend.txt";
                     using (StreamWriter sw = new StreamWriter(@path, true))
                     {
                         sw.WriteLine(id1 + "\t" + studentname+"\t"+status);
                     }
                     isCellChecked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 fm6 = new Form6();
            fm6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
