using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp045
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView3.Columns[0].HeaderText = "학번";
            dataGridView3.Columns[1].HeaderText = "이름";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add(textBox3.Text, textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Add(textBox4.Text);
                dataGridView2.Rows.Add(textBox1.Text, textBox4.Text);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentBindingSource.Add
                (new Student() { name = textBox6.Text, hakbeon = textBox7.Text });
        }

        List<Student> students = new List<Student>();
        private void button5_Click(object sender, EventArgs e)
        {
            students.Add(new Student() { name = textBox8.Text, hakbeon = textBox9.Text });
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = students;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if( (sender as CheckBox).Checked )
            {
                dataGridView1.Columns["Column_hakbeon"].HeaderText = "!!!";
            } 
            else
            {
                dataGridView1.Columns["Column_hakbeon"].HeaderText = "학번!";

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;
            if (temp.Checked)
                dataGridView3.Columns["hakbeonDataGridViewTextBoxColumn"].HeaderText = "???";
            else
                dataGridView3.Columns["hakbeonDataGridViewTextBoxColumn"].HeaderText = "학번?"; 
        }
    }
}
