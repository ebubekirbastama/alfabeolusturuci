using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alfabeolusturuci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true) //EBS Coding...
            {
                for (char c = 'a'; c <= 'z'; c++)
                {
                    richTextBox1.AppendText(c.ToString());
                }
            }
            else if (radioButton2.Checked == true) //EBS Coding...
            {
                for (char c = '0'; c <= '9'; c++)
                {
                    richTextBox1.AppendText(c.ToString());
                }
            }
        }
    }
}
