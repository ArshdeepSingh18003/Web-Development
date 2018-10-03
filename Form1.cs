using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //
                string classA, classB, classC;
                double A, B, C;

                classA = textBox1.Text;
                classB = textBox2.Text;
                classC = textBox3.Text;

                A = double.Parse(classA);
                B = double.Parse(classB);
                C = double.Parse(classC);

                double cal1;
                cal1 = A * 15;
                textBox4.Text = cal1.ToString("C");

                double cal2;
                cal2 = B * 12;
                textBox5.Text = cal2.ToString("C");

                double cal3;
                cal3 = C * 9;
                textBox6.Text = cal3.ToString("C");

                double total;
                total = cal1 + cal2 + cal3;
                textBox7.Text = total.ToString("C");

            }
            catch (Exception ab)
            {
                MessageBox.Show("Handle Exception");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        //nothing
        //comment
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
