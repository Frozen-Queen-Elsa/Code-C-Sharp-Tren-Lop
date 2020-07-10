using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace d04
{
    public class Student
    {
         string id, name;
         int yob;

        public Student() 
        {
            id = "ST100";
            name = "Minh Thu";
            yob = 2002;
        }

        public string pID
        {
            get { return id; }
            set
            {
                if (Regex.IsMatch(value.Trim(), "^ST\\d{3}$"))
                {
                    id = value;  //Value là dữ liệu gán cho property pID
                }
                else
                {
                    Console.WriteLine("ID khong hop le !");
                }
            }
        } //Ket thuc Property id

            //Property cho field name
        public string pName
        {
            get
            {
                return name;
            }

            set
            {
                if (Regex.IsMatch(value.Trim(),"^[a-z ]{3,20}$", RegexOptions.IgnoreCase))
                {
                    name = value.Trim();
                }
                else
                {
                    Console.WriteLine("Ten khong hop le !");
                }
            }
        }//Ket thuc property pName

        //Property cho Field yob
        public int pYob
        {
            get
            {
                return yob;
            }
            set
            {
                //Lay nam hien hanh
                int currentYear = DateTime.Now.Year;
                int age = currentYear - value;
                if(age>=13 && age< 70)
                {
                    yob = value;
                }
                else
                {
                    Console.WriteLine("Nam sinh khong hop le, tuoi sv phai tu 13-70!");
                }
            }
        }
        
        
        
    }
}

    
    

