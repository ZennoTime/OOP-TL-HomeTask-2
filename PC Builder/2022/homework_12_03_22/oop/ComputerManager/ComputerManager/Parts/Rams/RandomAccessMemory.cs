using System;

namespace ComputerManager.Parts.Rams
{
    public abstract class RandomAccessMemory : IPart
    {
        private readonly int _memorySize;

        public RandomAccessMemory(int memorySize)
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
