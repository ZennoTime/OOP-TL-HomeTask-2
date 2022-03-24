using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerManager.Parts.Rams
{
    public class HyperX : RandomAccessMemory
    {
        public HyperX()
            : base(memorySize: 12)
        {
        }

        public override string GetInfo()
        {
            return @$"
    ////////////////////////////////{Environment.NewLine}
    HYPERX IS THE BEST COMPANY 
    {Environment.NewLine}{base.GetInfo()}{Environment.NewLine}
    ////////////////////////////////";
        }
    }
}
