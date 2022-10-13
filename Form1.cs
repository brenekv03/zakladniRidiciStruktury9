using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zakladniRidiciStruktury9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pc = 0;
            int sc = 0;
            string text = "";
            foreach(string line in listBox1.Items)
            {
                text += line;
            }
            foreach(Control ctrl in groupBox1.Controls)
            {
                if(ctrl is TextBox)
                {
                    pc++;
                    sc += int.Parse(ctrl.Text);
                }
                else if(ctrl is Label)
                {
                    ctrl.Text = text;
                }
            }
            MessageBox.Show("Aritmetický průměr je: " + (double)sc / pc);
        }
    }
}
