using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int a=0, b=0, d=0, k=0, f=0, g=0, h=0,i=0, j=0,m=0;
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button10.Text = "Play Again!!!";
            this.button11.Text = "----Quit-----";
            this.label6.Text = "Your score must be greater then 150 if you want to win:";
            this.BackColor = Color.Yellow;
            this.button1.ForeColor = Color.Black;
            this.button1.BackColor = Color.White;
            this.button2.ForeColor = Color.Black;
            this.button2.BackColor = Color.White;
            this.button3.ForeColor = Color.Black;
            this.button3.BackColor = Color.White;
            this.button4.ForeColor = Color.Black;
            this.button4.BackColor = Color.White;
            this.button5.ForeColor = Color.Black;
            this.button5.BackColor = Color.White;
            this.button6.ForeColor = Color.Black;
            this.button6.BackColor = Color.White;
            this.button7.ForeColor = Color.Black;
            this.button7.BackColor = Color.White;
            this.button8.ForeColor = Color.Black;
            this.button8.BackColor = Color.White;
            this.button9.ForeColor = Color.Black;
            this.button9.BackColor = Color.White;
            this.Text = "Game";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 44;
            this.button1.ForeColor = Color.White;
            this.button1.BackColor = Color.Black;
            this.button1.Text = "?";
            c++;
            this.button1.Enabled = false;
            if (c == 3)
            {
                this.button1.Text = "44";
                this.button2.Text = "32";
                this.button3.Text = "12";
                this.button4.Text = "77";
                this.button5.Text = "55";
                this.button6.Text = "45";
                this.button7.Text = "67";
                this.button8.Text = "87";
                this.button9.Text = "66"; 
                this.label3.Text = "All Buttons are Disabled";
                this.button1.ForeColor = Color.Black;
                this.button1.BackColor = Color.Red;
                this.button2.ForeColor = Color.Black;
                this.button2.BackColor = Color.Red;
                this.button3.ForeColor = Color.Black;
                this.button3.BackColor = Color.Red;
                this.button4.ForeColor = Color.Black;
                this.button4.BackColor = Color.Red;
                this.button5.ForeColor = Color.Black;
                this.button5.BackColor = Color.Red;
                this.button6.ForeColor = Color.Black;
                this.button6.BackColor = Color.Red;
                this.button7.ForeColor = Color.Black;
                this.button7.BackColor = Color.Red;
                this.button8.ForeColor = Color.Black;
                this.button8.BackColor = Color.Red;
                this.button9.ForeColor = Color.Black;
                this.button9.BackColor = Color.Red;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                m = a + b + d + k + f + g + h + i + j;
                if (m > 150)
                {
                    MessageBox.Show("Your Score is " + m + ".You are win.");
                }
                else
                {
                    MessageBox.Show("Your Score is  " + m + ".You are lost " + ".Game Over ");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = 32;
            this.button2.ForeColor = Color.White;
            this.button2.BackColor = Color.Black;
            this.button2.Text = "?";
            this.button2.Enabled = false;
            c++;
            if (c == 3)
            {
                this.button1.Text = "44";
                this.button2.Text = "32";
                this.button3.Text = "12";
                this.button4.Text = "77";
                this.button5.Text = "55";
                this.button6.Text = "45";
                this.button7.Text = "67";
                this.button8.Text = "87";
                this.button9.Text = "66"; 
                this.label3.Text = "All Buttons are Disabled";
                this.button1.ForeColor = Color.Black;
                this.button1.BackColor = Color.Red;
                this.button2.ForeColor = Color.Black;
                this.button2.BackColor = Color.Red;
                this.button3.ForeColor = Color.Black;
                this.button3.BackColor = Color.Red;
                this.button4.ForeColor = Color.Black;
                this.button4.BackColor = Color.Red;
                this.button5.ForeColor = Color.Black;
                this.button5.BackColor = Color.Red;
                this.button6.ForeColor = Color.Black;
                this.button6.BackColor = Color.Red;
                this.button7.ForeColor = Color.Black;
                this.button7.BackColor = Color.Red;
                this.button8.ForeColor = Color.Black;
                this.button8.BackColor = Color.Red;
                this.button9.ForeColor = Color.Black;
                this.button9.BackColor = Color.Red;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                m = a + b + d + k + f + g + h + i + j;
                if (m > 150)
                {
                    MessageBox.Show("Your Score is " + m + ".You are win.");
                }
                else
                {
                    MessageBox.Show("Your Score is  " + m + ".You are lost " + ".Game Over ");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d = 12;
            this.button3.ForeColor = Color.White;
            this.button3.BackColor = Color.Black;
            this.button3.Text = "?";
            this.button3.Enabled = false;
            c++;
            if (c == 3)
            {
                this.button1.Text = "44";
                this.button2.Text = "32";
                this.button3.Text = "12";
                this.button4.Text = "77";
                this.button5.Text = "55";
                this.button6.Text = "45";
                this.button7.Text = "67";
                this.button8.Text = "87";
                this.button9.Text = "66"; 
                this.label3.Text = "All Buttons are Disabled";
                this.button1.ForeColor = Color.Black;
                this.button1.BackColor = Color.Red;
                this.button2.ForeColor = Color.Black;
                this.button2.BackColor = Color.Red;
                this.button3.ForeColor = Color.Black;
                this.button3.BackColor = Color.Red;
                this.button4.ForeColor = Color.Black;
                this.button4.BackColor = Color.Red;
                this.button5.ForeColor = Color.Black;
                this.button5.BackColor = Color.Red;
                this.button6.ForeColor = Color.Black;
                this.button6.BackColor = Color.Red;
                this.button7.ForeColor = Color.Black;
                this.button7.BackColor = Color.Red;
                this.button8.ForeColor = Color.Black;
                this.button8.BackColor = Color.Red;
                this.button9.ForeColor = Color.Black;
                this.button9.BackColor = Color.Red;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                m = a + b + d + k + f + g + h + i + j;
                if (m > 150)
                {
                    MessageBox.Show("Your Score is " + m + ".You are win.");
                }
                else
                {
                    MessageBox.Show("Your Score is  " + m + ".You are lost " + ".Game Over ");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            k = 77;
            this.button4.ForeColor = Color.White;
            this.button4.BackColor = Color.Black;
            this.button4.Text = "?";
            this.button3.Enabled = false;
            c++;
            if (c == 3)
            {
                this.button1.Text = "44";
                this.button2.Text = "32";
                this.button3.Text = "12";
                this.button4.Text = "77";
                this.button5.Text = "55";
                this.button6.Text = "45";
                this.button7.Text = "67";
                this.button8.Text = "87";
                this.button9.Text = "66"; 
                this.label3.Text = "All Buttons are Disabled";
                this.button1.ForeColor = Color.Black;
                this.button1.BackColor = Color.Red;
                this.button2.ForeColor = Color.Black;
                this.button2.BackColor = Color.Red;
                this.button3.ForeColor = Color.Black;
                this.button3.BackColor = Color.Red;
                this.button4.ForeColor = Color.Black;
                this.button4.BackColor = Color.Red;
                this.button5.ForeColor = Color.Black;
                this.button5.BackColor = Color.Red;
                this.button6.ForeColor = Color.Black;
                this.button6.BackColor = Color.Red;
                this.button7.ForeColor = Color.Black;
                this.button7.BackColor = Color.Red;
                this.button8.ForeColor = Color.Black;
                this.button8.BackColor = Color.Red;
                this.button9.ForeColor = Color.Black;
                this.button9.BackColor = Color.Red;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                m = a + b + d + k + f + g + h + i + j;
                if (m > 150)
                {
                    MessageBox.Show("Your Score is " + m + ".You are win.");
                }
                else
                {
                    MessageBox.Show("Your Score is  " + m + ".You are lost " + ".Game Over ");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f = 55;
            this.button5.ForeColor = Color.White;
            this.button5.BackColor = Color.Black;
            this.button5.Text = "?";
            this.button4.Enabled = false;
            c++;
            if (c == 3)
            {
                this.button1.Text = "44";
                this.button2.Text = "32";
                this.button3.Text = "12";
                this.button4.Text = "77";
                this.button5.Text = "55";
                this.button6.Text = "45";
                this.button7.Text = "67";
                this.button8.Text = "87";
                this.button9.Text = "66"; 
                this.label3.Text = "All Buttons are Disabled";
                this.button1.ForeColor = Color.Black;
                this.button1.BackColor = Color.Red;
                this.button2.ForeColor = Color.Black;
                this.button2.BackColor = Color.Red;
                this.button3.ForeColor = Color.Black;
                this.button3.BackColor = Color.Red;
                this.button4.ForeColor = Color.Black;
                this.button4.BackColor = Color.Red;
                this.button5.ForeColor = Color.Black;
                this.button5.BackColor = Color.Red;
                this.button6.ForeColor = Color.Black;
                this.button6.BackColor = Color.Red;
                this.button7.ForeColor = Color.Black;
                this.button7.BackColor = Color.Red;
                this.button8.ForeColor = Color.Black;
                this.button8.BackColor = Color.Red;
                this.button9.ForeColor = Color.Black;
                this.button9.BackColor = Color.Red;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                m = a + b + d + k + f + g + h + i + j;
                if (m > 150)
                {
                    MessageBox.Show("Your Score is " + m + ".You are win.");
                }
                else
                {
                    MessageBox.Show("Your Score is  " + m + ".You are lost " + ".Game Over ");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g = 45;
            this.button6.ForeColor = Color.White;
            this.button6.BackColor = Color.Black;
            this.button6.Text = "?";
            this.button6.Enabled = false;
            c++;
            if (c == 3)
            {
                this.button1.Text = "44";
                this.button2.Text = "32";
                this.button3.Text = "12";
                this.button4.Text = "77";
                this.button5.Text = "55";
                this.button6.Text = "45";
                this.button7.Text = "67";
                this.button8.Text = "87";
                this.button9.Text = "66"; 
                this.label3.Text = "All Buttons are Disabled";
                this.button1.ForeColor = Color.Black;
                this.button1.BackColor = Color.Red;
                this.button2.ForeColor = Color.Black;
                this.button2.BackColor = Color.Red;
                this.button3.ForeColor = Color.Black;
                this.button3.BackColor = Color.Red;
                this.button4.ForeColor = Color.Black;
                this.button4.BackColor = Color.Red;
                this.button5.ForeColor = Color.Black;
                this.button5.BackColor = Color.Red;
                this.button6.ForeColor = Color.Black;
                this.button6.BackColor = Color.Red;
                this.button7.ForeColor = Color.Black;
                this.button7.BackColor = Color.Red;
                this.button8.ForeColor = Color.Black;
                this.button8.BackColor = Color.Red;
                this.button9.ForeColor = Color.Black;
                this.button9.BackColor = Color.Red;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                m = a + b + d + k + f + g + h + i + j;
                if (m > 150)
                {
                    MessageBox.Show("Your Score is " + m + ".You are win.");
                }
                else
                {
                    MessageBox.Show("Your Score is  " + m + ".You are lost " + ".Game Over ");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            h = 67;
            this.button7.ForeColor = Color.White;
            this.button7.BackColor = Color.Black;
            this.button7.Text = "?";
            this.button7.Enabled = false;
            c++;
            if (c == 3)
            {
                this.button1.Text = "44";
                this.button2.Text = "32";
                this.button3.Text = "12";
                this.button4.Text = "77";
                this.button5.Text = "55";
                this.button6.Text = "45";
                this.button7.Text = "67";
                this.button8.Text = "87";
                this.button9.Text = "66"; 
                this.label3.Text = "All Buttons are Disabled";
                this.button1.ForeColor = Color.Black;
                this.button1.BackColor = Color.Red;
                this.button2.ForeColor = Color.Black;
                this.button2.BackColor = Color.Red;
                this.button3.ForeColor = Color.Black;
                this.button3.BackColor = Color.Red;
                this.button4.ForeColor = Color.Black;
                this.button4.BackColor = Color.Red;
                this.button5.ForeColor = Color.Black;
                this.button5.BackColor = Color.Red;
                this.button6.ForeColor = Color.Black;
                this.button6.BackColor = Color.Red;
                this.button7.ForeColor = Color.Black;
                this.button7.BackColor = Color.Red;
                this.button8.ForeColor = Color.Black;
                this.button8.BackColor = Color.Red;
                this.button9.ForeColor = Color.Black;
                this.button9.BackColor = Color.Red;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                m = a + b + d + k + f + g + h + i + j;
                if (m > 150)
                {
                    MessageBox.Show("Your Score is " + m + ".You are win.");
                }
                else
                {
                    MessageBox.Show("Your Score is  " + m + ".You are lost " + ".Game Over ");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            i = 87;
            this.button8.ForeColor = Color.White;
            this.button8.BackColor = Color.Black;
            this.button8.Text = "?";
            this.button8.Enabled = false;
            c++;
            if (c == 3)
            {
                this.button1.Text = "44";
                this.button2.Text = "32";
                this.button3.Text = "12";
                this.button4.Text = "77";
                this.button5.Text = "55";
                this.button6.Text = "45";
                this.button7.Text = "67";
                this.button8.Text = "87";
                this.button9.Text = "66"; 
                this.label3.Text = "All Buttons are Disabled";
                this.button1.ForeColor = Color.Black;
                this.button1.BackColor = Color.Red;
                this.button2.ForeColor = Color.Black;
                this.button2.BackColor = Color.Red;
                this.button3.ForeColor = Color.Black;
                this.button3.BackColor = Color.Red;
                this.button4.ForeColor = Color.Black;
                this.button4.BackColor = Color.Red;
                this.button5.ForeColor = Color.Black;
                this.button5.BackColor = Color.Red;
                this.button6.ForeColor = Color.Black;
                this.button6.BackColor = Color.Red;
                this.button7.ForeColor = Color.Black;
                this.button7.BackColor = Color.Red;
                this.button8.ForeColor = Color.Black;
                this.button8.BackColor = Color.Red;
                this.button9.ForeColor = Color.Black;
                this.button9.BackColor = Color.Red;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                m = a + b + d + k + f + g + h + i + j;
                if (m > 150)
                {
                    MessageBox.Show("Your Score is " + m + ".You are win.");
                }
                else
                {
                    MessageBox.Show("Your Score is  " + m + ".You are lost " + ".Game Over ");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            j = 66;
            this.button9.ForeColor = Color.White;
            this.button9.BackColor = Color.Black;
            this.button9.Text = "?";
            this.button9.Enabled = false;
            c++;
            if (c == 3)
            {
                this.button1.Text = "44";
                this.button2.Text = "32";
                this.button3.Text = "12";
                this.button4.Text = "77";
                this.button5.Text = "55";
                this.button6.Text = "45";
                this.button7.Text = "67";
                this.button8.Text = "87";
                this.button9.Text = "66";
                this.label3.Text = "All Buttons are Disabled";
                this.button1.ForeColor = Color.Black;
                this.button1.BackColor = Color.Red;
                this.button2.ForeColor = Color.Black;
                this.button2.BackColor = Color.Red;
                this.button3.ForeColor = Color.Black;
                this.button3.BackColor = Color.Red;
                this.button4.ForeColor = Color.Black;
                this.button4.BackColor = Color.Red;
                this.button5.ForeColor = Color.Black;
                this.button5.BackColor = Color.Red;
                this.button6.ForeColor = Color.Black;
                this.button6.BackColor = Color.Red;
                this.button7.ForeColor = Color.Black;
                this.button7.BackColor = Color.Red;
                this.button8.ForeColor = Color.Black;
                this.button8.BackColor = Color.Red;
                this.button9.ForeColor = Color.Black;
                this.button9.BackColor = Color.Red;
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                m = a + b + d + k + f + g + h + i + j;
                if (m > 150)
                {
                    MessageBox.Show("Your Score is " + m + ".You are win.");
                }
                else
                {
                    MessageBox.Show("Your Score is  " + m + ".You are lost " + ".Game Over ");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            c = 0;
                
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
