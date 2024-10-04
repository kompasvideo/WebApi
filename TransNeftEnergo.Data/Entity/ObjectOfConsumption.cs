using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransNeftEnergo.Data.Entity
{
    // объект потребления
    public class ObjectOfConsumption
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ObjectOfConsumptionId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int SubsidiaryOrganizationKey { get; set; }

        [ForeignKey("SubsidiaryOrganizationKey")]
        public SubsidiaryOrganization SubsidiaryOrganization { get; set; }
    }
}
