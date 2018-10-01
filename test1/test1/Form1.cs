using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Peryearmargin,Propertyvalue;
            Double perm,prov;

            Peryearmargin = textBox1.Text;
            Propertyvalue = textBox2.Text;

            perm = double.Parse(Peryearmargin);
            prov = double.Parse(Propertyvalue);

            

            prov = prov / perm * 0.64;
            textBox3.Text = (prov). ToString();


                 
        }
    }
}
