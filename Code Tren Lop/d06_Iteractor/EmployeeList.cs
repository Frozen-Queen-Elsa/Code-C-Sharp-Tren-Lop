using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace d06_generic
{
    public class EmployeeList
    {
        //Luu danh sach nhan vien vo Sorted List [ds]
        SortedList<string, Employee> ds = new SortedList<string, Employee>();

        public void Add()
        {
            Employee nv= new Employee();

            //Nhap du lieu cho doi tuong nhan [nv]
            //Nhap ma so 
            while (true)
            {
                try
                {
                    Console.Write("Nhap ID : ");
                    nv.pID = Console.ReadLine().Trim();

                    if (ds.ContainsKey(nv.pID) == true)
                    {
                        Console.WriteLine(">> Loi sai : ID da ton tai !!");
                        continue;
                    }
                    break;

                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Loi: "+e.Message);
                }
            }//Ket thuc nhap pID

            //Nhap name 
            while (true)
            {
                try
                {
                    Console.Write("Nhap Name: ");
                    nv.pName = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }//Ket thuc nhap pName

            //Nhap luong 
            while (true)
            {
                try
                {
                    Console.Write("Nhap Salary : ");
                    nv.pSalary = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }//Ket thuc nhap pSalary

            //Sau khi nhap du 3 thuoc tinh id,name,salary => Luu doi tuong [nv] vo [ds]
            ds.Add(nv.pID, nv);
            Console.WriteLine("Them nhan vien moi thanh cong !");

        }//Ket thuc Add


        //Ham in danh sach nhan vien
        public void Display()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                return;
            }
            Console.WriteLine("Danh sach nhan vien ");
            foreach (var item in ds.Values)
            {
                Console.WriteLine(item);
            }
        }//Ket thuc ham Display

        //Ham in danh sach nhan vien theoten
        public void Display(string tenNV)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                return;
            }
            int cntTen = 0;
            Console.WriteLine("Danh sach nhan vien ");
            foreach (var item in ds.Values)
            {
                if (Regex.IsMatch(item.pName, tenNV, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(item);
                    cntTen++;
                }
                
            }//Ket thuc foreach

            if (cntTen == 0)
            {
                Console.WriteLine("Khong tim thay !!");
            }

        }//Ket thuc ham Display

    }
}
