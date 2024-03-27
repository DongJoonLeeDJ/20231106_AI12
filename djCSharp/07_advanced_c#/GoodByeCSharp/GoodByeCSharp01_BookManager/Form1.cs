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
            StartPosition = FormStartPosition.CenterScreen; //화면 중앙에 오게 하기, 디자인 창에서도 설정 가능
            refreshScreen();    //도서 관리나 사용자 관리의 변경 사항을 메인 화면에 바로 반영하기 위해서
        }

        void refreshScreen()
        {
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
                (delegate (Book x) { return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now; }).Count() + "";

            bookBindingSource.Clear(); //초기화
            foreach (Book book in DataManager.Books)
            {
                bookBindingSource.Add(book);
            }
            /*
             bookBindingSource.DataSource=null;
             if (DataManager.Books.Count > 0)
                bookBindingSource.DataSource=DataManager.Books;
             */

            dataGridView2.DataSource = null; //null을 해주고 나서 DataSource를 바꿔야 
            //DataManager에 있는 Books나 Users의 변경 사항이 DataGridView에도 반영이 됨 
            if (DataManager.Users.Count > 0)
                dataGridView2.DataSource = DataManager.Users;
        }


        private void LibraryBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide();
            new Form2().ShowDialog(); //Show 말고 ShowDialog로 해야 함
            //Show();
            refreshScreen();
        }

        private void LibraryUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            refreshScreen();
        }
    }
}
