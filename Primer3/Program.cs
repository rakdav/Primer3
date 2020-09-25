﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                double b = double.Parse(Console.ReadLine());
                double sa = (a * a * a + b * b * b) / 2;
                double sg = Math.Sqrt((Math.Abs(a)+Math.Abs(b))/2);
                Console.WriteLine("Среднее арифметическое:{0:F2}",sa);
                Console.WriteLine("Среднее геометрическое:{0:F2}", sg);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
