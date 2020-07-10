using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_kethua.TruuTuong
{
    public class Circle:Shape
    {
        public override double Area()
        {
            return (PI * radius * radius);
        }

        public double radius;
        public override void Input()
        {
            Console.Write("Nhập chu vi : ");
            radius = double.Parse(Console.ReadLine().Trim());
           
        }

        public override double Perimeter()
        {
            return (PI * radius * 2);
        }

    }
}
