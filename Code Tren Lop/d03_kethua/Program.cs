using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using d03_kethua.KeThua;
using d03_kethua.TruuTuong;
namespace d03_kethua
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.DemoTruuTuong();

            Console.ReadKey();
        }

        void DemoKeThua()
        {
            Console.WriteLine("Demo Inheritance");
            d03_kethua.KeThua.Monitor m1 = new KeThua.Monitor();
            Console.WriteLine("Monitor :  {0}", m1);


            Monitor m2 = new Monitor();
            m2.Input();
            Console.WriteLine("Monitor :  {0}", m2);


            Console.ReadKey();
        }

        void DemoTruuTuong()
        {
            Console.WriteLine("\n Demo Abtract Class");
            Shape s1 = new Circle();
            Shape s2 = new Rectangle();
            s1.Input();
            s2.Input();


            string s = "";
            s = s1 is Circle ? "Hinh Tron" : "Hinh Chu Nhat";
            Console.WriteLine("Hinh 1 : {0}: {1} \n", s, s1);
            s = s2 is Circle ? "Hinh Tron" : "Hinh Chu Nhat";
            Console.WriteLine("Hinh 2 : {0}: {1} \n", s, s2);
        }
    }
}
