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

        private Random _rnd { get; set; }

        public void Generate()
        {
            if (_rnd == null) _rnd = new Random();
            NewNumber(_rnd.Next());
        }
    }
}
