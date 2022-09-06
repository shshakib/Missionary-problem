using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Missoner
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean repeat = false;
        Class1[] Nodearray = new Class1[32000];
        public Class1[,] answerarray = new Class1[20, 4];
        int ii = 11;
        private void button1_Click(object sender, EventArgs e)
        {
            Nodearray[1] = new Class1();
            Nodearray[1].Barbarian = 3;
            Nodearray[1].Missionary = 3;
            Nodearray[1].Boat = 1;
            ii = 11;
            expand(Nodearray[1], 1);
            int f = 0;
            for (long i = 1; i < 32000 & f < 4; i++)
            {
                if (Nodearray[i] != null)
                {
                    if (Nodearray[i].Isanswer())
                    {
                        f++;
                        answer(i, f);
                    }
                }
            }
            graphic();
            button2_Click(sender, e);
            
        }

        public void expand(Class1 next, int i)
        {
            Class1 temp1 = new Class1(), temp2 = new Class1(), temp3 = new Class1(), temp4 = new Class1(), temp5 = new Class1();
            int check = 0, checktemp = 0;
            if (i < 16000)
            {
                if ((next.Isanswer() == false) & (next.Ispassible()) & (next.Boat == 1))
                {
                    temp1.Barbarian = next.Barbarian - 1;
                    temp1.Missionary = next.Missionary - 1;
                    temp1.Boat = 0;

                    temp2.Barbarian = next.Barbarian - 2;
                    temp2.Missionary = next.Missionary;
                    temp2.Boat = 0;

                    temp3.Barbarian = next.Barbarian;
                    temp3.Missionary = next.Missionary - 2;
                    temp3.Boat = 0;

                    if (temp1.Ispassible() & check != 1 & Isrepeat(temp1, i) == false)
                    {
                        Nodearray[2 * i] = temp1;
                        expand(Nodearray[2 * i], 2 * i);
                        check++; checktemp = 1;
                    }
                    if (temp2.Ispassible() & check != 1 & Isrepeat(temp2, i) == false)
                    {
                        Nodearray[2 * i] = temp2;
                        expand(Nodearray[2 * i], 2 * i);
                        check++; checktemp = 2;
                    }
                    if (temp3.Ispassible() & check != 1 & Isrepeat(temp3, i) == false)
                    {
                        Nodearray[2 * i] = temp3;
                        expand(Nodearray[2 * i], 2 * i);
                        check++; checktemp = 3;
                    }

                    if (temp1.Ispassible() & check != 2 & checktemp != 1 & Isrepeat(temp1, i) == false)
                    {
                        Nodearray[2 * i + 1] = temp1;
                        expand(Nodearray[2 * i + 1], 2 * i + 1);
                        check++;
                    }
                    if (temp2.Ispassible() & check != 2 & checktemp != 2 & Isrepeat(temp2, i) == false)
                    {
                        Nodearray[2 * i + 1] = temp2;
                        expand(Nodearray[2 * i + 1], 2 * i + 1);
                        check++;
                    }
                    if (temp3.Ispassible() & check != 2 & checktemp != 3 & Isrepeat(temp3, i) == false)
                    {
                        Nodearray[2 * i + 1] = temp3;
                        expand(Nodearray[2 * i + 1], 2 * i + 1);
                        check++;
                    }

                }
                if ((next.Isanswer() == false) & (next.Ispassible()) & (next.Boat == 0))
                {
                    temp1.Barbarian = next.Barbarian + 1;
                    temp1.Missionary = next.Missionary;
                    temp1.Boat = 1;

                    temp2.Barbarian = next.Barbarian;
                    temp2.Missionary = next.Missionary + 1;
                    temp2.Boat = 1;

                    temp3.Barbarian = next.Barbarian + 1;
                    temp3.Missionary = next.Missionary + 1;
                    temp3.Boat = 1;

                    temp4.Barbarian = next.Barbarian + 2;
                    temp4.Missionary = next.Missionary;
                    temp4.Boat = 1;

                    temp5.Barbarian = next.Barbarian;
                    temp5.Missionary = next.Missionary + 2;
                    temp5.Boat = 1;

                    if (temp1.Ispassible() & check != 1 & Isrepeat(temp1, i) == false)
                    {
                        Nodearray[2 * i] = temp1;
                        expand(Nodearray[2 * i], 2 * i);
                        check++; checktemp = 1;
                    }
                    if (temp2.Ispassible() & check != 1 & Isrepeat(temp2, i) == false)
                    {
                        Nodearray[2 * i] = temp2;
                        expand(Nodearray[2 * i], 2 * i);
                        check++; checktemp = 2;
                    }
                    if (temp3.Ispassible() & check != 1 & Isrepeat(temp3, i) == false)
                    {
                        Nodearray[2 * i] = temp3;
                        expand(Nodearray[2 * i], 2 * i);
                        check++; checktemp = 3;
                    }

                    if (temp4.Ispassible() & check != 1 & Isrepeat(temp4, i) == false)
                    {
                        Nodearray[2 * i] = temp4;
                        expand(Nodearray[2 * i], 2 * i);
                        check++; checktemp = 4;
                    }

                    if (temp5.Ispassible() & check != 1 & Isrepeat(temp5, i) == false)
                    {
                        Nodearray[2 * i] = temp5;
                        expand(Nodearray[2 * i], 2 * i);
                        check++; checktemp = 5;
                    }

                    if (temp1.Ispassible() & check != 2 & checktemp != 1 & Isrepeat(temp1, i) == false)
                    {
                        Nodearray[2 * i + 1] = temp1;
                        expand(Nodearray[2 * i + 1], 2 * i + 1);
                        check++;
                    }
                    if (temp2.Ispassible() & check != 2 & checktemp != 2 & Isrepeat(temp2, i) == false)
                    {
                        Nodearray[2 * i + 1] = temp2;
                        expand(Nodearray[2 * i + 1], 2 * i + 1);
                        check++;
                    }
                    if (temp3.Ispassible() & check != 2 & checktemp != 3 & Isrepeat(temp3, i) == false)
                    {
                        Nodearray[2 * i + 1] = temp3;
                        expand(Nodearray[2 * i + 1], 2 * i + 1);
                        check++;
                    }
                    if (temp4.Ispassible() & check != 2 & checktemp != 4 & Isrepeat(temp4, i) == false)
                    {
                        Nodearray[2 * i + 1] = temp4;
                        expand(Nodearray[2 * i + 1], 2 * i + 1);
                        check++;
                    }
                    if (temp5.Ispassible() & check != 2 & checktemp != 5 & Isrepeat(temp5, i) == false)
                    {
                        Nodearray[2 * i + 1] = temp5;
                        expand(Nodearray[2 * i + 1], 2 * i + 1);
                        check++;
                    }

                }
            }
        }
        public Boolean Isrepeat(Class1 node,int i)
        {
            //for (int j = 1; j < 900; j++)
            //{
            //    if (Nodearray[j] != null & node.Isanswer() == false)
            //    {
            //        if (Nodearray[j].Missionary == node.Missionary  & 
            //          Nodearray[j].Barbarian == node.Barbarian &
            //          Nodearray[j].Boat == node.Boat)
            //        {
            //            return (true);
            //        }
            //    }
            //}
            //return (false);
            int j = i;
            while(j != 1) 
            {
                     if (Nodearray[j] != null & node.Isanswer() == false)
                {
                    if (Nodearray[j].Missionary == node.Missionary  & 
                      Nodearray[j].Barbarian == node.Barbarian &
                      Nodearray[j].Boat == node.Boat)
                    {
                        return (false);
                    }
                }
                     if ((int)j/2 == (float)j/2) { j = j / 2; }
                    else { j = (j - 1) / 2; }
           
            }
            return (false);
        }

        public void answer(long j,int f)
        {
            int i = 0;
            while (j != 1)
            {
                answerarray[i,f - 1] = Nodearray[j];
                if ((int)j / 2 == (float)j / 2) { j = j / 2; }
                else { j = (j - 1) / 2; }
                i++;
            }
            answerarray[i, f - 1] = Nodearray[j];
        }

        public void graphic()
        {
            decimal q = numericUpDown1.Value;
            q = q - 1;
            int j=Convert.ToInt32(q);
            
            //for (int i = 11; i >= 0; i--)
            //{
                if (answerarray[ii, j].Barbarian == 0)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox11.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox13.Visible = true;
                }
                else if (answerarray[ii, j].Barbarian == 1)
                {
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = true;
                    pictureBox13.Visible = true;
                }
                else if (answerarray[ii, j].Barbarian == 2)
                {
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = true;
                }
                else if (answerarray[ii, j].Barbarian == 3)
                {
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                }
                if (answerarray[ii, j].Missionary == 0)
                {
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = true;
                }
                else if (answerarray[ii, j].Missionary == 1)
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else if (answerarray[ii, j].Missionary == 2)
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                }
                else if (answerarray[ii, j].Missionary == 3)
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                }
                if (answerarray[ii, j].Boat == 0)
                {
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = true;
                }
                else if (answerarray[ii, j].Boat == 1)
                {
                    pictureBox14.Visible = true;
                    pictureBox15.Visible = false;
                }
                button2.Visible = true;
                button1.Visible = false;
                numericUpDown1.Visible = false;
                label1.Visible = false;
                //MessageBox.Show("Press OK to see the next position");
                
            //}

		}

        private void button2_Click(object sender, EventArgs e)
        {
            if (ii > 0)
            {
                ii--;
                graphic();

            }
            else
            {
                button2.Visible = false;
                button1.Visible = true;
                numericUpDown1.Visible = true;
                label1.Visible = true;
                button2.Visible = false;
            }
        }

	}
}