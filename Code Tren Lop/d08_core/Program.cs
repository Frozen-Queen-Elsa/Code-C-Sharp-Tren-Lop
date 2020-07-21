using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d08_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gia thua mot so nguyen duong n");
            int n = int.Parse(Console.ReadLine().Trim());
            GiaiThua(n);
            Console.ReadKey(true);
        }
        static void GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq = kq * i;
            }
            Console.WriteLine($"{n}!={kq}");
        }
    }
}