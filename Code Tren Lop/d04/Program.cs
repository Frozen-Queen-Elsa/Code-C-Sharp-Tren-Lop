using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Menu();

            // pro.Demo();


            Console.ReadKey();
        }

        void Menu()
        {
            ATMAccount atmACC = new ATMAccount();
            int amt = 0;
            string op = "";
            while (true)
            {
                
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1. Rut tien");
                Console.WriteLine("2. Nap tien");
                Console.WriteLine("3. Xem so du");
                Console.WriteLine("4. Thoat");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        Console.WriteLine("Nhap so tien muon rut:");
                        amt = int.Parse(Console.ReadLine().Trim());
                        atmACC.pWithdraw = amt;
                        break;
                    case "2":
                        Console.WriteLine("Nhap so tien muon rut:");
                        amt = int.Parse(Console.ReadLine().Trim());
                        atmACC.pDeposit = amt;
                        break;
                    case "3":
                        Console.WriteLine("{0}",atmACC);
                        break;
                }
                Console.WriteLine("\nBam 1 phim bat ky de tiep tuc");
                Console.ReadKey();
            }
        }


        void Demo()
        {
            Student sv = new Student();

            sv.pID = "ST000";
            sv.pName = "Dung";
            sv.pYob = 2001;
            Console.WriteLine("Thong tin sinh vien");
            Console.WriteLine("Ma so : {0}", sv.pID);
            Console.WriteLine("Ma so : {0}", sv.pName);
            Console.WriteLine("Ma so : {0}\n", sv.pYob);

            Student sv2 = new Student();

            sv2.pID = "ABC";
            sv2.pName = "An";
            sv2.pYob = 2019;
            Console.WriteLine("Thong tin sinh vien");
            Console.WriteLine("Ma so : {0}", sv2.pID);
            Console.WriteLine("Ma so : {0}", sv2.pName);
            Console.WriteLine("Ma so : {0}", sv2.pYob);

            Console.WriteLine();
            Employee e1 = new Employee();
            Console.WriteLine("Thong tin nhan vien : ");
            Console.WriteLine(e1);

            Console.WriteLine();
            Employee e2 = new Employee()
            {
                id = "E01",
                name = "Dung",
                salary = 2000
            };
            Console.WriteLine("Thong tin nhan vien : ");
            Console.WriteLine(e2);

            Console.WriteLine();
            Console.WriteLine("Demo Indexer");
            Numbers oNum = new Numbers();
            Console.WriteLine("Phan tu cuoi : {0}", oNum[oNum.pLen - 1]);

            //Gan gia tri cho phan tu dau tien 
            oNum[0] = 13;
            Console.WriteLine("Phan tu dau tien : {0}", oNum[0]);
        }
    }
}
