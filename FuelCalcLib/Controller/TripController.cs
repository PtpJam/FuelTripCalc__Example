using FuelCalcLib.Models;

namespace FuelCalcLib.Controller
{
    public class TripController
    {
        public TripModel model { get; set; }
        public CarModel? car { get; set; }

        public TripController() { }

        public TripController(TripModel model) { this.model = model; }
        public TripController(TripModel model, CarModel car) { this.model = model; this.car = car; }

        public TripController(CarModel? car)
        {
            this.car = car;
        }

        public virtual int  Calculate() => model.Distance / 100 * model.Avarage * model.FuelCost;
    }
}
