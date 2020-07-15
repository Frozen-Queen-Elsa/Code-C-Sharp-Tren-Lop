using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event
{
    class Program
    {
        static void Main(string[] args)
        {
            //Computer c = new Computer();
            //c.Input();
            //Console.WriteLine("\n Nhap thong tin may tinh Computer: {0} ",c);
            //Laptop l = new Laptop();
            //l.Input();
            //Console.WriteLine("\n Nhap thong tin may tinh Laptop: {0} ", l);
            //Console.ReadKey();

            ComputerArrayList ca = new ComputerArrayList();
            ca.Menu();


        }
    }
}
