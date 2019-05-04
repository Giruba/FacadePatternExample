using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class GeneralElectionsBody
    {
        public void ConductElections() {
            Democracy democracy1 = new IndianGovernment().ConductElections();
            Console.WriteLine(democracy1.ToString());
            Console.WriteLine();
            Democracy democracy2 = new XCountryGovernment().ConductElections();                        
            Console.WriteLine(democracy2.ToString());
        }
    }
}
