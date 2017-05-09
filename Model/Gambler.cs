using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Gambler
    {
        public Gambler (string name)
        {
            _name = name;
        }

        private string _name;
        public string Name
        {
            get
            { return _name; }
        }

        //private int _score;
        public int Score { get; protected set; }

        public abstract void FetchNewNumber(int i);
    }
}
