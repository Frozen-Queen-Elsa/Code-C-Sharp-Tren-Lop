using d03_kethua.KeThua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_kethua.KeThua
{
    public class Monitor:Hardware
    {
        public string size;

        public Monitor() : base()
        {
            size = "15 inches";
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", id, name, price,size);
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap kich thuoc :");
            size = Console.ReadLine().Trim();
        }
    }
}
