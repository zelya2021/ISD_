using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double rezult=0;
        string operation="";
        bool isOperation = false;
     

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "Error")
            {
                textBox_Result.Clear();
                rezult = 0;
            }
               

            if ((textBox_Result.Text == "0")|| (isOperation))
                textBox_Result.Clear();

            isOperation = false;
            Button button = (Button)sender;
            if(button.Text==".")
            {
                if(!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text+ button.Text;

            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
           
        }

        private void operator_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "Error")
            {
                textBox_Result.Clear();
                rezult = 0; textBox_Result.Text = "0";
            }
            if(isOperation != true)
            {
                Button button = (Button)sender;
                if (rezult != 0)
                {
                    btn_qually.PerformClick();
                    operation = button.Text;
                    lbl_Operation.Text = rezult + " " + operation;
                    isOperation = true;
                }
                else
                {
                    operation = button.Text;
                    rezult = Convert.ToDouble(textBox_Result.Text);
                    lbl_Operation.Text = rezult + " " + operation;
                    isOperation = true;
                }
            }
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            rezult = 0;
        }

        private void btn_qually_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox_Result.Text = (rezult + Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (rezult - Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (rezult * Convert.ToDouble(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    {
                        if (double.Parse(textBox_Result.Text) != 0)
                            textBox_Result.Text = (rezult / Convert.ToDouble(textBox_Result.Text)).ToString();
                        else if (double.Parse(textBox_Result.Text) == 0)
                        {
                            (textBox_Result.Text = "Error").ToString();
                        }
                        break;
                    }
                    
                default: break;
            }
            if (textBox_Result.Text != "Error")
                rezult = Convert.ToDouble(textBox_Result.Text);
            lbl_Operation.Text = "";
        }
    }
}
