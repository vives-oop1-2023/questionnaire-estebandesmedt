using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreboard
{
    public class Playerscore
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Score}";
        }
    }
}
