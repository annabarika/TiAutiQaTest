using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter coordinate of 3-points triangle");
            Console.WriteLine("_______________________________________________________");

            Console.WriteLine("Enter coordinate x of dot A");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A");
            double a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot B");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B");
            double b2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot C");
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C");
            double c2 = double.Parse(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b1 - b2, 2));
            double b = Math.Sqrt(Math.Pow(b2 - b1, 2) + Math.Pow(c1 - c2, 2));
            double c = Math.Sqrt(Math.Pow(c2 - c1, 2) + Math.Pow(a1 - a2, 2));

            double alpha = 0;
            double betta = 0;
            double gamma = 0;
            Console.WriteLine("_______________________________________________________");

            alpha = Math.Pow(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2), 0.5);
            Console.WriteLine("alpha = {0}", alpha);
            betta = Math.Pow(Math.Pow(b1 - c1, 2) + Math.Pow(b2 - c2, 2), 0.5);
            Console.WriteLine("betta = {0}", betta);
            gamma = Math.Pow(Math.Pow(c1 - a1, 2) + Math.Pow(c2 - a2, 2), 0.5);
            Console.WriteLine("gamma = {0}", gamma);
            Console.WriteLine("_______________________________________________________");
            if ((a < b + c) & (b < c + a) & (c < b + a))
            {
                if ((alpha == 90) || (betta == 90) || (gamma == 90)) Console.WriteLine("Right triangle");
                else
                    if ((alpha == betta) && (betta == gamma) && (gamma == alpha)) Console.WriteLine("Equilateral triangle");
                else
                    if ((alpha == betta) || (betta == gamma) || (gamma == alpha)) Console.WriteLine("Isosceles triangle");
            }
            else
                Console.WriteLine("The triangle does not exist");
           
            double perimetr = 0;
            //расчет
            perimetr += Math.Pow(Math.Pow(a1 - b1, 2) + Math.Pow(a2- b2, 2), 0.5);
            perimetr += Math.Pow(Math.Pow(b1 - c1, 2) + Math.Pow(b2 - c2, 2), 0.5);
            perimetr += Math.Pow(Math.Pow(c1 - a1, 2) + Math.Pow(c2 - a2, 2), 0.5);
            //вывод
            Console.WriteLine("Perimeter of the triangle = " + Convert.ToString(perimetr));
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("Even numbers from 0 to value of triangle perimeter:");
            int n = Convert.ToInt32(perimetr);

            for (int i = 0; i <= n; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}

