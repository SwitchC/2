using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using figure;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            unVisible();
        }
        private void unVisible()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//трикутник
        {
            unVisible();
            label2.Text = "Введіть сторону а";
            label3.Text = "Введіть сторону d";
            label4.Text = "Введіть сторону c";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            double a, b, c;
            if ((textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != ""))
            {
                try
                {
                    a = Convert.ToDouble(textBox2.Text);
                    b = Convert.ToDouble(textBox3.Text);
                    c = Convert.ToDouble(textBox4.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Не вірний формат");
                    return;
                }
                if (a <= 0 || b <= 0 || c <= 0)
                { MessageBox.Show("Не вірний формат"); return; }
                if ((a >= b + c) || (c >= a + b) || (b >= c + a))
                {
                    MessageBox.Show("Трикутник не існує");
                    return;
                }
                else
                {
                    triangle abc = new triangle();
                    abc.a = a;
                    abc.b = b;
                    abc.c = c;
                    label7.Visible = true;
                    label9.Visible = true;
                    label7.Text = Convert.ToString(abc.perimeter());
                    label9.Text = Convert.ToString(abc.area());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//круг
        {
            unVisible();
            label3.Text = "Введіть радіус";
            label3.Visible = true;
            textBox3.Visible = true;
            double r;
            if (textBox3.Text != "")
            {
                try
                {
                    r = Convert.ToDouble(textBox3.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Не вірний формат");
                    return;
                }
                if (r<=0)
                { MessageBox.Show("Коло не існує"); }
                else
                {
                    circle c1 = new circle();
                    c1.r = r;
                    label7.Visible = true;
                    label9.Visible = true;
                    label7.Text = Convert.ToString(c1.perimeter());
                    label9.Text = Convert.ToString(c1.area());
                }
            }



        }

        private void button3_Click(object sender, EventArgs e)//прямокутник
        {
            unVisible();
            label2.Text = "Введіть сторону а";
            label2.Visible = true;
            textBox2.Visible = true;
            label4.Text = "Введіть сторону b";
            label4.Visible = true;
            textBox4.Visible = true;
            double a,b;
            if ((textBox2.Text != "") && (textBox4.Text != ""))
            {
                try
                {
                    a = Convert.ToDouble(textBox2.Text);
                    b = Convert.ToDouble(textBox4.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Не вірний формат");
                    return;
                }
                if (a <= 0 || b<=0)
                { MessageBox.Show("прямокутник не існує"); }
                else
                {
                    rectangle r1 = new rectangle();
                    r1.a = a;
                    r1.b = b;
                    label7.Visible = true;
                    label9.Visible = true;
                    label7.Text = Convert.ToString(r1.perimeter());
                    label9.Text = Convert.ToString(r1.area());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)//квадрат
        {
            unVisible();
            label3.Text = "Введіть сторону";
            label3.Visible = true;
            textBox3.Visible = true;
            double a;
            if (textBox3.Text != "")
            {
                try
                {
                    a = Convert.ToDouble(textBox3.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Не вірний формат");
                    return;
                }
                if (a <= 0)
                { MessageBox.Show("Квадрат не існує"); }
                else
                {
                    square s1 = new square();
                    s1.a = a;
                    label7.Visible = true;
                    label9.Visible = true;
                    label7.Text = Convert.ToString(s1.perimeter());
                    label9.Text = Convert.ToString(s1.area());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)//ромб
        {
            unVisible();
            label1.Text = "Введіть сторону ";
            label1.Visible = true;
            textBox1.Visible = true;
            label5.Text = "Введіть кут";
            label5.Visible = true;
            textBox5.Visible = true;
            double a, t;
            if ((textBox1.Text != "") && (textBox5.Text != ""))
            {
                try
                {
                    a = Convert.ToDouble(textBox1.Text);
                    t = Convert.ToDouble(textBox5.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Не вірний формат");
                    return;
                }
                if (a <= 0 || t <= 0)
                { MessageBox.Show("Ромб не існує"); }
                else
                {
                    rhomb r1 = new rhomb();
                    r1.a = a;
                    r1.t = t;
                    label7.Visible = true;
                    label9.Visible = true;
                    label7.Text = Convert.ToString(r1.perimeter());
                    label9.Text = Convert.ToString(r1.area());
                }
            }
        }
    }
}
