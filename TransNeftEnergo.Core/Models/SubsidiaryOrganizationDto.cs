namespace TransNeftEnergo.Core.Entity
{
    public class SubsidiaryOrganizationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationDto? Organization { get; set; }

        public List<ObjectOfConsumptionDto> ObjectOfConsumptions { get; set; } = new();
    }
}
