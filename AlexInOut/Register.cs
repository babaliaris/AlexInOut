using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexInOut
{
    public class Register
    {
        public string category;
        public string type;
        public decimal value;
        public DateTime date;

        public Register()
        {
        }

        public Register(string cat, string tp, decimal val, DateTime da)
        {
            category = cat;
            type     = tp;
            value    = val;
            date     = da;
        }
    }
}
