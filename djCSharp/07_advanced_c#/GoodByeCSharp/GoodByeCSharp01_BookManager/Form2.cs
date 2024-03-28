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
            StartPosition = FormStartPosition.CenterScreen;
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

        private void button2_Click(object sender, EventArgs e) //수정
        {
            Book b = null;
            //for(int i = 0; i<DataManager.Books.Count; i++)
            for(int i = 0; i< bookBindingSource.Count; i++)
            {
                b = bookBindingSource[i] as Book;
                //string 비교 = c#에서는 Equals 혹은 ==으로 비교됨
                //java에서는 equals를 권장함(혹은 필수)
                if (b.isbn == textBox1.Text) //isbn으로 조회해서 책 이름이랑 출판사 바꾸기
                {
                    b.name = textBox2.Text;
                    b.publisher = textBox3.Text;
                    int.TryParse (textBox4.Text, out int page);
                    if(page<= 0)
                    {
                        MessageBox.Show("페이지 값 잘못됐어요!");
                        return; //buttn2_Click 종료
                    }
                    b.page = page;
                    DataManager.Books[i] = b;
                    DataManager.Save();
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //삭제
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book b = dataGridView1.CurrentRow.DataBoundItem as Book;
            textBox1.Text = b.isbn;
            textBox2.Text = b.name;
            textBox3.Text = b.publisher;
            //textBox4.Text = b.page+"";
            textBox4.Text = b.page.ToString();
        }
    }
}
