using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ii_computers.Classes
{
    public class SetProgressWork
    {
        public int state { get; set; }
        public SetProgressWork(ProgressBar pb, double value, ToolTip tip) 
        {
            
            pb.Value = 0;
            pb.Maximum = 100;
            pb.Value = (int)(value * 100);

            if (pb.Value == 0)
                pb.Value = 5;

            if (value < 0.5)
                pb.SetState(2);
            if (value >= 0.5 && value < 0.8)
                pb.SetState(3);


            tip.SetToolTip(pb, value.ToString());

            pb.Update();
        }
        
    }
   
}
