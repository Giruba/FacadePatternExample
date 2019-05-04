using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class ParliamentaryDemocracy : Democracy
    {
        public ParliamentaryDemocracy(String democracyType) : base(democracyType) {
            NameOfDemocracy = democracyType;
        }

        public override Democracy GetElections()
        {
            return new ParliamentaryDemocracy("ParliamentaryDemocracy");
        }
    }
}
