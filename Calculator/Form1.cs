using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int count, k=0; //для счётчика
        double i;
        double num1, num2, num3;
        double memory = 0; //переменная для памяти
        
        Size size_min = new Size(256, 325); //размер окна без инженерных функций
              
        //загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = size_min;
        }
        
        // Цифры от 0 до 9 //
        private void zero_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            textBox.Text += x.Text;

        } // 0 - 9
        private void point_Click(object sender, EventArgs e)
        {
            if(k == 0)
            textBox.Text += ",";
            k++;
        } //тчк
       
        //арифмитические операции
        private void plus_Click(object sender, EventArgs e)
        {
            k = 0;
            count = 1;
            if (textBox.Text == "")
            {
                num1 = Convert.ToInt32(0);
                textBox.Text = "0";
            }
            else
                num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
        }
        private void div_Click(object sender, EventArgs e)
        {
            k = 0;
            count = 2;
            if (textBox.Text == "")
            {
                num1 = Convert.ToInt32(0);
                textBox.Text = "0";
            }
            else
                num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
        }
        private void mul_Click(object sender, EventArgs e)
        {
            k = 0;
            count = 3;
            if (textBox.Text == "")
            {
                num1 = Convert.ToInt32(0);
                textBox.Text = "0";
            }
            else
                num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
        }
        private void defect_Click(object sender, EventArgs e)
        {
            k = 0;
            if (textBox.Text == "0" || textBox.Text == "")
                textBox.Text = "0";
            else
            {
                count = 4;
                if (textBox.Text == "")
                {
                    num1 = Convert.ToInt32(0);
                    textBox.Text = "0";
                }
                else
                    num1 = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
            }
        }

        //попытка сделать фрактал
        private double Factorial(double n)
        {
            int res = 1;
            for (int j = 1; j <= n; j++)
            {
                res *= j;
            }
            return res;
        }

        //дробушка
        private void one_div_x_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox.Text);
            if (num1 != 0)
            {
                num2 = 1 / num1;
                textBox.Text = num2.ToString();
            }
            else
            {
                MessageBox.Show("Деление на 0\r\nОперанд стерт");
                textBox.Text = "";
            }
        }
        
        //сложные функции
        private void sqrt_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox.Text);
            if (num1 >= 0)
            {
                num2 = Math.Sqrt(num1);
                textBox.Text = num2.ToString();
            }
            else
            {
                MessageBox.Show("Отрицательный корень\r\nОперанд стерт");
                textBox.Text = "";
            }
        } //корень
        private void pow_two_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2= Math.Pow(num1,2);
            textBox.Text = num2.ToString();
        }  //возведение во 2 степень 
        private void pow_3_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Pow(num1, 3);
            textBox.Text = num2.ToString();
        }  //возведение в 3 степень 
        private void pow_x_y_Click(object sender, EventArgs e)
        {
            count = 5;
            num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
        }  //возведение в степень 
        private void log_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Log10(num1);
            textBox.Text = num2.ToString();
        }  //логорифм
        private void ln_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            if (num1 >= 0)
            {
                num2 = Math.Log(num1);
                textBox.Text = num2.ToString();
            }
            else
            {
                MessageBox.Show("Отрицательный Логарифм\r\nОперанд стерт");
                textBox.Text = "";
            }
        }  //натуральный логорифм
        private void factorial_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox.Text);
            num1 = Factorial(n);
            textBox.Text = num1.ToString();
        }  //факториал
        private void sqrt_3_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Pow(num1, (double)1 / 3);
            textBox.Text = num2.ToString();
        }  //корень 3-ий степени
        private void sqrt_y_Click(object sender, EventArgs e)
        {
            count = 6;
            num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
        }  //корень 2-ой степени
        private void powten_x_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Pow(10,num1);
            textBox.Text = num2.ToString();
        }  //10^x
        private void cos_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Cos(num1);
            textBox.Text = num2.ToString();
        }  //косинус
        private void sin_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Sin(num1);
            textBox.Text = num2.ToString();
        }  //синус
        private void tan_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Tan(num1);
            textBox.Text = num2.ToString();
        } //тангенс 
        private void pi_Click(object sender, EventArgs e)
        {
            textBox.Text = Math.PI.ToString();
        }  //котангенс 

        //знаки
        private void delete_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }
        private void rovno_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                num2 = Convert.ToInt32(0);
                textBox.Text = "0";
            }
            switch (count)
            {
                case 1:
                    num2 = Double.Parse(textBox.Text);
                    num3 = num1 + num2;
                    textBox.Text = num3.ToString();
                    break;
                case 2:
                    num2 = Double.Parse(textBox.Text);
                    if (num2 != 0)
                    {
                        num3 = num1 / num2;
                        textBox.Text = num3.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Деление на 0\r\nОперанд стерт");
                        textBox.Text = "";
                    }
                    break;
                case 3:
                    num2 = Double.Parse(textBox.Text);
                    num3 = num1 * num2;
                    textBox.Text = num3.ToString();
                    break;
                case 4:
                    num2 = Double.Parse(textBox.Text);
                    num3 = num1 - num2;
                    textBox.Text = num3.ToString();
                    break;
                case 5:
                    num2 = Double.Parse(textBox.Text);
                    num3 = Math.Pow(num1, num2);
                    textBox.Text = num3.ToString();
                    break;
                case 6:
                    num2 = Double.Parse(textBox.Text);
                    num3 = Math.Pow(num1, (double)1 / num2);
                    textBox.Text = num3.ToString();
                    break;
            }
        }
       
        //память
        private void memory_clearing_Click(object sender, EventArgs e)
        {
            memory = 0;
            textBox2.Text = "0";
        } //отчистить
        private void memory_record_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox2.Text;
        } //записать
        private void memory_set_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(textBox.Text);
            textBox2.Text = memory.ToString();
        } //взять
        private void memory_add_Click(object sender, EventArgs e)
        {
            double Num2;
            Num2 = Double.Parse(textBox.Text);
            memory = memory + Num2;
            textBox2.Text = memory.ToString();
        } //добавить
        private void memory_defected_Click(object sender, EventArgs e)
        {
            double Num2;
            Num2 = Double.Parse(textBox.Text);
            memory = memory - Num2;
            textBox2.Text = memory.ToString();
        }

        //переключение на инженерные функции
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.Size = new Size(385, 325);
            }
            else
            {
                this.Size = new Size(256, 325);
            }
        } 
           
        //смена знака
        private void buttonSmena_Click(object sender, EventArgs e)
        {
            double z;
            if (double.TryParse(this.textBox.Text, out z))
            {
                z = -z;
                this.textBox.Text = z.ToString();
            }
        }
        
        //удаление последнего символа
        private void buttonBack_Click(object sender, EventArgs e)
        {
            string s;
            s = this.textBox.Text;
            if (s != "")
            {
                s = s.Remove(s.Length - 1, 1);
                this.textBox.Text = s;
            }
        }

       
    }
}
