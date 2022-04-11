using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer.Parts.Motherboards
{
    public abstract class Motherboard : IPart
    {
        private readonly int amountSocket;

        public Motherboard(int amountOfSocket)
        {
            if (amountOfSocket <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amountOfSocket));
            }

            amountSocket = amountOfSocket;
        }

        public int GetAmountOfSocket()
        {
            return amountSocket;
        }

        public virtual string GetInfo()
        {
            return $"Amount of sockets: {GetAmountOfSocket()}";
        }
    }
}