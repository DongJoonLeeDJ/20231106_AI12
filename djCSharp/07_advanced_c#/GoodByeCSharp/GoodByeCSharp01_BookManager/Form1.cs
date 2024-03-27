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
    public partial class Form1 : Form
    {
        bool checkIsBorrowed(Book b)
        {
            return b.isBorrowed; //isBorrowed 는 t/f를 리턴함
        }
        public Form1()
        {
            InitializeComponent();
            label1.Text = "전체 도서 수 : " + DataManager.Books.Count; //이 때 Load에 접근함
            label2.Text = "전체 회원 수 : " + DataManager.Users.Count;

            label3.Text = "대출 중인 도서의 수 : ";
            //람다식
            //label3.Text += DataManager.Books.Where( (x)=>x.isBorrowed ).Count() + "";
            //델리게이트 개념을 이해한다면 메서드 만들어서 대입할 수 있음
            label3.Text += DataManager.Books.Where(checkIsBorrowed).Count() + "";

            label4.Text = "연체 중인 도서의 수 :";
            //람다식
            //label4.Text += DataManager.Books.Where
            //    ( (x) => x.isBorrowed&&x.BorrowedAt.AddDays(7)<DateTime.Now).Count().ToString();
            label4.Text += DataManager.Books.Where
                (delegate (Book x) { return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now; }).Count()+"";

            bookBindingSource.Clear();
            foreach(Book book in DataManager.Books) 
            {
                bookBindingSource.Add(book);
            }

            dataGridView2.DataSource = null;
            if (DataManager.Users.Count > 0)
                dataGridView2.DataSource = DataManager.Users;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataManager.Books.RemoveAt(0);

        }
    }
}
