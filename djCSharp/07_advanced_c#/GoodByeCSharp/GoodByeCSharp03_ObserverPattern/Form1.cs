using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodByeCSharp03_ObserverPattern
{
    public partial class Form1 : Form, ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            notify((sender as TextBox).Text);
        }

        public void notify(string msg)
        {
            foreach(IObserver item in observers)
                item.update(msg);
        }

        public void register(IObserver o)
        {
            observers.Add(o);
        }

        public void unregister(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
