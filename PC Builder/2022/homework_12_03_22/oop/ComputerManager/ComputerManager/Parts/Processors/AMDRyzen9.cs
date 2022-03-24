using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerManager.Parts.Processors
{
    public class AMDRyzen9 : Processor
    {
        public AMDRyzen9()
            : base(countOfCores: 9)
        {
        }
        public override string GetInfo()
        {
            return @$"
    ////////////////////////////////{Environment.NewLine}
    AMD MAKES GREAT PROCESSORS
    {Environment.NewLine}{base.GetInfo()}{Environment.NewLine}
    ////////////////////////////////";
        }

    }
}
