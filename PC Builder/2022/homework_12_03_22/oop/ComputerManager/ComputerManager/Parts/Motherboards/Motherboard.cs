using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerManager.Parts.Motherboards
{
    public abstract class Motherboard : IPart
    {
        private readonly int _amountSocket;

        public Motherboard(int amountSocket)
        {
            if (amountSocket <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amountSocket));
            }

            _amountSocket = amountSocket;
        }

        public int GetMemorySize()
        {
            return _amountSocket;
        }

        public virtual string GetInfo()
        {
            return $"Amount of sockets: {GetMemorySize()}";
        }
    }
}
