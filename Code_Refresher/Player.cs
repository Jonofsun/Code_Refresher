using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Refresher
{
    public class Player
    {
        string _name;
        int _number;

        public Player(string name, int number)
        {
            _name = name;
            _number = number;
        }

        public string Name { get => _name; set => _name = value; }
        public int Number { get => _number; set => _number = value; }

        public override string ToString()
        {
            return $"{_name} - Lvl: {_number}";
        }
    }
}
