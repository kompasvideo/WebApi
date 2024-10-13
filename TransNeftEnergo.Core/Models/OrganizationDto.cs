namespace TransNeftEnergo.Core.Entity
{
    public class OrganizationDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }

        public List<SubsidiaryOrganizationDto>? SubsidiaryOrganizations { get; set; } = new();
    }
}
