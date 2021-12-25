using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii_computers
{
    public class CPU
    {
        public string manufacturer { get; set; }
        public int coresCount { get; set; }
        public double freq { get; set; }

        public CPU(string manufctor, int coresCount, double freq) 
        {
            this.manufacturer = manufctor;
            this.coresCount = coresCount;
            this.freq = freq;
        }
    }
}
