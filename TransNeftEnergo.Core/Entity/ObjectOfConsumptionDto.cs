namespace TransNeftEnergo.Core.Entity
{
    // объект потребления
    public class ObjectOfConsumptionDto
    {
        public int ObjectOfConsumptionId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int SubsidiaryOrganizationKey { get; set; }
        public SubsidiaryOrganizationDto SubsidiaryOrganization { get; set; }
    }
}
