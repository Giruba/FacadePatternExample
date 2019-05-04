using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class PresidentialDemocracy : Democracy
    {
        public PresidentialDemocracy(String democracyType):base(democracyType) {
            this.NameOfDemocracy = democracyType;
        }

        public override Democracy GetElections()
        {
            return new PresidentialDemocracy("PresidentialDemocracy");
        }
    }
}
