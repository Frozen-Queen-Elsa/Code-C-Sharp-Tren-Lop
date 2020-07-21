using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_10
{
    public class Engineer : Employee
    {
        public int Allowance;

        public override int CalSalary()
        {
            return(pSalary * pDays)/24 + Allowance;
        }

       public override void Input()
        {
            //Nhap ID
            while (true)
            {
                base.Input();
                try
                {
                    Console.WriteLine("Nhap Allowance : ");
                    Allowance = int.Parse(Console.ReadLine().Trim());
                    if(Allowance>=0)
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }//Ket thuc Allowance
        }

        public override void Display()
        {
            Console.WriteLine("Bang Luong chi tiet");
            Console.WriteLine($"id: {pID}");
            Console.WriteLine($"Ho ten: {FullName}");
            Console.WriteLine($"Luong CB: {pSalary}");
            Console.WriteLine($"Phu Cap : {Allowance}");
            Console.WriteLine($"So ngay lam viec: {pDays}");
            Console.WriteLine($">> Luong thuc lanh: {CalSalary()}");
        }
    }
}
