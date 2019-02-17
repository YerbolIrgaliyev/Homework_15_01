using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_15_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            try
            {
                double divisionByTwo = Division();
                Console.WriteLine($"Результат деления: {divisionByTwo}");
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                {
                    Console.WriteLine(ex.Message);
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("\nЗадание 2:");
            int cntNumbers;
            string strCntNumbers;

            Console.WriteLine("Введите размер массива: ");
            strCntNumbers= Console.ReadLine();
            if (int.TryParse(strCntNumbers, out cntNumbers))
            {
                Random rand = new Random();
                int[] numbers = new int[cntNumbers];

                Console.WriteLine("Числа массива: ");

                for (int i = 0; i < cntNumbers; i++)
                {
                    numbers[i] = rand.Next(100);
                }

                for (int i = 0; i < cntNumbers + 1; i++)
                {

                    try
                    { 
                        int number = returnNumber(numbers, cntNumbers, i);
                        Console.WriteLine(number);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }      
        }

        static int returnNumber(int[] numbers, int size, int index)
        {
            if(index == size)
            {
                throw new IndexOutOfRangeException("Выход за пределы массива!");
            }
            return numbers[index];
        }

        static double Division()
        {
            double numberFirst, numberSecond, result = 0.0;
            string strFirst, strSecond;

            Console.WriteLine("Введите первое число:");
            strFirst = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            strSecond = Console.ReadLine();


            if (double.TryParse(strFirst, out numberFirst))
            {
                if(double.TryParse(strSecond, out numberSecond))
                {
                    if (numberFirst == 0 && numberSecond == 0) { throw new ArgumentNullException(); }
                    if (numberSecond == 0) { throw new ArgumentException("Делитель не может быть равен 0!"); }

                    result = numberFirst / numberSecond;
                }
                else { Console.WriteLine("Введены неверные данные!"); }
            }
            else { Console.WriteLine("Введены неверные данные!"); }
            return result;
    
        }
    }
}
