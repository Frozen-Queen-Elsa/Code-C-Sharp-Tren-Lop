using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDemo a = new ArrayDemo();
            a.arrayInt();
            Console.ReadKey();

            Console.Clear();
            a.arrayString();
            Console.ReadKey();
        }
    }

    
}
