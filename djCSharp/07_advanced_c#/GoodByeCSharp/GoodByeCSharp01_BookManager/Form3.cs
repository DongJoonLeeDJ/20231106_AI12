using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodByeCSharp01_BookManager
{
    public partial class Form3 : Form
    {

        bool FindBook(Book x)
        {
            return x.userId == textBox1.Text;
        }
        public Form3()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            if (DataManager.Users.Count > 0)
                dataGridView1.DataSource = DataManager.Users;

            dataGridView1.CellClick += DataGridView1_CellClick;

            //추가
            button1.Click += (s, e) =>
            {

            };
            //수정
            button2.Click += delegate (object s, EventArgs e)
            {

            };
            //삭제
            button3.Click += deleteUser;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void deleteUser(object s, EventArgs e)
        {

        }
    }
}
