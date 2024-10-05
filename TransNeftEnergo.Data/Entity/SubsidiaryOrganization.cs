namespace TransNeftEnergo.Data.Entity
{
    // Дочерняя организация
    public class SubsidiaryOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int OrganizationId { get; set; }
        public Organization? Organization { get; set; }

        public List<ObjectOfConsumption> ObjectOfConsumptions { get; set; } = new();
    }
}
