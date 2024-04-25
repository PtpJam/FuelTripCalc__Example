namespace FuelCalcLib
{
    public class TripModel
    {
        public TripModel()
        {
        }

        public TripModel(int distance, int avarage, int fuelCost)
        {
            Distance = distance;
            Avarage = avarage;
            FuelCost = fuelCost;
        }

        public int Distance { get; set; }
        public int Avarage { get; set; }
        public int FuelCost { get; set; }
    }
}