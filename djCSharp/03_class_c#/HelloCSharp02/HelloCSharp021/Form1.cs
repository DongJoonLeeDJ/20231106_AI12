﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp021
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent(); //디자인 창에 있는 걸 다 띄움
            Console.WriteLine("안녕!"); //f5하면 나오고
            //ctrtl f5하면 볼 수 없음


            Random r = new Random();
            button1.Text = r.Next(100).ToString();
            button5.Text = button1.Text;
            button2.Text = r.Next(100).ToString();
            button6.Text = button2.Text;
            button3.Text = r.Next(100).ToString();
            button7.Text = button3.Text;
            button4.Text = r.Next(100).ToString();
            button8.Text = button4.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(button1.Text);
            ListText.Text = "";
            foreach (var item in list)
                ListText.Text += item + " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Add(button2.Text);
            ListText.Text = "";
            foreach (var item in list)
                ListText.Text += item + " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Add(button3.Text);
            ListText.Text = "";
            foreach (var item in list)
                ListText.Text += item + " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add(button4.Text);
            ListText.Text = "";
            foreach (var item in list)
                ListText.Text += item + " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Remove(button5.Text);
            ListText.Text = "";
            foreach (var item in list)
                ListText.Text += item + " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Remove(button6.Text);
            ListText.Text = "";
            foreach (var item in list)
                ListText.Text += item + " ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Remove(button7.Text);
            ListText.Text = "";
            foreach (var item in list)
                ListText.Text += item + " ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Remove(button8.Text);
            ListText.Text = "";
            foreach (var item in list)
                ListText.Text += item + " ";
        }

  
    }
}
