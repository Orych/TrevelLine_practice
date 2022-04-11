using computer.Parts.Motherboards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts.MotherBoards
{
    public class Supermicro : Motherboard
    {
        public Supermicro()
            : base(amountOfSocket: 6)
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