using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Pounds";
            lbl2.Text = "Kilos";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Feet";
            lbl2.Text = "Meters";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = Convert.ToInt32(txt1.Text);
                a = a * 0.45359237;
                txt2.Text = a.ToString();
            }
            else
            {
                double a = Convert.ToInt32(txt1.Text);
                a = a * 0.3048;
                txt2.Text = a.ToString();
            }

        }
    }
}
