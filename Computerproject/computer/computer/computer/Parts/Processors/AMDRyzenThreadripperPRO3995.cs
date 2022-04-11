using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сomputer.Parts.Processors
{
    public class AMDRyzenThreadripperPRO3995 : Processor
    {
        public AMDRyzenThreadripperPRO3995()
            : base(amountOfCores: 9)
        {
        }
        public override string GetInfo()
        {
            return @$"
////////////////////////////////{Environment.NewLine}
PROCESSOR
{Environment.NewLine}{base.GetInfo()}{Environment.NewLine}
////////////////////////////////";
        }

    }
}
