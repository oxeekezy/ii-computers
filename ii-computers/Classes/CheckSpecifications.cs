using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii_computers.Classes
{
    class CheckSpecifications
    {
        public double os = 0.00;
        public double vProcessing = 0.00;
        public double cpu = 0.00;
        public double gpu = 0.00;
        public double ram = 0.00;
        public double min = 0;

        public CheckSpecifications(Computer pc, Product prod) 
        {
            os = SplitAndCheck(prod.OS, pc.OS, '&');
            vProcessing = SplitAndCheck(prod.videoProcessing, pc.videoProcessing, '&');
            cpu = CheckMainParameter(pc.cpu.coresCount, prod.cpuCores);
            gpu = CheckMainParameter(pc.gpu.videoMemoryCount, prod.gpuCount);
            ram = CheckMainParameter(pc.ram.count, prod.ramCount);

            min = GetMinValue(os, vProcessing, cpu, gpu, ram);
        }

        public double SplitAndCheck(string forSplit, string original,char splitter)
        {
            double kf = 0.00;
            if (forSplit.Contains(original))
                kf = 1;

            return kf;
        }

        public double CheckMainParameter(int pcParam, int prodParam)
        {
            double kf = Math.Round(((Double)pcParam / (Double)prodParam), 2);
            if (kf > 1)
                kf = 1.00;
            return kf;
        }

        public string ReturnParametersAsString() 
        {
            return String.Format("PC:\t{0}\t{1}\t{2}\t{3}\t{4}\t|\t{5}\n", cpu, gpu, ram, os, vProcessing,min);
        }

        public double GetMinValue(double os, double vp, double cpu, double gpu, double ram)
        {
            if (os == 0 || vp == 0 || cpu == 0 || gpu == 0 || ram == 0)
                return 0.00;
            else
                return Math.Min(Math.Min(Math.Min(Math.Min(os, vp), cpu), gpu), ram);
        }
    }
}
