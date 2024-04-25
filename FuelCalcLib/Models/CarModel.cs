using System.ComponentModel.DataAnnotations.Schema;

namespace FuelCalcLib.Models
{
    public class CarModel
    {
        public string carMark { get; set; }
        public string carModel { get; set; }
        public int carEngine { get; set; }
    }
}
