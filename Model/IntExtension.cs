using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class IntExtension
    {
        public static bool IsEven (this int i)
        {
            if (i % 2 == 0) return true;
            else return false;
        }
    }
}
