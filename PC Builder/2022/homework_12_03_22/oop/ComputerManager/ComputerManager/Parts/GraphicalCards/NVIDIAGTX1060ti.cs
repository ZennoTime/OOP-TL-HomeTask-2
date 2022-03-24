using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerManager.Parts.GraphicalCards
{
    public class NVIDIAGTX1060ti : GraphicalCard
    {
        public NVIDIAGTX1060ti()
            : base(memorySize: 6)
        {
        }

        public override string GetInfo()
        {
            return @$"
    ////////////////////////////////{Environment.NewLine}
    NVIDIA - THE WAY IT'S MEANT TO BE PLAYED
    {Environment.NewLine}{base.GetInfo()}{Environment.NewLine}
    ////////////////////////////////";
        }
    }
}

