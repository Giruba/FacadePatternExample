using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public abstract class Democracy
    {
        public String NameOfDemocracy;

        public Democracy(String democracyType) {
            NameOfDemocracy = democracyType;
        }

        public abstract Democracy GetElections();
    }
}
