using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransNeftEnergo.Data.Entity
{
    // точка измерения электроэнергии
    public class ElectricityMeasurementPoint
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ElectricityMeasurementPointId { get; set; }
        public string Name { get; set; }
        public int ObjectOfConsumptionKey { get; set; }
        [ForeignKey("ObjectOfConsumptionKey")]
        public ObjectOfConsumption ObjectOfConsumption { get; set; }
        public int AccountingPeriodKey { get; set; }
        [ForeignKey("AccountingPeriodKey")]
        public AccountingPeriod AccountingPeriod { get; set; }
    }
}
