using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //برنامه که فاصله ی دو نقطه در صفحه را از یکدیگر محاسبه کند
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                Point a = new Point();
                Point b = new Point();
                a.X = Convert.ToDouble(textBox1.Text);
                a.Y = Convert.ToDouble(textBox2.Text);
                b.X = Convert.ToDouble(textBox3.Text);
                b.Y = Convert.ToDouble(textBox4.Text);
                textBox5.Text = Convert.ToString(Point.calculatedistance(a.X, a.Y, b.X, b.Y));
            }
            else MessageBox.Show("fill all the textboxes!");
        }
    }
}
