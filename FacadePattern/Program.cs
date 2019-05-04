using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade Pattern!");
            Console.WriteLine("---------------");

            new GeneralElectionsBody().ConductElections();

            Console.ReadLine();
        }
    }
}
