using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerManager.Parts.Motherboards
{
    public class GIGABYTEA5 : Motherboard
    {
        public GIGABYTEA5()
            : base(amountSocket : 6)
        {
        }

        public override string GetInfo()
        {
            return @$"
    ////////////////////////////////{Environment.NewLine}
    MOTHERBOARD 
    {Environment.NewLine}{base.GetInfo()}{Environment.NewLine}
    ////////////////////////////////";
        }
    }
}
