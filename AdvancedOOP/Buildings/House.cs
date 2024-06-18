using AdvancedOOP.Rooms;

namespace AdvancedOOP.Buildings
{
    class House : Building
    {   
        public Bathroom bathroom;
        public Kitchen kitchen;
        public double gardenWidth;
        public double gardenLength;

        public House(Bathroom bathroom, Kitchen kitchen, double gardenWidth, double gardenLength, string material, string postcode, bool insured) : base(material, postcode, insured)
        {   
            this.bathroom = bathroom;
            this.kitchen = kitchen;
            this.gardenWidth = gardenWidth;
            this.gardenLength = gardenLength;
        }

        public void MowTheLawn()
        {
            Console.WriteLine($"The lawn at {postcode} has been mowed.");
        }
    }
}