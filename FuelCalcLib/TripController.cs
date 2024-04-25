namespace FuelCalcLib
{
    public class TripController
    {
        public TripModel model { get; set; }
        public TripController() { }
        public TripController(TripModel model) {  this.model = model; }
        public int Calculate() => ((model.Distance /100) * model.Avarage ) * model.FuelCost;
    }
}
