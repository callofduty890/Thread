using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Sleep注意事项
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Application.DoEvents();
            }
            
        }
    }
}
