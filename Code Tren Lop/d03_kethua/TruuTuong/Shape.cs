using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_kethua.TruuTuong
{
    public abstract class Shape
    {
        
            public double PI = 3.1415;
            public abstract double Area();
            public abstract double Perimeter();

            public abstract void Input();

            public override string ToString()
            {
                return string.Format("DT = {0:F2} , CV ={1:F3}");
            }
        
    }
}
