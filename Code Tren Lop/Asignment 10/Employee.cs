using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Asignment_10
{
    public abstract class Employee
    {
        public string FullName;
        private string id;
        private int BaseSalary, WorkDays;

        public string Fullname;

        public string pID
        {
            get { return id; }
            set
            {
                if (Regex.IsMatch(value, "^E\\d{4}$"))
                {
                    id = value;
                }
                else
                {
                    throw new Exception("ID ko hop le Exxxx");
                }
            }
        }
        public int pSalary
        {
            get { return BaseSalary; }
            set
            {
                if(value>=100 && value <= 5000)
                {
                    BaseSalary = value;
                }
                else
                {
                    throw new Exception("Salary khong hop le [100-5000]");
                }
            
            }
        }

        public int pDays
        {
            get { return WorkDays; }
            set
            {
                if (value >= 1 && value <= 31)
                {
                    WorkDays = value;
                }
                else
                {
                    throw new Exception("WorkDays khong hop le [1-31]");
                }

            }
        }

        public abstract void Display();
        public abstract int CalSalary();

        public virtual void Input()
        {
            //Nhap ID
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap ID : ");
                    pID = Console.ReadLine().Trim();
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Loi: "+e.Message);
                }
            }//Ket thuc ID

            //Nhap Name
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap Name : ");
                    FullName = Console.ReadLine().Trim();
                    if(FullName.Length>=0)
                        break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }//Ket thuc Name

            //Nhap Salary
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap Salary : ");
                    pSalary = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }//Ket thuc Salary

            //Nhap Day
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap Work Days : ");
                    pDays = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }//Ket thuc Day
        }// ket thuc input

        public override string ToString() => string.Format($"{id},{FullName},{BaseSalary},{WorkDays}");

    }
}
