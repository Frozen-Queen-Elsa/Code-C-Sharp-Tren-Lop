using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_kethua.TruuTuong
{
    public class Rectangle:Shape
    {
        public double height, width;
        public override void Input()
        {
            Console.Write("Nhập chieu dai hinh chu nhat : ");
            height = double.Parse(Console.ReadLine().Trim());
            Console.Write("Nhập chieu dai hinh chu nhat : ");
            width = double.Parse(Console.ReadLine().Trim());
        }

        public override double Area()
        {
            return (height*width);
        }


        public override double Perimeter()
        {
            return (2*(height+width));
        }
    }
}
