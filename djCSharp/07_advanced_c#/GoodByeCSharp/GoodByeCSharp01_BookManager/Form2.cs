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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            bookBindingSource.Clear();
            foreach(Book book in DataManager.Books)
            {
                bookBindingSource.Add(book);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            foreach(var item in DataManager.Books)
            {
                if(item.isbn.Equals(textBox1.Text))
                {
                    existBook = true;
                    break;
                }
            }
            if(existBook)
                MessageBox.Show("해당 책 이미 있으니 등록 불가능");
            else
            {
                Book book = new Book();
                book.isbn = textBox1.Text;
                book.name = textBox2.Text;
                book.publisher = textBox3.Text;
                int.TryParse(textBox4.Text, out int page);
                if(page<=0)
                {
                    throw new Exception("페이지 값이 잘못됐습니다."); //튕김
                }
                book.page = page;
                DataManager.Books.Add(book);
                bookBindingSource.Add(book);
                DataManager.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
