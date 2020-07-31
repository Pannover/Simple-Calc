using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calc : Form
    {
        string firstN = null;                       // Первое число
        string lastN = null;                        // Второе число
        string oper = null;                         // Оператор
        public double result = 0;                   // Результат
        bool flag = false;                          // Флаг указывающий на то что был нажат оператор (+; -; *; /)
        bool flagComma = false;                     // Флаг запятой в первом числе
        bool flagComma1 = false;                    // Флаг запятой во втором числе

        public double Result { get; set; }

        public Calc()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void ClicNumButton(int i)
        {
            if (flag == false)
            {
                firstN += i;
                textBox1.Text = firstN;
            }
            else
            {
                lastN += i;
                textBox1.Text = lastN;
            }
        }        

        private void buttonDel_Click(object sender, EventArgs e) // Обработчик кнопки "/"
        {
            if (firstN != null)
            {
                flag = true;
                textBox1.Text = "/";
                oper = "/";
            }           
        }

        private void buttonUm_Click(object sender, EventArgs e) // Обработчик кнопки "*"
        {
            if (firstN != null)
            {
                flag = true;
                textBox1.Text = "*";
                oper = "*";
            }           
        }

        private void buttonSum_Click(object sender, EventArgs e)    // Обработчик кнопки "+"
        {
            if (firstN != null)
            {
                 flag = true;
                textBox1.Text = "+";
                oper = "+";
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)    // Обработчик кнопки "-"
        {
            if (firstN != null)
            {
                flag = true;
                textBox1.Text = "-";
                oper = "-";
            }
        }

        private void buttonTotal_Click(object sender, EventArgs e) // Обработчик кнопки "="
        {
            if (oper == "/")
            {
                double a = Convert.ToDouble(firstN);
                double b = Convert.ToDouble(lastN);

                if (b == 0)
                {
                    MessageBox.Show("Деление на 0 не допустимо!");
                }
                else
                {
                    Result = a / b;
                    textBox1.Text = Convert.ToString(Result);
                }

            }

            if (oper == "*")
            {
                double a = Convert.ToDouble(firstN);
                double b = Convert.ToDouble(lastN);
                Result = a * b;
                textBox1.Text = Convert.ToString(Result);
            }

            if (oper == "+")
            {
                double a = Convert.ToDouble(firstN);
                double b = Convert.ToDouble(lastN);
                Result = a + b;
                textBox1.Text = Convert.ToString(Result);
            }

            if (oper == "-")
            {
                double a = Convert.ToDouble(firstN);
                double b = Convert.ToDouble(lastN);
                Result = a - b;
                textBox1.Text = Convert.ToString(Result);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)  // Обработчик кнопки "C"
        {
            textBox1.Text = "0";
            Result = 0;
            firstN = null;
            lastN = null;
            oper = null;
            flag = false;
            flagComma = false;
            flagComma1 = false;
        }

        private void button1_Click(object sender, EventArgs e) // Обработчик кнокпи "1"
        {
            ClicNumButton(1);
        }

        private void button2_Click(object sender, EventArgs e) // Обработчик кнопки "2"
        {
            ClicNumButton(2);
        }

        private void button3_Click(object sender, EventArgs e)  // Обработчик кнопки "3"
        {
            ClicNumButton(3);
        }

        private void button4_Click(object sender, EventArgs e)  // Обработчик кнопки "4"
        {
            ClicNumButton(4);
        }

        private void button5_Click(object sender, EventArgs e)  // Обработчик кнопки "5"
        {
            ClicNumButton(5);
        }

        private void button6_Click(object sender, EventArgs e)  // Обработчик кнопки "6"
        {
            ClicNumButton(6);
        }

        private void button7_Click(object sender, EventArgs e)  // Обработчик кнопки "7"
        {
            ClicNumButton(7);
        }

        private void button8_Click(object sender, EventArgs e)  // Обработчик кнопки "8"
        {
            ClicNumButton(8);
        }

        private void button9_Click(object sender, EventArgs e)  // Обработчик кнопки "9"
        {
            ClicNumButton(9);
        }

        private void button0_Click(object sender, EventArgs e)  // Обработчик кнопки "0"
        {
            ClicNumButton(0);
        }

        private void buttonComma_Click(object sender, EventArgs e)  // Обработчик кнопки ","
        {
            if (firstN != null)
            {
                if (firstN.Contains(",") == false)
                {
                    if (flagComma == false)
                    {
                        if (flag == false)
                        {
                            firstN += ",";
                            textBox1.Text = firstN;
                            flagComma = true;
                        }
                    }
                }
            }

            if (lastN != null)
            {
                if (lastN.Contains(",") == false)
                {
                    if (flagComma1 == false)
                    {
                        if (flag == true)
                        {
                            lastN += ",";
                            textBox1.Text = lastN;
                            flagComma1 = true;
                        }
                    }
                }
            }

         }
  
    }

}
