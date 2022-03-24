using System;

namespace ComputerManager.Parts.GraphicalCards
{
    public abstract class GraphicalCard : IPart
    {
        private readonly int _memorySize;
        public GraphicalCard(int memorySize)
        {
            if (memorySize <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(memorySize));
            }
            _memorySize = memorySize;
        }

        public int GetMemorySize()
        {
            return _memorySize;
        }

        public virtual string GetInfo()
        {
            return $"Memory size: {GetMemorySize()}";
        }
    }
}
