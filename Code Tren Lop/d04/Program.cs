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
            Console.WriteLine("Phan tu cuoi : {0}", oNum[oNum.pLen-1]);

            //Gan gia tri cho phan tu dau tien 
            oNum[0] = 13;
            Console.WriteLine("Phan tu dau tien : {0}", oNum[0]);


            Console.ReadKey();
        }
    }
}
