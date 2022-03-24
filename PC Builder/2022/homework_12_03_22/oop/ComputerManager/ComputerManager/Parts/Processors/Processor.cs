using System;

namespace ComputerManager.Parts.Processors
{   
    public abstract class Processor : IPart
    {
        private readonly int _countOfCores;

        public Processor(int countOfCores)
        {
            if (countOfCores <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(countOfCores));
            }

            _countOfCores = countOfCores;
        }

        public int GetCountCores()
        {
            return _countOfCores;
        }

        public virtual string GetInfo()
        {
            return $"Counts of cores: {GetCountCores()}";
        }
    }
}