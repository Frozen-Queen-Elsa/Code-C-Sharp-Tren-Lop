using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_generic
{
    //Định nghĩa class generic Student có 3 tham số kiểu (type parameterize ) 
    public class Student<T,U,V>
    {
        public T id;
        public string name;
        public U dob;
        public V gender;

        public override string ToString()
        {
            return string.Format($"{id},{name},{dob},{gender}");
        }
    }
}
