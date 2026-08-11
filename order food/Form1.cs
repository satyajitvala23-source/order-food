using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order_food
{
    public partial class Form1 : Form
    {
      public  int total = 0,total2=0,total3=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (comboBox2.SelectedIndex == 0)
            {
                total = 250;
                textBox1.Text = total.ToString();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                total = 300;
                textBox1.Text = total.ToString();

            }
            if (comboBox2.SelectedIndex == 2)
            {
                total = 150;
                textBox1.Text = total.ToString();

            }
            if (comboBox2.SelectedIndex == 3)
            {
                total = 100;
                textBox1.Text = total.ToString();

            }
            if (comboBox2.SelectedIndex == 4)
            {
                total = 250;
                textBox1.Text = total.ToString();

            }
            if (comboBox2.SelectedIndex == 5)
            {
                total = 15;
                textBox1.Text = total.ToString();

            }
            if (comboBox2.SelectedIndex == 6)
            {
                total = 10;
                textBox1.Text = total.ToString();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int q = 0;
            q = Convert.ToInt16(textBox2.Text);
            total = total * q;
            if(checkBox1.Checked==true)
            {
                total += 30;
            }
            if (checkBox2.Checked == true)
            {
                total += 50;
            }
            if (checkBox3.Checked == true)
            {
                total += 10;
            }
            if (radioButton2.Checked == true)
            {
                total += 20;
            }
            textBox3.Text= total.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int q = 0;
            q = Convert.ToInt16(textBox5.Text);
            total2 = total2 * q;
            if (checkBox6.Checked == true)
            {
                total2 += 30;
            }
            if (checkBox5.Checked == true)
            {
                total2 += 50;
            }
            if (checkBox4.Checked == true)
            {
                total2 += 10;
            }
            if (radioButton3.Checked == true)
            {
                total2 += 20;
            }
            textBox4.Text = total2.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                total3 = 250;
                textBox9.Text = total3.ToString();
            }
            if (comboBox4.SelectedIndex == 1)
            {
                total3 = 300;
                textBox9.Text = total3.ToString();

            }
            if (comboBox4.SelectedIndex == 2)
            {
                total3 = 150;
                textBox9.Text = total3.ToString();

            }
            if (comboBox4.SelectedIndex == 3)
            {
                total3 = 100;
                textBox9.Text = total3.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int q = 0;
            q = Convert.ToInt16(textBox8.Text);
            total3 = total3 * q;
            if (checkBox9.Checked == true)
            {
                total3 += 30;
            }
            if (checkBox8.Checked == true)
            {
                total3 += 50;
            }
            if (checkBox7.Checked == true)
            {
                total3 += 10;
            }
            if (radioButton5.Checked == true)
            {
                total3 += 20;
            }
            textBox7.Text = total3.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                panel1.Visible = true;
                panel4.Visible = false;
                panel7.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                panel4.Visible = true;
                panel1.Visible = false;
                panel7.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                panel7.Visible = true;
                panel1.Visible = false;
                panel4.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                total2 = 250;
                textBox6.Text = total2.ToString();
            }
            if (comboBox3.SelectedIndex == 1)
            {
                total2 = 300;
                textBox6.Text = total2.ToString();

            }
            if (comboBox3.SelectedIndex == 2)
            {
                total2 = 150;
                textBox6.Text = total2.ToString();

            }
            if (comboBox3.SelectedIndex == 3)
            {
                total2 = 100;
                textBox6.Text = total2.ToString();

            }
        }
    }
}
