using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string calTotal;

        double num1 = 0;
        double ?num2 ;

        string option;

        double result;





        private void button1_Click(object sender, EventArgs e)
        {
            if(resultText.Text == "0")
            {
                resultText.Clear();
                
            }
            resultText.Text = resultText.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
            {
                resultText.Clear();
            }
                resultText.Text = resultText.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
            {
                resultText.Clear();

            }
                resultText.Text = resultText.Text + "3";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
            {
                resultText.Clear();
            }
            resultText.Text = resultText.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
            {
                resultText.Clear();

            }
            resultText.Text = resultText.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
            {
                resultText.Clear();
            }
                resultText.Text = resultText.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
            {
                resultText.Clear();
            }
                resultText.Text = resultText.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
            {
                resultText.Clear();
            }
                resultText.Text = resultText.Text + "8";

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
            {
            resultText.Clear();
            }
            resultText.Text = resultText.Text + "9";

        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (resultText.Text == "0")
            {
            resultText.Clear();
            }
            resultText.Text = resultText.Text + "0";
        }
        private void button_comma_Click(object sender, EventArgs e)
        {
            if (!resultText.Text.Contains(","))
            {
            resultText.Text = resultText.Text + ",";

            }
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            option = "+";
            if (resultText.Text != null && resultText.Text != "")
            {
                optiontext.Text = option;
            }
            if (resultText.Text != null && resultText.Text != "" && resultText.Text != "-")
            {
                num1 = Convert.ToDouble(resultText.Text);
            }


            resultText.Clear();

        }

        private void button_multiple_Click(object sender, EventArgs e)
        {
            option = "*";
            if (resultText.Text != null && resultText.Text != "" )
            {
                optiontext.Text = option;
            }

            if (resultText.Text != null && resultText.Text != "" && resultText.Text != "-")
            {
                num1 = Convert.ToDouble(resultText.Text);
            }

            resultText.Clear();
        }
        private void button_subtract_Click(object sender, EventArgs e)
        {
            

            if (Convert.ToDouble(resultText.Text.Length) == 0)
            {
                resultText.Text = resultText.Text + "-";
            }


            if (resultText.Text != null && resultText.Text != "" && resultText.Text != "-")
            {
                num1 = Convert.ToDouble(resultText.Text);
                
                resultText.Clear();
            }

            if(option == null && num1 != 0)
            {
                option = "-";
                optiontext.Text = option;
            }

            
            
            
           

            
            
        }
        private void button_divide_Click(object sender, EventArgs e)
        {
            option = "/";
            if (resultText.Text != null && resultText.Text != "")
            {
                optiontext.Text = option;
            }

            if (resultText.Text != null && resultText.Text != "" && resultText.Text != "-")
            {
                num1 = Convert.ToDouble(resultText.Text);
            }

            resultText.Clear();
        }
        private void button_sqrt_Click(object sender, EventArgs e)
        {
            option = "√";
            if (resultText.Text != null && resultText.Text != "")
            {
                optiontext.Text = option;
            }
            if (resultText.Text != null && resultText.Text != "")
            {
                num1 = Convert.ToDouble(resultText.Text);
            }

            resultText.Clear();
        }

        private void button_power2_Click(object sender, EventArgs e)
        {
            option = "^2";
            if (resultText.Text != null && resultText.Text != "")
            {
                optiontext.Text = option;
            }

            if (resultText.Text != null && resultText.Text != "")
            {
                num1 = Convert.ToDouble(resultText.Text);
            }

            resultText.Clear();
        }
        private void button_powerxy_Click(object sender, EventArgs e)
        {
            option = "x^y";
            if (resultText.Text != null && resultText.Text != "")
            {
                optiontext.Text = option;
            }

            if (resultText.Text != null && resultText.Text != "")
            {
                num1 = Convert.ToDouble(resultText.Text);
            }

            resultText.Clear();
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            resultText.Clear();
            num1 = (0);
            num2 = (0);
            result = (0);
            option = null;
            optiontext.Text = option;
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (resultText.Text != string.Empty)
            {
                int txtlength = resultText.Text.Length;
                if (txtlength != 1)
                {
                    resultText.Text = resultText.Text.Remove(txtlength - 1);

                }
                else
                {
                    resultText.Text = "";
                    
                }
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            
            if (resultText.Text != null && resultText.Text != "")
            {
                num2 = Convert.ToDouble(resultText.Text);

            }

            if (option != null)
            {

                if (option.Equals("+"))
                {

                    result = (double)(num1 + num2);

                }
                if (option.Equals("-"))
                {
                    result = (double)(num1 - num2);


                }
                if (option.Equals("*"))
                {
                    result = (double)(num1 * num2);

                }
                if (option.Equals("√"))
                {
                    result = Math.Sqrt(num1);

                }
                if (option.Equals("^2"))
                {
                    result = num1 * num1;

                }
                if (option.Equals("x^y"))
                {
                    result = Math.Pow(num1, (double)num2);

                }

                if (option.Equals("/"))
                {
                    try
                    {
                        result = (double)(num1 / num2);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Sıfıra bölünemez");
                        resultText.Text = "Sıfıra Bölünemez";

                    }


                }
                resultText.Text = result + "";

                option = null;
                optiontext.Text = option;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void resultText_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
