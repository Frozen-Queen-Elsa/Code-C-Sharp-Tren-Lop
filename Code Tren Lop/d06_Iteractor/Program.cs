using d06_generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace d06_Iteractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.TestEmployeeList();
            p.TestEmployeeListIterator();
        }

        void TestEmployeeList()
        {
            string op = "";
            EmployeeList elist = new EmployeeList();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU ");
                Console.WriteLine("1 . Them nhan vien");
                Console.WriteLine("2 . Hien thi danh sach nhan vien");
                Console.WriteLine("3 . Hien thi danh sach nhan vien theo ten ");
                Console.WriteLine("4 . Thoat");
                Console.WriteLine("Nhap ma so chuc nang [1-4]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1": elist.Add(); break;
                    case "2": elist.Display(); break;
                    case "3":
                        Console.Write("Nhap ten nhan vien muon tim:  ");
                        elist.Display(Console.ReadLine().Trim());
                         break;
                    case "4": return;
                }

                Console.WriteLine("Nhap phim bat ky de tiep tuc chuong trinh !!");
                Console.ReadKey(true);
            }
        }


        void TestEmployeeListIterator()
        {
            string op = "";
            EmployeeListIterator elist = new EmployeeListIterator();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU (ITERATOR)");
                Console.WriteLine("1 . Them nhan vien");
                Console.WriteLine("2 . Hien thi danh sach nhan vien");
                Console.WriteLine("3 . Hien thi danh sach nhan vien theo ten ");
                Console.WriteLine("4 . Thoat");
                Console.WriteLine("Nhap ma so chuc nang [1-4]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1": elist.Add(); break;
                    case "2":
                        foreach(var item in elist)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "3":
                        Console.Write("Nhap ten nhan vien muon tim:  ");
                        string ten = Console.ReadLine().Trim();
                        int cntTen = 0;
                        foreach(var item in elist)
                        {
                            if (Regex.IsMatch(item.pName, ten, RegexOptions.IgnoreCase))
                            {
                                Console.WriteLine(item);
                                cntTen++;
                            }
                        }
                        if (cntTen == 0)
                        {
                            Console.WriteLine("Khong tim thay !!");
                        }

                        break;
                    case "4": return;
                }

                Console.WriteLine("Nhap phim bat ky de tiep tuc chuong trinh !!");
                Console.ReadKey(true);
            }
        }
    }
}
