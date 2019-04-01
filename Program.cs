using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Примеры_C_шарп
{
    public class Program
    {
        static void Main(string[] args)
        {
            int s = 0, k;
            int num;
            do
            {
                k = 0;
                Console.Clear();
                Console.WriteLine("Введите целое положительное число: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    k++;
                }

            } while (k != 0);

            while (num != 0)
            {
                s = s * 10 + num % 10;
                num /= 10;
            }

            Console.WriteLine($"Перевернутое число: {s}");

        }

    }
}
