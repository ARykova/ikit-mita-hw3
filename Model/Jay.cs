using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jay : Gambler
    {
        public Jay() : base ("Jay")
        {
        }

        public override void FetchNewNumber(int i)
        {
            if (i.IsEven()) { Score++; }
        }
    }
}
