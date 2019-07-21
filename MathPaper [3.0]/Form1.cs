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

        private double basic_operations(TextBox num1,TextBox num2,int operatie)
        {
            /* operatie = 1 -> adunare
               operatie = 2 -> scadere
               operatie = 3 -> inmultire
               operatie = 4 -> impartire  
            */

            if (operatie == 1)
            {
                return Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text);
            }
            else if (operatie == 2)
            {
                return Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text);
            }
            else if (operatie == 3)
            {
                return Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text);
            }
            else if (operatie == 4)
            {
                return Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text);
            }
            else return -1;
        }

        private void adunareBtn_Click(object sender, EventArgs e)
        {
            textBox3.Text = basic_operations(textBox1,textBox2,1).ToString();
        }


         //O FUNCTIE CE VALIDEAZA TOATE CASETBOXURILE ORI CARE AR FI ELE 
        private void validare(TextBox textul)
        {
            double num1 = 0;
            if (!double.TryParse(textul.Text, out num1))
            {
                if (textul.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textul.Clear();
                textul.Focus();
            }
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox1);  
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox2);
        }

        private void curata_sectiune(TextBox text1,TextBox text2,TextBox text3)
        {
            text1.Clear();
            text2.Clear();
            text3.Text = "Result";
        }

        private void acBtn1_Click(object sender, EventArgs e)
        {
            curata_sectiune(textBox1, textBox2, textBox3);
        }

        private void scadereBtn_Click(object sender, EventArgs e)
        {
            textBox6.Text = basic_operations(textBox4, textBox5, 2).ToString();
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox4);
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox5);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            curata_sectiune(textBox1, textBox2, textBox3);
            curata_sectiune(textBox4, textBox5, textBox6);
            curata_sectiune(textBox7, textBox8, textBox9);
            curata_sectiune(textBox10, textBox11, textBox12);
        }

        private void inmultireBtn_Click(object sender, EventArgs e)
        {
            textBox9.Text = basic_operations(textBox7, textBox8,3).ToString();
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox7);
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox8);

        }

        private void acBtn3_Click(object sender, EventArgs e)
        {
            curata_sectiune(textBox7, textBox8, textBox9);
        }

        private void impartireBtn_Click(object sender, EventArgs e)
        {
            

            textBox12.Text = basic_operations(textBox10,textBox11,4).ToString();
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox10);
        }

        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox11);

        }

        private void acBtn4_Click(object sender, EventArgs e)
        {
            curata_sectiune(textBox10, textBox11, textBox12);
        }

        private void acBtn2_Click(object sender, EventArgs e)
        {
            curata_sectiune(textBox4, textBox5, textBox6);
        }

        //Advanced

        private void advanced_clear(TextBox text1,TextBox rezultat)
        {
            text1.Clear();
            rezultat.Text = "Result";
        }

        private bool validare_puteri(TextBox textul)
        {
            double num1 = 0;
            if (!double.TryParse(textul.Text, out num1))
            {
                if (textul.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textul.Clear();
                textul.Focus();
                return false;
            }
            else return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(validare_puteri(textBox13))
            {
                double num13 = 0;
                num13 = Convert.ToDouble(textBox13.Text);

                double num14 = num13 * num13;

                textBox14.Text = num14.ToString();
            }
            
        }

        private void textBox13_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox13);
        }

        private void acBtn5_Click(object sender, EventArgs e)
        {
            advanced_clear(textBox13, textBox14);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validare_puteri(textBox15))
            {
                double num15 = 0;
                num15 = Convert.ToDouble(textBox15.Text);

                double num16 = num15 * num15 * num15;

                textBox16.Text = num16.ToString();
            }
        }

        private void textBox15_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox15);
        }

        private void acBtn6_Click(object sender, EventArgs e)
        {
            advanced_clear(textBox15, textBox16);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validare_puteri(textBox17))
            {
                double num17 = 0;
                num17 = Convert.ToDouble(textBox17.Text);

                double num18 = num17 * num17 * num17 * num17;

                textBox18.Text = num18.ToString();
            }
        }

        private void textBox17_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox17);
        }

        private void acBtn7_Click(object sender, EventArgs e)
        {
            advanced_clear(textBox17, textBox18);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (validare_puteri(textBox19))
            {
                double num19 = 0;
                num19 = Convert.ToDouble(textBox19.Text);

                double num20 = num19 * num19 * num19 * num19 * num19;

                textBox20.Text = num20.ToString();
            }
        }

        private void textBox19_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox19);
        }

        private void acBtn8_Click(object sender, EventArgs e)
        {
            advanced_clear(textBox19, textBox20);
        }

        private void clearBtn2_Click(object sender, EventArgs e)
        {
            advanced_clear(textBox13, textBox14);
            advanced_clear(textBox15, textBox16);
            advanced_clear(textBox17, textBox18);
            advanced_clear(textBox19, textBox20);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            curata_sectiune(textBox1, textBox2, textBox3);
            curata_sectiune(textBox4, textBox5, textBox6);
            curata_sectiune(textBox7, textBox8, textBox9);
            curata_sectiune(textBox10, textBox11, textBox12);
            advanced_clear(textBox13, textBox14);
            advanced_clear(textBox15, textBox16);
            advanced_clear(textBox17, textBox18);
            advanced_clear(textBox19, textBox20);
            labelX.Text = "number x";
            textBox21.Clear();
            textBox22.Clear();
            curata_sectiune(textBox23, textBox24, textBox25);
            textBox25.Text = "";
        }

        private bool random_valid(TextBox textulMIN,TextBox textulMAX)
        {
            double num1 = 0;
            double num2 = 0;
            if (!double.TryParse(textulMIN.Text, out num1) || int.Parse(textulMAX.Text) < int.Parse(textulMIN.Text))
            {
                if (textulMIN.Text == "")
                    MessageBox.Show("ERROR! Complete all!");
                else
                    MessageBox.Show("ERROR!");

                textulMIN.Clear();
                textulMIN.Focus();
                return true;
            }
            else return false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (!random_valid(textBox21, textBox22)) 
            {
                Random x = new Random();

                int minValue = 0;
                minValue = Convert.ToInt32(textBox21.Text);

                int maxValue = 0;
                maxValue = Convert.ToInt32(textBox22.Text);

                int numX = x.Next(minValue, maxValue);

                labelX.Text = numX.ToString();
            }
            
            
        }

        private void textBox21_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox21);
        }

        private void textBox22_Validating(object sender, CancelEventArgs e)
        {
            validare(textBox22);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            curata_sectiune(textBox23, textBox24, textBox25);
            textBox25.Text = "";
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxLbl_Click(object sender, EventArgs e)
        {

        }
        
        private Int64 Calculate_powerul(TextBox power, TextBox numar)
        {
            Int64 numarul = 1;
            numarul = int.Parse(numar.Text);
            Int64 putere_finala = 1;
            if (int.Parse(power.Text) == 0)
            {
                return 1;
            }
            else if (int.Parse(numar.Text) == 0)
            {
                return 0;
            }
            for (int i = 0; i < int.Parse(power.Text); i++)
            {
                putere_finala = putere_finala * numarul;
            }
            
            return putere_finala;
            
        }

        private void Calculate_power_Click(object sender, EventArgs e)
        {
            if (validare_puteri(textBox23) && validare_puteri(textBox24))
            {
                textBox25.Text = Calculate_powerul(textBox24, textBox23).ToString();
            }
        }
    }
}
