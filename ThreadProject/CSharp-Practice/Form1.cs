using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Practice
{
    public partial class Form1 : Form
    {
        Sattar sattar = new Sattar();
       

        public Form1()
        {
            InitializeComponent();
            sattar.Enter += new Sattar.EnterHandler(Togrul);
            sattar.Enter += new Sattar.EnterHandler(ShowMessage1);
            sattar.Enter += new Sattar.EnterHandler(ShowMessage2);
            Test();
        }

        private string Togrul(string a)
        {
            MessageBox.Show(a);
            return a;
        }

        private string ShowMessage1(string a)
        {
            MessageBox.Show(a);
            return a;
        }
        private string ShowMessage2(string a)
        {
            MessageBox.Show(a);
            return a;
        }


        private void Test()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 50)
                {
                }
            }
        }

        private void btnClickMe_MouseHover(object sender, EventArgs e)
        {
            sattar.TriggerEnter("Enter event worked");

        }
    }
}
