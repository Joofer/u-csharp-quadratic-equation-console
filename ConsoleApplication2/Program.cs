using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double x_1;
            double x_2;
            double e;

            while (true)
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                e = Convert.ToDouble(Console.ReadLine());

                //
                print(a, b, c);
                //

                if (a != 0)
                {
                    x_1 = x1(a, b, c);
                    x_2 = x2(a, b, c);

                    Console.WriteLine("x1: " + x_1 + "\tx2: " + x_2);
                    Console.WriteLine("check x1: " + check(e, a, b, c, x_1) + "\tcheck x2: " + check(e, a, b, c, x_2));
                }
                else
                {
                    x_1 = x1(a, b, c);

                    Console.WriteLine("x: " + x_1);
                    Console.WriteLine("check x: " + check(e, a, b, c, x_1));
                }
            }
        }

        static double D(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("d: " + d);
            return d;
        }

        static double x1(double a, double b, double c)
        {
            if (a != 0)
            {
                double d = D(a, b, c);

                if (d > 0)
                {
                    return (-b - Math.Sqrt(d)) / (2 * a);
                }
                else if (d == 0)
                {
                    return -b / (2 * a);
                }
                else
                {
                    return Double.NaN;
                }
            }
            else
            {
                return -c / b;
            }
        }

        static double x2(double a, double b, double c)
        {
            if (a != 0)
            {
                double d = D(a, b, c);

                if (d > 0)
                {
                    return (-b + Math.Sqrt(d)) / (2 * a);
                }
                else if (d == 0)
                {
                    return -b / (2 * a);
                }
                else
                {
                    return Double.NaN;
                }
            }
            else
            {
                return -c / b;
            }
        }

        static void print(double a, double b, double c)
        {
            if (a == 1 || a == -1)
            {
                Console.Write("x^2");
            }
            else if (a != 0)
            {
                Console.Write(a + "x^2");
            }
            if (b < 0)
            {
                Console.Write(" - ");
                if (b == -1)
                    Console.Write("x");
                else
                    Console.Write(-b + "x");

            }
            else if (b > 0)
            {
                if (a != 0)
                    Console.Write(" + ");
                if (b == 1)
                    Console.Write("x");
                else
                    Console.Write(b + "x");
            }
            if (c < 0)
            {
                Console.Write(" - " + -c);
            }
            else if (c > 0)
            {
                Console.Write(" + " + c);
            }
            Console.WriteLine(" = 0");
        }

        static bool check(double e, double a, double b, double c, double x)
        {
            double r;

            if (a != 0)
            {
                r = a * Math.Pow(x, 2) + b * x + c;

                Console.WriteLine("r: " + r);
                if (Math.Abs(r) <= e)
                    return true;
                else
                    return false;
            }
            else
            {
                r = b * x + c;

                Console.WriteLine("r: " + r);
                if (Math.Abs(r) <= e)
                    return true;
                else
                    return false;
            }
        }
    }
}
