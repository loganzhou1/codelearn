using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTools;

namespace 常用工具类
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tools tools = new Tools();
        public void button1_Click(object sender, EventArgs e)
        {
            if (tools.IsNumeric(textBox1.Text))
            {
                textBox1.AppendText("是数字！");
            }
            else
            {
                textBox1.AppendText("非数字！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("timer_start"))
            {
                timer1.Start();
                button2.Text = "timer_stop";
            }
            else
            {
                timer1.Stop();
                button2.Text = "timer_start";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
