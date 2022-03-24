using System;

namespace ComputerManager.Parts.Rams
{
    public class KingstonRx8 : RandomAccessMemory
    {
        public KingstonRx8()
            : base(memorySize: 12)
        {
        }

        public override string GetInfo()
        {
            return @$"
////////////////////////////////{Environment.NewLine}
KINGSTON IS THE BEST COMPANY
{Environment.NewLine}Memory size: 12{Environment.NewLine}
////////////////////////////////";
        }
    }
}
