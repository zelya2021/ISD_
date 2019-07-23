using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        string leftop = ""; // Левый операнд
        string operation = ""; // Знак операции
        string rightop = ""; // Правый операнд
        string s;
        public MainWindow() { }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст кнопки
            s = (string)((Button)e.OriginalSource).Content;
            // Добавляем его в текстовое поле
            tb_Show.Text += s;

            // Если операция не задана
            if (operation == "")
            {
                // Добавляем к левому операнду
                leftop += s;
            }
            else
            {
                // Иначе к правому операнду
                rightop += s;
            }
        }
        private void Update_RightOp()
        {
            double num1 = Double.Parse(leftop);
            double num2 = Double.Parse(rightop);
            // И выполняем операцию
            switch (operation)
            {
                case "+":
                    rightop = (num1 + num2).ToString();
                    break;
                case "-":
                    rightop = (num1 - num2).ToString();
                    break;
                case "*":
                    rightop = (num1 * num2).ToString();
                    break;
                case "/":
                    rightop = (num1 / num2).ToString();
                    break;
                    ;
            }
        }
        private void Btn_operation(object sender, RoutedEventArgs e)
        {
            s = (string)((Button)e.OriginalSource).Content;
            // Добавляем его в текстовое поле
            tb_Show.Text += s;

            if (rightop != "")
            {
                Update_RightOp();
                leftop = rightop;
                rightop = "";
            }
            operation = s;
        }

        private void Btn_CE_Click(object sender, RoutedEventArgs e)
        {
            tb_Show.Text = "";
            leftop = "";
            rightop = "";
            operation = "";
            tb_result.Text = "";
        }

        private void Btn_C_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
        }

        private void Btn_qually(object sender, RoutedEventArgs e)
        {
            Update_RightOp();
            tb_result.Text += rightop;
            operation = "";
        }
        private void Btn_Point(object sender, RoutedEventArgs e)
        {
            s = ",";
            if (!tb_Show.Text.Contains("."))
                tb_Show.Text = tb_Show.Text + s;
            // Если операция не задана
            if (operation == "")
            {
                // Добавляем к левому операнду
                leftop += s;
            }
            else
            {
                // Иначе к правому операнду
                rightop += s;
            }
        }
        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            if (tb_Show.Text.EndsWith("+")|| tb_Show.Text.EndsWith("-")|| tb_Show.Text.EndsWith("*")|| tb_Show.Text.EndsWith("/")|| tb_Show.Text.EndsWith(","))//заканчивается ли на это
            {
                string oper = operation.TrimEnd(operation[operation.Length - 1]);
                operation = operation.Replace(operation, oper);
                tb_Show.Text = "";
                tb_Show.Text = leftop + operation + rightop;
                ;
            }
            else
            {
                if (operation == "")
                {
                    string s1 = leftop.TrimEnd(leftop[leftop.Length - 1]);
                    leftop = leftop.Replace(leftop, s1);
                }
                else
                {
                    string s2 = rightop.TrimEnd(rightop[rightop.Length - 1]);
                    rightop = rightop.Replace(rightop, s2);
                }
                tb_Show.Text = "";
                tb_Show.Text = leftop + operation + rightop;
                ;
            }
        }
    }
        
}

