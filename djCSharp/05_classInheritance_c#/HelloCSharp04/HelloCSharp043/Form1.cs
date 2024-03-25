using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
            products.Add(new Product() { name="고구마",price=1000});
            products.Add(new Product() { name="파",price=100});
            products.Add(new Product() { name="감자",price=500});

            int i = 0;
            foreach (Product product in products)
            {
                Label l = new Label();
                l.Location = new Point(10, 10 + (30 * i));
                l.Text = product.name+product.price;
                l.AutoSize = true; //글자 짤림 방지
                Controls.Add(l);
                i++;
            }
            i = 0;
            products.Sort(); //가격 기준으로 정렬됨
            foreach (Product product in products)
            {
                Label l = new Label();
                l.Location = new Point(170, 10 + (30 * i));
                //l.Text = product.name + product.price;
                l.Text = product.ToString();
                l.AutoSize = true;
                Controls.Add(l);
                i++;
            }

            //다형성 응용하기
            //왼쪽 인터페이스 = 오른쪽 클래스(해당 인터페이스를 구현한 클래스)
            IComparable<Product> p = new Product();
            //IComparable pp = new Product();


        }
    }
}
