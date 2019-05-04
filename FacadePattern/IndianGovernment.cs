using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class IndianGovernment : IGovernment
    {
        public Democracy ConductElections()
        {
            Console.WriteLine("Indian Government");
            return new ParliamentaryDemocracy("IndianGovernment - Parliamentary");
        }
    }
}
