using computer.Parts;
using System;

namespace сomputer.Parts.Processors
{
    public abstract class Processor : IPart
    {
        private readonly int _amountOfCores;

        public Processor(int amountOfCores)
        {
            if (amountOfCores <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amountOfCores));
            }

            _amountOfCores = amountOfCores;
        }

        public int GetCountCores()
        {
            return _amountOfCores;
        }

        public virtual string GetInfo()
        {
            return $"Counts of cores: {GetCountCores()}";
        }
    }
}