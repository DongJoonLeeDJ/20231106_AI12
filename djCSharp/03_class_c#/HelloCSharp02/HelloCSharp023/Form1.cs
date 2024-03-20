using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "dj", grade = 1 });
            students.Add(new Student() { name = "jy", grade = 2 });
            students.Add(new Student() { name = "mj", grade =3 });
            students.Add(new Student() { name = "jh", grade = 4 });
            students.Add(new Student() { name = "wj", grade = 1 });
            students.Add(new Student() { name = "sk", grade = 3 });
            students.Add(new Student() { name = "yt", grade = 1 });

            for(int i = 0; i < students.Count;i++)
            {
                Label label = new Label(); //코드상으로 label 생성
                label.Text = $"{students[i].grade}학년 {students[i].name}님";
                label.AutoSize = true; //이거 없으면 긴 글자 나올 때 글자 짤림
                label.Location = new Point(15, 15 + 25 * i);
                Controls.Add(label); //이거 없으면 화면에 나타나지 않음
            }
            for(int i = students.Count-1; i>=0; i--)
            {
                if (students[i].grade>1)
                    students.RemoveAt(i);
            }
            for (int i = 0; i < students.Count; i++)
            {
                Label label = new Label(); //코드상으로 label 생성
                label.Text = $"{students[i].grade}학년 {students[i].name}님";
                label.AutoSize = true; //이거 없으면 긴 글자 나올 때 글자 짤림
                label.Location = new Point(150, 15 + 25 * i);
                Controls.Add(label); //이거 없으면 화면에 나타나지 않음
            }
        }
    }
}
