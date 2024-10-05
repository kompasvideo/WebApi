﻿namespace TransNeftEnergo.Data.Entity
{
    // организация
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<SubsidiaryOrganization> SubsidiaryOrganizations { get; set; } = new();
    }
}
