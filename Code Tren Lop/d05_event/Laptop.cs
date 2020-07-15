using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event
{
    //1. Dinh nghia delegate Dvalid- ca tham so la 1 chuoi
    public delegate void DValid(string s);


    class Laptop
    {
        //2. Dinh nghia Event - Kiem tra du lieu nhap
        public event DValid EValidation;

        //3. Dinh nghia ham xy ly event
        public void ThuB2(string thongbao)
        {
            throw new MyException(thongbao);
        }

        //4. Khoi Tao event va dang ky ham xu ly event - trong ham dung
        public Laptop()
        {
            EValidation = new DValid(ThuB2);
        }

        private string id, name;
        private int price;

        //property pID cho id - id co format "L-xxx"
        public string pID
        {
            get
            {
                return id;
            }
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, "^L-\\d{3}$"))
                {
                    id = value;
                }
                else
                {
                    //5. Raise Event
                    EValidation("ID khong hop le . [C-xxx]");
                }
            }
        }//Ket thuc pID

        //Property pname cho name - Khong duoc rong va nhieu nhat 20 ky tu 
        public string pName
        {
            get { return name; }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length <= 20)
                {
                    name = value;
                }
                else
                {
                    //5. Raise Event
                    EValidation("Ten khong hop le - Khong duoc rong va it hon 20 ky tu");
                }
            }
        }//Ket thuc property

        //Property pPrice cho price : [100-100000]
        public int pPrice
        {
            get { return price; }
            set
            {
                if (value >= 100 && value <= 100000)
                {
                    price = value;
                }
                else
                {
                    //5. Raise Event
                    EValidation("Price khong hop le : [100-100000]");
                }
            }
        }//Ket thuc pPrice

        public void Input()
        {
            Console.WriteLine("\n Nhap thong tin may tinh Laptop: " );
            //Nhap ID
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhap ID");
                    pID = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi :" + e.Message);
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
            return string.Format(" {0}, {1}, {2}", id, name, price);
        }
    }
}
