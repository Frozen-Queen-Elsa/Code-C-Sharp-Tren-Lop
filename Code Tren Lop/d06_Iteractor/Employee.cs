using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace d06_generic
{
    public class Employee
    {
        string id;
        string name;
        int salary;

        //Property cho id - Dinh dang Exxx+
        public string pID
        {
            get { return id; }
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, "^E\\d{3,}$")) 
                {
                    id = value;
                }
                else
                {
                    throw new Exception("ID khong hop le ! [Exxx+]");
                }
            }
        }//Ket thuc pID

        //Property cho name tu 1 -> 30 ky tu chu 
        public string pName
        {
            get { return name; }
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, "^[a-z ]{1,30}$",RegexOptions.IgnoreCase))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name khong hop le! 1->30 ky tu chu ");
                }
            }
        }//Ket thuc pName

        //Property cho salary [100-100000]
        public int pSalary
        {
            get{ return salary; }
            set
            {
                if(value>=100 && value <= 100000)
                {
                    salary = value;
                }
                else
                {
                    throw new Exception("Salary khong hop le ! [100-100000]");
                }
            }
        }//Ket thuc pSalary



        public override string ToString()
        {
            return string.Format($"{id},{name},{salary}");
        }
    }
}
