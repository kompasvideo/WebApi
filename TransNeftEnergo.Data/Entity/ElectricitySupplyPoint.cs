using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransNeftEnergo.Data.Entity
{
    // точка поставки электроэнергии
    public class ElectricitySupplyPoint
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ElectricitySupplyPointId { get; set; }
        public string Name { get; set; }
        public double MaxPower { get; set; }
        public int ObjectOfConsumptionKey { get; set; }
        [ForeignKey("ObjectOfConsumptionKey")]
        public  ObjectOfConsumption ObjectOfConsumption { get; set; }
    }
}
