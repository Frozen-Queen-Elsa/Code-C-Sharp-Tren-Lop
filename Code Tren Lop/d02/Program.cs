using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d02
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = "";
            MethodDemo md = new MethodDemo();
            int a = 0, b = 0, c = 0;
            double x1 = 0, x2 = 0;
            while (true)
            {
                Console.Clear(); // xóa màn hình
                Console.WriteLine("====== MENU ======");
                Console.WriteLine("1. Default parameter");
                Console.WriteLine("2. Static members");
                Console.WriteLine("3. Giai PT bac 2 (pass by value - default)");
                Console.WriteLine("4. Giai PT bac 2 (pass by reference)");
                Console.WriteLine("5. Exit");
                Console.Write("Input function number[1-5]: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        md.method1();
                        md.method1("Hello, .NET Framework !");
                        break;
                    case "2":
                        MethodDemo.method2();
                        break;
                    case "3":
                        Console.Write("Nhap a: ");
                        a = int.Parse(Console.ReadLine().Trim());
                        Console.Write("Nhap b: ");
                        b = int.Parse(Console.ReadLine().Trim());
                        Console.Write("Nhap c: ");
                        c = int.Parse(Console.ReadLine().Trim());

                        if (md.ptb2(a, b, c, x1, x2))
                        {
                            Console.WriteLine("\n Phuong trinh bac 2 : {0}x2+ {1}x +{2} co 2 nghiem: ", a, b, c);
                            Console.WriteLine("x1 = {0:F2}, x2 ={1:F2}", x1, x2);
                        }
                        else
                        {
                            Console.WriteLine("Phuong trinh vo nghiem! ");
                        }

                        break;
                    case "4":
                        Console.Write("Nhap a: ");
                        a = int.Parse(Console.ReadLine().Trim());
                        Console.Write("Nhap b: ");
                        b = int.Parse(Console.ReadLine().Trim());
                        Console.Write("Nhap c: ");
                        c = int.Parse(Console.ReadLine().Trim());
                        if (md.ptb2bis(a, b, c, ref x1, ref x2))
                        {
                            Console.WriteLine("\n Phuong trinh bac 2 : {0}x2+ {1}x1 +{2} co 2 nghiem: ", a, b, c);
                            Console.WriteLine("x1 = {0:F2}, x2 ={1:F2}", x1, x2);
                        }
                        else
                        {
                            Console.WriteLine("Phuong trinh vo nghiem! ");
                        }

                        break;
                    case "5": return;
                    default: break;
                }

                Console.Write("Press any key to continue ...");
                Console.ReadKey();
            }
        }
    }
}