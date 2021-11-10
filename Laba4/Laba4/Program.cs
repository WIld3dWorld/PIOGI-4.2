using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;



            //string vvedennoe = Console.ReadLine();
            menu();

            void menu()
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("   Це калькулятор, он могёт считать");
                Console.WriteLine();
                Console.WriteLine("  ввод 1: задать число а| а = " + a);
                Console.WriteLine("  ввод 2: задать число b| b = " + b);
                Console.WriteLine("  ввод +: выполнить операцию сложения а и b");
                Console.WriteLine("  ввод -: выполнить операцию вычитания а и b");
                Console.WriteLine("  ввод *: выполнить операцию умножения а и b");
                Console.WriteLine("  ввод /: выполнить операцию деления  а и b");
                Console.WriteLine("----------------------------------------");

                string i = Console.ReadLine();

                switch (i)
                {
                    case "1":
                        Console.WriteLine("введите число а");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("число а = " + a);
                        menu();

                        break;
                    case "2":
                        Console.WriteLine("введите число b");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine("число b = " + b);
                        menu();
                        break;
                    case "+":
                        Console.WriteLine("a+b= " + plus(a, b));
                        break;
                    case "-":
                        Console.WriteLine("a-b= " + minus(a, b));
                        break;
                    case "*":
                        Console.WriteLine("a*b= " + umnoj(a, b));
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("делить на ноль низяя!!");
                            menu();
                        }
                        else
                            Console.WriteLine("a/b= " + delit(a, b));
                        break;
                    default:
                        Console.WriteLine("Ошибка! Некорректный ввод!");
                        break;
                }
                //Console.Write("\nНажмите любую клавишу...");
                //Console.ReadLine();
                //Console.Clear();
            }

            double plus(double a1, double b2)
            {
                return 0;
            }

            double minus(double a1, double b2)
            {
                return 0;
            }

            double umnoj(double a1, double b2)
            {
                return a1*b2;
            }

            double delit(double a1, double b2)
            {
                return 0;
            }
        }
    }
}
