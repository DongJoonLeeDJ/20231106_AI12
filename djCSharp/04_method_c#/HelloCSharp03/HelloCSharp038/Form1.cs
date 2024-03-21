using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp038
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CustomForm().Show();
        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            MessageBox.Show("내용","제목");
        }
    }
}
