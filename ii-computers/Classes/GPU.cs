using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii_computers
{
    public class GPU
    {
        public string manufacturer { get; set; }
        public int videoMemoryCount { get; set; }
        public double freq { get; set; }

        public GPU(string manufctor, int videoMemoryCount, double freq)
        {
            this.manufacturer = manufctor;
            this.videoMemoryCount = videoMemoryCount;
            this.freq = freq;
        }
    }
}
