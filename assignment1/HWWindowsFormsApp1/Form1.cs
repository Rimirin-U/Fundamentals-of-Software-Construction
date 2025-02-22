using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            int opIndex = comboBox1.SelectedIndex;
            double ans = 0;
            if (opIndex == 0) ans = a + b;
            else if (opIndex == 1) ans = a - b;
            else if (opIndex == 2) ans = a * b;
            else if (opIndex == 3) ans = a / b;
            textBox3.Text = Convert.ToString(ans);
        }
    }
}
