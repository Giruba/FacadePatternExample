using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class XCountryGovernment : IGovernment
    {
        public Democracy ConductElections() {
            Console.WriteLine("XCountryGovernment");
            return new PresidentialDemocracy("XCountryGovernment - Presedential Democracy");
        }
    }
}
