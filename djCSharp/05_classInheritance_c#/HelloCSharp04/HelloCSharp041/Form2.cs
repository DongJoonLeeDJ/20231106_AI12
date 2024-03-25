using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HelloCSharp041
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string txt)
        {
            InitializeComponent();

            if (txt.Equals("red"))
            {
                BackColor = Color.Red;
            }
            else if (txt.Equals("blue"))
            {
                BackColor = Color.Blue;
            }
        }
    }
}
