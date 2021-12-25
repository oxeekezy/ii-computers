using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii_computers.Classes
{
    public class RAM
    {
        public string manufacturer { get; set; }
        public int count { get; set; }
        public double freq { get; set; }

        public RAM(string manufctor, int count, double freq)
        {
            this.manufacturer = manufctor;
            this.count = count;
            this.freq = freq;
        }
    }
}
