using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        //0 - +
        //1 - -
        //2 - *
        //3 - /
        //4 - %
        //5 - sqrt
        //6 - ^2
        //7 - 1/x
        double a=0, b=0, c=0, d=0;
        int numAfterDotA = 0;
        bool floate = false;
        int lastAction = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "±";
            button11.Text = "0";
            button12.Text = ".";
            button13.Text = "x";
            button14.Text = "÷";
            button15.Text = "+";
            button16.Text = "-";
            button17.Text = "CE";
            button18.Text = "C";
            button19.Text = "=";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                a += 1;
            }
            else
            {
                    for (int i = 0; i < numAfterDotA + 1; ++i)
                    {
                        a *= 10;
                    }
                    a += 1;
                    numAfterDotA++;
                    for (int i = 0; i < numAfterDotA; ++i)
                    {
                        a /= 10;
                    }
            }
            textBox1.Text = a.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                a += 2;
            }
            else
            {
                for (int i = 0; i < numAfterDotA + 1; ++i)
                {
                    a *= 10;
                }
                a += 2;
                numAfterDotA++;
                for (int i = 0; i < numAfterDotA; ++i)
                {
                    a /= 10;
                }
            }
            textBox1.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                a += 3;
            }
            else
            {
                for (int i = 0; i < numAfterDotA + 1; ++i)
                {
                    a *= 10;
                }
                a += 3;
                numAfterDotA++;
                for (int i = 0; i < numAfterDotA; ++i)
                {
                    a /= 10;
                }
            }
            textBox1.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                a += 4;
            }
            else
            {
                for (int i = 0; i < numAfterDotA + 1; ++i)
                {
                    a *= 10;
                }
                a += 4;
                numAfterDotA++;
                for (int i = 0; i < numAfterDotA; ++i)
                {
                    a /= 10;
                }
            }
            textBox1.Text = a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                a += 5;
            }
            else
            {
                for (int i = 0; i < numAfterDotA + 1; ++i)
                {
                    a *= 10;
                }
                a += 5;
                numAfterDotA++;
                for (int i = 0; i < numAfterDotA; ++i)
                {
                    a /= 10;
                }
            }
            textBox1.Text = a.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                a += 6;
            }
            else
            {
                for (int i = 0; i < numAfterDotA + 1; ++i)
                {
                    a *= 10;
                }
                a += 6;
                numAfterDotA++;
                for (int i = 0; i < numAfterDotA; ++i)
                {
                    a /= 10;
                }
            }
            textBox1.Text = a.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                a += 7;
            }
            else
            {
                for (int i = 0; i < numAfterDotA + 1; ++i)
                {
                    a *= 10;
                }
                a += 7;
                numAfterDotA++;
                for (int i = 0; i < numAfterDotA; ++i)
                {
                    a /= 10;
                }
            }
            textBox1.Text = a.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                a += 8;
            }
            else
            {
                for (int i = 0; i < numAfterDotA + 1; ++i)
                {
                    a *= 10;
                }
                a += 8;
                numAfterDotA++;
                for (int i = 0; i < numAfterDotA; ++i)
                {
                    a /= 10;
                }
            }
            textBox1.Text = a.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                a += 9;
            }
            else
            {
                for (int i = 0; i < numAfterDotA + 1; ++i)
                {
                    a *= 10;
                }
                a += 9;
                numAfterDotA++;
                for (int i = 0; i < numAfterDotA; ++i)
                {
                    a /= 10;
                }
            }
            textBox1.Text = a.ToString();
        }

        

        private void button10_Click(object sender, EventArgs e)
        {
            a *= (-1);
            textBox1.Text = a.ToString();
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            if (!floate)
            {
                a *= 10;
                textBox1.Text = a.ToString();
            }
            else
            {
                numAfterDotA++;
                textBox1.Text = a.ToString() + '0';
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            floate = true;
            textBox1.Text = a.ToString() + '.';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lastAction = 2;
            b = a;
            c = 0;
            a = 0;
            textBox1.Text = a.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lastAction = 3;
            b = a;
            c = 0;
            a = 0;
            textBox1.Text = a.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lastAction = 0;
            b = a;
            c = 0;
            a = 0;
            textBox1.Text = a.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lastAction = 1;
            b = a;
            c = 0;
            a = 0;
            textBox1.Text = a.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            numAfterDotA = 0;
            floate = false;
            textBox1.Text = a.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = 0;
            numAfterDotA = 0;
            floate = false;
            textBox1.Text = a.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (lastAction)
            {
                case 0:
                    {
                        if (c != 0) a += c;
                        else { c = a; a += b; }
                        textBox1.Text = a.ToString();
                        break;
                    }
                case 1:
                    {
                        if (c != 0) a -= c;
                        else { c = a; a = b-a; }
                        textBox1.Text = a.ToString();
                        break;
                    }
                case 2:
                    {
                        if (c != 0) a *= c;
                        else { c = a; a *= b; }
                        textBox1.Text = a.ToString();
                        break;
                    }
                case 3:
                    {
                        if (c != 0) a /= c;
                        else
                        {
                            if (a != 0)
                            {
                                c = a; a = b / a;
                            }
                            else
                            {
                                a = 0;
                                b = 0;
                                c = 0;
                                numAfterDotA = 0;
                                floate = false;
                                textBox1.Text = "Douchbag, you can't divide on 0";
                                break;
                            }
                        }
                        textBox1.Text = a.ToString();
                        break;
                    }
                case 4:
                    {
                        a = b * a / 100;
                        textBox1.Text = a.ToString();
                        break;
                    }
                case 5:
                    {
                        a = Math.Sqrt(a);
                        textBox1.Text = a.ToString();
                        break;
                    }
                case 6:
                    {
                        a = a*a;
                        textBox1.Text = a.ToString();
                        break;
                    }
                case 7:
                    {
                        a = 1/a;
                        textBox1.Text = a.ToString();
                        break;
                    }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            lastAction = 4;
            b = a;
            a = 0;
            c = 0;
            textBox1.Text = a.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lastAction = 5;
            a = Math.Sqrt(a);
            c = 0;
            textBox1.Text = a.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            lastAction = 6;
            a = a*a;
            c = 0;
            textBox1.Text = a.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            lastAction = 7;
            a = 1/a;
            c = 0;
            textBox1.Text = a.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            d = a;
            b = a;
            a = 0;
            c = 0;
            numAfterDotA = 0;
            floate = false;
            textBox1.Text = a.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a += d;
            textBox1.Text = a.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            a -= d;
            textBox1.Text = a.ToString();
        }
    }
}
