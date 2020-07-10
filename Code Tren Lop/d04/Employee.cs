using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04
{

    class Employee
    {
        //auto-implemented properties
        public string id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public override string ToString()
        {
            return string.Format("id={0} , ten={1} , luong ={2}" , id, name,salary);
        }
    }
}
