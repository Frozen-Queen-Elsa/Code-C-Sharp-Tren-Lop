using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event
{
    //Quan ly danh sach cac may tinh trong arrayList
    class ComputerArrayList
    {
        System.Collections.ArrayList ds = new System.Collections.ArrayList();

        //Ham them 1 computer vo danh sach
        public void Add()
        {
            Computer c = new Computer();
            c.Input();
            ds.Add(c);
        }



        //Ham in danh sach cac may tinh co don 
        public void Display()
        {
            
            Console.WriteLine("Danh sach cac May Tinh  : ");
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }     
           
        }


        //Ham in danh sach cac may tinh co don gia lon hon 100
        public void Display100()
        {
            if(ds.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                return;
            }
            int count100 = 0;
            Console.WriteLine("Danh sach cac May Tinh co don gia lon 100 : ");
            foreach(var item in ds)
            {
                Computer c = (Computer)item;
                if (c.pPrice > 100)
                {
                    Console.WriteLine(item);
                    count100++;
                }
               
            }//Ket thuc for
            if(count100 == 0)
            {
                Console.WriteLine("Khong tim thay");
            }
        }

        public void Menu()
        {
            string op = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1 . Them Computer ");
                Console.WriteLine("2 . In danh sach Computer ");
                Console.WriteLine("3 . In danh sach Computer co don gia >100");
                Console.WriteLine("4. Thoat");
                Console.WriteLine("Vui long nhap chuc nang [1-4]");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1": Add(); break;
                    case "2": Display(); break;
                    case "3": Display100(); break;
                    case "4": return;
                }

                Console.Write("Bam 1 phim bat ky de tiep tuc chuong trinh ...");
                Console.ReadKey();
            }

            
        }
    }
}
