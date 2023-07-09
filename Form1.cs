using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_лаба
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int b1 = Convert.ToInt32(textBox1.Text, 2);
                int b2 = Convert.ToInt32(textBox2.Text, 2);
                textBox3.Text = Convert.ToString(b1 & b2, 2);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int b1 = Convert.ToInt32(textBox1.Text, 2);
                int b2 = Convert.ToInt32(textBox2.Text, 2);
                textBox3.Text = Convert.ToString(b1 | b2, 2);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int b1 = Convert.ToInt32(textBox1.Text, 2);
                int b2 = Convert.ToInt32(textBox2.Text, 2);
                textBox3.Text = Convert.ToString(b1 ^ b2, 2);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    int b1 = Convert.ToInt32(textBox1.Text, 2);
                    int count = textBox1.Text.Length;
                    string text = Convert.ToString(~b1, 2);
                    text = text.Substring(text.Length - count);
                    textBox3.Text = text;
                }
                if (textBox2.Text.Length != 0)
                {
                    int b2 = Convert.ToInt32(textBox2.Text, 2);
                    int count = textBox2.Text.Length;
                    string text = Convert.ToString(~b2, 2);
                    text = text.Substring(text.Length - count);
                    textBox3.Text = text;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int i1 = Convert.ToInt32(textBox3.Text, 2);
                textBox4.Text = Convert.ToString(i1, 8);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int i1 = Convert.ToInt32(textBox3.Text, 2);
                textBox4.Text = Convert.ToString(i1, 16);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {try
            {
                int i1 = Convert.ToInt32(textBox3.Text, 2);
                textBox4.Text = Convert.ToString(i1, 2);
            }
            catch { Console.WriteLine("Ошибка"); }        }

        private void button11_Click(object sender, EventArgs e)
        {try
            {
                int i1 = Convert.ToInt32(textBox3.Text, 2);
                textBox4.Text = Convert.ToString(i1, 10);
            }
            catch { Console.WriteLine("Ошибка"); }        }
    }
}
