using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii_computers.Classes
{
    public class Computer
    {
        public CPU cpu { get; set; }
        public GPU gpu { get; set; }
        public RAM ram { get; set; }
        public string OS { get; set; }
        public string videoProcessing { get; set; }


        public Computer(CPU cpu, GPU gpu, RAM ram, string OS, string videoProcessing) 
        {
            this.cpu = cpu;
            this.gpu = gpu;
            this.ram = ram;
            this.OS = OS;
            this.videoProcessing = videoProcessing;
        }

        public string ReturnComputerSpecsAsString() 
        {
            return String.Format(
                                 "_____________________\n"+
                                 "Prod.\tCores\tFreq.\n" +
                                 "{0}\t{1}\t{2}\n" +

                                 "_____________________\n" +
                                 "Prod.\tVideo\tFreq.\n" +
                                 "{3}\t{4}\t{5}\n" +

                                 "_____________________\n" +
                                 "Prod.\tMemory\tFreq.\n" +
                                 "{6}\t{7}\t{8}",
                                 cpu.manufacturer,cpu.coresCount,cpu.freq,
                                 gpu.manufacturer,gpu.videoMemoryCount,gpu.freq,
                                 ram.manufacturer,ram.count,ram.freq);
        }
    }
}
