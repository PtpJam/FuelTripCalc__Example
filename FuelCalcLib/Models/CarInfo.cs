using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FuelCalcLib.Models
{
    [Table("[CarInfo]")]
    public class CarInfo : CarModel
    {
        [Key]
        public int Id { get; set; }
        [Column("[fuelStat]")]
        public int fuelStat { get; set; }
        public CarInfo()
        {
        }
        public CarInfo(CarModel carModel)
        {
            this.carMark = carModel.carMark;
            this.carModel= carModel.carModel;
            this.carEngine = carModel.carEngine;
        }

    }
}
