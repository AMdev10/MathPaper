using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathPaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox3.Text = "Result";
            textBox6.Text = "Result";
            textBox9.Text = "Result";
            textBox12.Text = "Result";
            textBox14.Text = "Result";
            textBox16.Text = "Result";
            textBox18.Text = "Result";
            textBox20.Text = "Result";
        }

        private void adunareBtn_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            num1 = Convert.ToInt32(textBox1.Text);

            float num2 = 0;
            num2 = Convert.ToInt32(textBox2.Text);

            float num3 = num1 + num2;

            textBox3.Text = num3.ToString();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            float num1 = 0;

            if (!float.TryParse(textBox1.Text, out num1))
            {
                if (textBox1.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            float num2 = 0;

            if (!float.TryParse(textBox2.Text, out num2))
            {
                if (textBox2.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void acBtn1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
        }

        private void scadereBtn_Click(object sender, EventArgs e)
        {
            float num4 = 0;
            num4 = Convert.ToInt32(textBox4.Text);

            float num5 = 0;
            num5 = Convert.ToInt32(textBox5.Text);

            float num6 = num4 - num5;

            textBox6.Text = num6.ToString();
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            float num4 = 0;

            if (!float.TryParse(textBox4.Text, out num4))
            {
                if (textBox4.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox4.Clear();
                textBox4.Focus();
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            float num5 = 0;

            if (!float.TryParse(textBox5.Text, out num5))
            {
                if (textBox5.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox5.Clear();
                textBox5.Focus();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
        }

        private void inmultireBtn_Click(object sender, EventArgs e)
        {
            float num7 = 0;
            num7 = Convert.ToInt32(textBox7.Text);

            float num8 = 0;
            num8 = Convert.ToInt32(textBox8.Text);

            float num9 = num7 * num8;

            textBox9.Text = num9.ToString();
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            float num7 = 0;

            if (!float.TryParse(textBox7.Text, out num7))
            {
                if (textBox7.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox7.Clear();
                textBox7.Focus();
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            float num8 = 0;

            if (!float.TryParse(textBox8.Text, out num8))
            {
                if (textBox8.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");
                textBox8.Clear();
                textBox8.Focus();
            }

        }

        private void acBtn3_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
        }

        private void impartireBtn_Click(object sender, EventArgs e)
        {
            float num10 = 0;
            num10 = Convert.ToInt32(textBox10.Text);

            float num11 = 0;
            num11 = Convert.ToInt32(textBox11.Text);

            float num12 = num10 / num11;

            textBox12.Text = num12.ToString();
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            float num10 = 0;

            if (!float.TryParse(textBox10.Text, out num10))
            {
                if (textBox10.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox10.Clear();
                textBox10.Focus();
            }
        }

        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
            float num11 = 0;

            if (!float.TryParse(textBox11.Text, out num11))
            {
                if (textBox11.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox11.Clear();
                textBox11.Focus();
            }

        }

        private void acBtn4_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
        }

        private void acBtn2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num13 = 0;
            num13 = Convert.ToInt32(textBox13.Text);

            int num14 = num13 * num13;

            textBox14.Text = num14.ToString();
        }

        private void textBox13_Validating(object sender, CancelEventArgs e)
        {
            int num13 = 0;

            if (!int.TryParse(textBox13.Text, out num13))
            {
                if (textBox13.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox13.Clear();
                textBox13.Focus();
            }
        }

        private void acBtn5_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
            textBox14.Text = "Result";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num15 = 0;
            num15 = Convert.ToInt32(textBox15.Text);

            int num16 = num15 * num15 * num15;

            textBox16.Text = num16.ToString();
        }

        private void textBox15_Validating(object sender, CancelEventArgs e)
        {
            int num15 = 0;

            if (!int.TryParse(textBox15.Text, out num15))
            {
                if (textBox15.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox15.Clear();
                textBox15.Focus();
            }
        }

        private void acBtn6_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
            textBox16.Text = "Result";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num17 = 0;
            num17 = Convert.ToInt32(textBox17.Text);

            int num18 = num17 * num17 * num17 * num17;

            textBox18.Text = num18.ToString();
        }

        private void textBox17_Validating(object sender, CancelEventArgs e)
        {
            int num17 = 0;

            if (!int.TryParse(textBox17.Text, out num17))
            {
                if (textBox17.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox17.Clear();
                textBox17.Focus();
            }
        }

        private void acBtn7_Click(object sender, EventArgs e)
        {
            textBox17.Clear();
            textBox18.Text = "Result";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num19 = 0;
            num19 = Convert.ToInt32(textBox19.Text);

            int num20 = num19 * num19 * num19 * num19 * num19;

            textBox20.Text = num20.ToString();
        }

        private void textBox19_Validating(object sender, CancelEventArgs e)
        {
            int num19 = 0;

            if (!int.TryParse(textBox19.Text, out num19))
            {
                if (textBox19.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textBox19.Clear();
                textBox19.Focus();
            }
        }

        private void acBtn8_Click(object sender, EventArgs e)
        {
            textBox19.Clear();
            textBox20.Text = "Result";
        }

        private void clearBtn2_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
            textBox14.Text = "Result";
            textBox15.Clear();
            textBox16.Text = "Result";
            textBox17.Clear();
            textBox18.Text = "Result";
            textBox19.Clear();
            textBox20.Text = "Result";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
            textBox13.Clear();
            textBox14.Text = "Result";
            textBox15.Clear();
            textBox16.Text = "Result";
            textBox17.Clear();
            textBox18.Text = "Result";
            textBox19.Clear();
            textBox20.Text = "Result";
            labelX.Text = "number x";
            textBox21.Clear();
            textBox22.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random x = new Random();

            int minValue = 0;
            minValue = Convert.ToInt32(textBox21.Text);

            int maxValue = 0;
            maxValue = Convert.ToInt32(textBox22.Text);

            int numX = x.Next(minValue, maxValue);
            
            labelX.Text = numX.ToString();
        }

        private void clearBtn3_Click(object sender, EventArgs e)
        {
            labelX.Text = "number x";
            textBox21.Clear();
            textBox22.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
             
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AMdev10");
        }

        private void toolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
        }

        private void toolStripMenuItem2_1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
        }

        private void toolStripMenuItem3_1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
        }

        private void toolStripMenuItem4_1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
        }

        private void toolStripMenuItem1_2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
            textBox13.Clear();
            textBox14.Text = "Result";
            textBox15.Clear();
            textBox16.Text = "Result";
            textBox17.Clear();
            textBox18.Text = "Result";
            textBox19.Clear();
            textBox20.Text = "Result";
            labelX.Text = "number x";
            textBox21.Clear();
            textBox22.Clear();
        }

        private void toolStripMenuItem2_2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
            textBox13.Clear();
            textBox14.Text = "Result";
            textBox15.Clear();
            textBox16.Text = "Result";
            textBox17.Clear();
            textBox18.Text = "Result";
            textBox19.Clear();
            textBox20.Text = "Result";
            labelX.Text = "number x";
            textBox21.Clear();
            textBox22.Clear();
        }

        private void toolStripMenuItem3_2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
            textBox13.Clear();
            textBox14.Text = "Result";
            textBox15.Clear();
            textBox16.Text = "Result";
            textBox17.Clear();
            textBox18.Text = "Result";
            textBox19.Clear();
            textBox20.Text = "Result";
            labelX.Text = "number x";
            textBox21.Clear();
            textBox22.Clear();
        }

        private void toolStripMenuItem4_2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "Result";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = "Result";
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Text = "Result";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Text = "Result";
            textBox13.Clear();
            textBox14.Text = "Result";
            textBox15.Clear();
            textBox16.Text = "Result";
            textBox17.Clear();
            textBox18.Text = "Result";
            textBox19.Clear();
            textBox20.Text = "Result";
            labelX.Text = "number x";
            textBox21.Clear();
            textBox22.Clear();
        }

    }
}