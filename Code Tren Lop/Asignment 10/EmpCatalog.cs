using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_10
{
    public class EmpCatalog
    {
        List<Engineer> eList = new List<Engineer>();
        public Engineer Add
        {
            set
            {
                eList.Add(value);
            }
        }

        public void DisplayAll()
        {
            if (eList.Count == 0)
            {
                Console.WriteLine("HT chua co du lieu");
                return;
            }
            Console.WriteLine("Danh sach ky so : ");
            eList.ForEach(item => Console.WriteLine(item));
        }

        public IEnumerable<Engineer> GetSenior()
        {
            if (eList.Count == 0)
            {
                Console.WriteLine("HT chua co du lieu");
                yield break;
            }
            var x500=eList.FindAll(ks => ks.CalSalary() >= 500).ToList();
            if (x500.Count == 0)
            {
                Console.WriteLine("Ko tim thay ky su bac luong >=500 !");
                yield break;
            }
            foreach(var item in x500)
            {
                yield return item;
            }
        }
        

    }

    
}
