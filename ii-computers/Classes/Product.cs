using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ii_computers.Classes
{
    public class Product
    {
        public string nameOfProduct;
        public int cpuCores;
        public int gpuCount;
        public int ramCount;
        public string OS;
        public string videoProcessing;
       


        public Product(string nameOfProduct, int cpuCores, int gpuCount, int ramCount, string OS, string videoProcessing) 
        {
            this.nameOfProduct = nameOfProduct;
            this.cpuCores = cpuCores;
            this.gpuCount = gpuCount;
            this.ramCount = ramCount;
            this.OS = OS;
            this.videoProcessing = videoProcessing;
        }

        public string ReturnProduct(Product prod) 
        {
            return String.Format("Name: " + "{0}\n" +
                                 "OS: " +  "{4}\n" +
                                 "videoProcessing:" + "{5}\n"+
                                 "____________________________________________________________\n" +
                                 "CPU\tGPU\tRAM\n" +
                                 "{1}\t{2}\t{3}",
                                 prod.nameOfProduct, prod.cpuCores, prod.gpuCount, prod.ramCount, prod.OS, prod.videoProcessing);
        }



    }
}
