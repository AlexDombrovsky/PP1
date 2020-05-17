using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PP_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number = Int32.Parse(Console.ReadLine());
            int count = 0;
            new Thread(
                () =>
                {
                    if (number > 0)
                    {
                        for (int i = 0; i <= number; i++)
                        {
                            count += i;
                            Console.WriteLine(count);
                            Thread.Sleep(600);
                        }
                    }
                    else if (number < 0)
                    {
                        for (int i = number; i < 0; i++)
                        {
                            count += i;
                            Console.WriteLine(count);
                            Thread.Sleep(600);
                        }
                    }
                }).Start();
            Console.ReadKey();
        }
    }
}
