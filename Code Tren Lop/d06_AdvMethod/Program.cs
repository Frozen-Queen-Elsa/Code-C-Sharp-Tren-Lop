using System;
using System.Runtime.Serialization;

namespace d06_AdvMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************ANONYMOUS METHOD***********************");
            DemoAnoMethod d1 = new DemoAnoMethod();
            d1.test();

            Console.WriteLine("***********************EXTENSION METHOD***********************");
            Console.Write("Nhap ho ten cua ban: ");
            string hoten = Console.ReadLine().Trim();
            Console.Write("Nhap chuoi ki tu bat ki: ");
            string m = Console.ReadLine().Trim();
            if (hoten.ContainIgnocase(m))
            {
                Console.WriteLine($"[{m}] co xuat hien trong [{hoten}]");
            }
            else {
                Console.WriteLine("Khong tim thay");
            }

        }
    }
}
