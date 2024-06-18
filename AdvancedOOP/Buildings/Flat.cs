using AdvancedOOP.Rooms;

namespace AdvancedOOP.Buildings
{
    class Flat : Building
    {
        public Bathroom bathroom;
        public bool hasBalcony;


        public Flat(Bathroom bathroom, bool hasBalcony, string material, string postcode, bool insured) : base(material, postcode, insured)
        {
            this.bathroom = bathroom;
            this.hasBalcony = hasBalcony;
        }
    }
}
