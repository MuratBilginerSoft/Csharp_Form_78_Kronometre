using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KRONOMETRE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region tanımlamalar


        int a1=0, b1=0, c1=0, d1=0;

        int dx = 0;

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
         radioButton1.Enabled = false;
         radioButton2.Enabled = false;
         radioButton3.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            a1 = 0;
            b1 = 0;
            c1 = 0;
            d1 = 0;
            label1.Text = "0" + a1.ToString() + ":0" + b1.ToString() + ":0" + c1.ToString() + ":0" + d1.ToString();
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                if (d1 == 0)
                {
                    if (c1 != 0)
                    {
                        c1--;
                        d1 = 99;
                        label1.Text = "0" + a1.ToString() + ":0" + b1.ToString() + ":" + c1.ToString() + ":" + d1.ToString();


                    }
                    else
                    {

                        label1.Text = "0" + a1.ToString() + ":0" + b1.ToString() + ":0" + c1.ToString() + ":0" + d1.ToString();
                        timer1.Stop();
                        MessageBox.Show("Time İs Up!!!");
                        radioButton1.Enabled = true;
                        radioButton2.Enabled = true;
                        radioButton3.Enabled = true;
                       
                        
                    
                    }

                    
                
                
                }
                else
                {
                    d1--;
                    label1.Text = "0" + a1.ToString() + ":0" + b1.ToString() + ":" + c1.ToString() + ":" + d1.ToString();

                }
              
            
            
            }

            else if (radioButton2.Checked==true)
            {
                if (d1 == 0)
                {
                    if (c1 == 0)
                    {
                        if (b1 != 0)
                        {
                            b1--;
                            c1 = 59;
                            d1 = 99;
                            label1.Text = "0" + a1.ToString() + ":" + b1.ToString() + ":" + c1.ToString() + ":" + d1.ToString();
                        }

                        else if(b1==0)
                        {
                            label1.Text = "0" + a1.ToString() + ":0" + b1.ToString() + ":0" + c1.ToString() + ":0" + d1.ToString();
                            timer1.Stop();
                            MessageBox.Show("Time İs Up!!!");
                            radioButton1.Enabled = true;
                            radioButton2.Enabled = true;
                            radioButton3.Enabled = true;
                        }

                    }

                    else if (c1 != 0)
                    {
                        c1--;
                        d1 = 99;
                        label1.Text = "0" + a1.ToString() + ":" + b1.ToString() + ":" + c1.ToString() + ":" + d1.ToString();
                    
                    }


                } 

                else
                {

                        d1--;
                        label1.Text = "0" + a1.ToString() + ":" + b1.ToString() + ":" + c1.ToString() + ":" + d1.ToString();

                
                }
            
            
            
            
            }

            else if (radioButton3.Checked == true)
            {
                if (d1 == 0)
                {
                    if (c1 == 0)
                    {
                        if (b1 == 0)
                        {
                            if (a1 != 0)
                            {
                                a1--;
                                b1 = 59;
                                c1 = 59;
                                d1 = 99;
                                label1.Text = "0" + a1.ToString() + ":" + b1.ToString() + ":" + c1.ToString() + ":" + d1.ToString();

                            }

                            else if (a1 == 0)
                            {
                                label1.Text = "0" + a1.ToString() + ":0" + b1.ToString() + ":0" + c1.ToString() + ":0" + d1.ToString();
                                timer1.Stop();
                                MessageBox.Show("Time İs Up!!!");
                                radioButton1.Enabled = true;
                                radioButton2.Enabled = true;
                                radioButton3.Enabled = true;
                            }

                        }

                        else if (b1 != 0)
                        {
                            b1--;
                            c1 = 59;
                            d1 = 99;
                            label1.Text = a1.ToString() + ":" + b1.ToString() + ":" + c1.ToString() + ":" + d1.ToString();


                        }

                    }

                    else if (c1 != 0)
                    {
                        c1--;
                        d1 = 99;
                        label1.Text = a1.ToString() + ":" + b1.ToString() + ":" + c1.ToString() + ":" + d1.ToString();


                    }



                }

                else
                {
                    d1--;
                    label1.Text = a1.ToString() + ":" + b1.ToString() + ":" + c1.ToString() + ":" + d1.ToString();
                
                }
            
            
            }


           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;

            if (radioButton1.Checked == true)
            {
                a1 = 0; b1 = 0; c1 = int.Parse(textBox1.Text); d1 = 0;
                label1.Text = "0" + a1.ToString() + ":0" + b1.ToString() + ":0" + c1.ToString() + ":0"+d1.ToString();
                timer1.Start();
              
            
            }

            else if (radioButton2.Checked== true)
            {
                a1 = 0; b1 = int.Parse(textBox1.Text); c1 = 0; d1 = 0;
                label1.Text = a1.ToString() + ":" + b1.ToString() + ":0" + c1.ToString() + ":0" + d1.ToString();
                timer1.Start();
            
            
            }

            else if (radioButton3.Checked == true)
            {
                a1 = int.Parse(textBox1.Text); b1 = 0; c1 = 0; d1 = 0;
                label1.Text = a1.ToString() + ":" + b1.ToString() + ":0" + c1.ToString() + ":0" + d1.ToString();
                timer1.Start();
            
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }

            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
               
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "")
            {
                if ((int)e.KeyChar == 48)
                    e.Handled = true;
                else
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            }

            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dx % 2 == 0)
            {
                timer1.Stop();
                button2.Text = "Devam Et";
                dx++;

            }

            else
            {
                timer1.Start();
                button2.Text = "Durdur";
                dx++;
            
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
