using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_generic
{
    public delegate void DGeneric<T, U>(T a, U b);
    public class DemoGenericDelegate
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"{a}+{b}={c}");
        }
        public void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine($"{a}-{b}={c}");
        }

        public void Concate(string a, string b)
        {
            string c = a +","+ b;
            Console.WriteLine($"{a}+{b}={c}");
        }

        public void Test()
        {
            DGeneric<int, int> d1 = Add;
            d1 += Sub;

            d1(20, 5);

            DGeneric<string, string> d2 = Concate;
            d2("Hello", "Dung");
        }
    }
}
