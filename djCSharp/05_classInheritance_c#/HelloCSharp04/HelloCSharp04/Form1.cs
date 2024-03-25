using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //창을 띄우는 유형
            //모달(Modal) // 다른 화면 조작 불가능, 코드가 멈춤
            //모달리스(Modeless) //다른 화면 조작 가능, 코드가 멈추지 않음

            //디자인면에서나 버튼 개수 면에서 제한이 많음
            //팝업 창에서 뭔가를 입력받고 싶은 데 그런 기능은 없음
            MessageBox.Show("경고 메시지"); //메시지 박스는 기본적으로 모달!!!
            MessageBox.Show("위험 메시지", "위험!");
            DialogResult result;
            do
            {
                result = MessageBox.Show
                    ("다시 시도?","시도문의",MessageBoxButtons.RetryCancel);
            } while (result==DialogResult.Retry);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            //코드가 멈춰서 Show를 호출 안 함
            //창을 닫아야 Show 호출하게 됨
            MessageBox.Show("잠시 숨겼습니다."); //모달을 활용하는 방법 중 하나
            Show();
        }
    }
}
