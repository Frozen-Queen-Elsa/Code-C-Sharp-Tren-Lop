using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu();
        }

        static void Menu()
        {
            string op = "";
            EmpCatalog ec = new EmpCatalog();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1. Them KS");
                Console.WriteLine("2. In danh sach KS");
                Console.WriteLine("3. In danh sach KS co muc luong >=500");
                Console.WriteLine("4. Thoat");
                Console.Write("Nhap chuc nang [1-4]");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        Engineer kysu = new Engineer();
                        kysu.Input();
                        ec.Add = kysu;
                        break;
                    case "2":
                        ec.DisplayAll();
                        break;
                    case "3": 
                        foreach(var item in ec.GetSenior())
                        {
                            item.Display(); 
                        }
                        break;
                    case "4": return;
                }
                Console.WriteLine("\n Bam 1 phim bat ky de tiep tuc chuong trinh ...");
                Console.ReadKey(true);
            }
        }
    }
}
