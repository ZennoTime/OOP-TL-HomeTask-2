using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerManager.Parts.Processors
{
    public class IntelCoreI5 : Processor
    {
        public IntelCoreI5()
            : base(countOfCores: 5)
        {
        }
        public override string GetInfo()
        {
            return @$"
    ////////////////////////////////{Environment.NewLine}
    INTEL MAKES GREAT PROCESSORS
    {Environment.NewLine}{base.GetInfo()}{Environment.NewLine}
    ////////////////////////////////";
        }
    }
}

