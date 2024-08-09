using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _5LAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Input x", "Data Input", "0");
            textBox2.Text = Microsoft.VisualBasic.Interaction.InputBox("Input c1", "Data Input", "0");
            textBox3.Text = Microsoft.VisualBasic.Interaction.InputBox("Input c2", "Data Input", "0");
            textBox4.Text = Microsoft.VisualBasic.Interaction.InputBox("Input c3", "Data Input", "0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int x, c1, c2, c3;
                double y = 0.0;
                x = Convert.ToInt32(textBox1.Text);
                c1 = Convert.ToInt32(textBox2.Text);
                c2 = Convert.ToInt32(textBox3.Text);
                c3 = Convert.ToInt32(textBox4.Text);

                if (x < 10) y = Math.Abs(1.5 - c1 + (Math.Exp(x * c2)));
                else if ((x > 12)&&(c1 != 0))
                y = Math.Pow((x * x * Math.Log(c1) + 0.5 * c3), 2);
                else textBox5.Text = "Невозможно определить значение функции y";
                if (x <= 9 || x >= 13) textBox5.Text = Convert.ToString(y);
                if (y < 10) textBox5.ForeColor = Color.Red;
                else textBox5.ForeColor = Color.Blue;
                }
            }

    }
}
