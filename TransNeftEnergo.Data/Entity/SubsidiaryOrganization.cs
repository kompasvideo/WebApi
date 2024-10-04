using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransNeftEnergo.Data.Entity
{
    // Дочерняя организация
    public class SubsidiaryOrganization
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubsidiaryOrganizationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int OrganizationKey { get; set; }

        [ForeignKey("OrganizationKey")]
        public Organization Organization { get; set; }
    }
}
