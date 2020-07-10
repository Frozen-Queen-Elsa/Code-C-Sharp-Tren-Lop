using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace d03_kethua.KeThua
{
    public class Hardware
    {
        public string id, name;
        public int price;

        public Hardware()
        {
            id = "P01";
            name = "Linh Kien";
            price = 100;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap ID ");
            id = Console.ReadLine().Trim();

                Console.WriteLine("Nhap Ten ");
            name = Console.ReadLine().Trim();

            Console.WriteLine("Nhap Don Gia");
            price = Convert.ToInt32(Console.ReadLine().Trim());
        }
    }
}
