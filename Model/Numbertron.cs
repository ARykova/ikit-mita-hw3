using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public delegate void NewNumberDelegate(int i);

        public event NewNumberDelegate NewNumber;

        public void Generate(Random rnd)
        {
            NewNumber(rnd.Next());
        }
    }
}
