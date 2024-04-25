using Dapper.Contrib.Extensions;
using FuelCalcLib.Models;
using System.Data.SqlClient;

namespace FuelCalcLib.Controller
{
    public class TripDBController : TripController
    {
        public TripDBController()
        {
        }

        public TripDBController(TripModel model) : base(model)
        { }

        public TripDBController(CarModel? car) : base(car)
        {
        }

        public TripDBController(TripModel model, CarModel car) : base(model, car)
        { }


        public override int Calculate()
        {
            using (var connection = new SqlConnection("data source=10.2.1.211; database=fuelCalc_db; User=student; integrated security=FALSE;TrustServerCertificate=True;"))
            {
                connection.Insert(new CarInfo() { carEngine = car.carEngine, carMark = car.carMark.ToLower() , carModel = car.carModel.ToLower(), fuelStat = model.Avarage });
            }
            return base.Calculate();
        }

        public virtual int GetAvarage()
        {
            int? value = -1;
            using (var connection = new SqlConnection("data source=10.2.1.211; database=fuelCalc_db; User=student; integrated security=FALSE;TrustServerCertificate=True;"))
            {
                var all = connection.GetAll<CarInfo>();
                var res = all.FirstOrDefault(item => item.carEngine.Equals(car.carEngine) && item.carMark.Equals(car.carMark) && item.carModel.Equals(car.carModel));

                value = res?.fuelStat;
            }
            return value is null? 0 : value.Value;
        }
    }
}
