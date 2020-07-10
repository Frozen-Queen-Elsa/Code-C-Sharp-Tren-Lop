using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04
{
    public class Numbers
    {
        int[] odds = { 1, 3, 5 };
    //indexer cho mang odds;
    public int this[int i]
        {
            get
            {
                return odds[i];
            }
            set
            {
                odds[i] = value;
            }
        }

        //Property cho biet so phan tu cua mang
        public int pLen
        {
            get
            {
                return odds.Length;
            }
        }
    }
}
