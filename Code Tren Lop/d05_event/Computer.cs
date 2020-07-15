using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event
{
    public class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("Loi nhap sai du lieu");
        }
        public MyException(string s) : base(s)
        {

        }
    }

    class Computer
    {
        private string id, name;
        private int price;

        //property pID cho id - id co format "C-xxx"
        public string pID
        {
            get
            {
                return id;
            }
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, "^C-\\d{3}$"))
                {
                    id = value;
                }
                else
                {
                    throw new MyException("ID khong hop le . [C-xxx]");
                }
            }
        }//Ket thuc pID

        //Property pname cho name - Khong duoc rong va nhieu nhat 20 ky tu 
        public string pName
        {
            get { return name; }
            set
            {
                if (value.Trim().Length>0 && value.Trim().Length <= 20)
                {
                    name = value;
                }
                else
                {
                    throw new MyException("Ten khong hop le - Khong duoc rong va it hon 20 ky tu");
                }
            }
        }//Ket thuc property

        //Property pPrice cho price : [100-100000]
        public int pPrice
        {
            get { return price; }
            set
            {
                if(value >=100 && value <=100000)
                {
                    price = value;
                }
                else
                {
                    throw new MyException("Price khong hop le : [100-100000]");
                }
            }
        }//Ket thuc pPrice

        public void Input()
        {
            Console.WriteLine("\n Nhap thong tin may tinh Computer: ");
            //Nhap ID
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap ID");
                    pID = Console.ReadLine().Trim();
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Loi :"+e.Message);
                }
            }//Ket thuc ID

            //Nhap Name
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap Name");
                    pName = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi :" + e.Message);
                }
            }//Ket thuc Name

            //Nhap Price
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap Price");
                    pPrice = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi :" + e.Message);
                }
            }//Ket thuc Price

        }


        public override string ToString()
        {
            return string.Format(" {0}, {1}, {2}",id,name,price);
        }

    }
}
