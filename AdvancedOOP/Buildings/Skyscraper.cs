using AdvancedOOP.Rooms;

namespace AdvancedOOP.Buildings
{
    class Skyscraper : Building
    {
        public Bathroom bathroom;
        public bool hasBalcony;
        public double height;
        public Basement basement;


        public Skyscraper(Bathroom bathroom, bool hasBalcony, double height, Basement basement, string material, string postcode, bool insured) : base(material, postcode, insured)
        {
            this.bathroom = bathroom;
            this.hasBalcony = hasBalcony;
            this.height = height;
            this.basement = basement;
        }
    }
}
