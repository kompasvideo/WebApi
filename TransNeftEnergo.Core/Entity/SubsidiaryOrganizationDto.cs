namespace TransNeftEnergo.Core.Entity
{
    public class SubsidiaryOrganizationDto
    {
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int OrganizationKey { get; set; }
        public OrganizationDto Organization { get; set; }
    }
}
