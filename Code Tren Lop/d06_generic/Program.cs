using d05_generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_generic
{
    class Program
    {

        
        static void Main(string[] args)
        {

            //Demo Generic
            Student<string, int, bool> sv1 = new Student<string, int, bool>
            {
                id = "SV0001", name = "Ngo Thi Doan Dung", dob = 2002, gender = false
            };

            Student<int, DateTime, int> sv2 = new Student<int, DateTime, int>
            {
                id = 100, name = "Vo Minh Thu", dob = DateTime.Parse("2001-10-02"), gender = 0
            };

            Console.WriteLine($"Sinh Vien 1 : {sv1}");
            Console.WriteLine($"Sinh Vien 2 : {sv2}");


            //Demo generic method
            Console.WriteLine("DEMO GENERIC METHOD");
            Console.WriteLine("\nDemo generic method");
            DemoGenericDelegate d = new DemoGenericDelegate();
            d.Test();

            Console.ReadKey(true);

        }
    }
}
