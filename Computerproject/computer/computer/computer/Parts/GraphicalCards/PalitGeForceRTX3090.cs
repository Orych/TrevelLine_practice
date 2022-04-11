using computer.Parts.GraphicalCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer.Parts.GraphicalCards
{
    public class  PalitGeForceRTX3090: GraphicalCard
    {
        public PalitGeForceRTX3090()
            : base(memorySize: 6)
        {
        }

        public override string GetInfo()
        {
            return @$"
////////////////////////////////{Environment.NewLine}
BEST VIDEOCARD FOR GAMING
{Environment.NewLine}{base.GetInfo()}{Environment.NewLine}
////////////////////////////////";
        }
    }
}

