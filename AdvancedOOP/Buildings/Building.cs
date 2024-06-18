using System;

namespace AdvancedOOP.Buildings
{
    abstract class Building
    {
        public String material;
        public String postcode;
        public bool insured;

        public Building(string material, string postcode, bool insured)
        {
            this.material = material;
            this.postcode = postcode;
            this.insured = insured;
        }

        public void Bulldoze()
        {
            Console.WriteLine($"Building at {postcode} has been bulldozed.");
        }

        public void Insulate()
        {
            Console.WriteLine($"Building at {postcode} has been insulated.");
        }


    }
}
