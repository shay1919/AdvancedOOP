namespace AdvancedOOP.Rooms
{
    class Kitchen
    {
        public bool hasAirFryer;
        public bool hasMicrowave;
        public bool hasKettle;

        public Kitchen(bool hasAirFryer, bool hasMicrowave, bool hasKettle)
        {
            this.hasAirFryer = hasAirFryer;
            this.hasMicrowave = hasMicrowave;
            this.hasKettle = hasKettle;
        }
    }
}