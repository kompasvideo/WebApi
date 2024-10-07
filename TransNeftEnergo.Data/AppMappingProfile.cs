using AutoMapper;
using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<Organization, OrganizationDto>();
            CreateMap<Organization, OrganizationDto>().ReverseMap();
            CreateMap<SubsidiaryOrganization, SubsidiaryOrganizationDto>();
            CreateMap<SubsidiaryOrganization, SubsidiaryOrganizationDto>().ReverseMap();
            CreateMap<ElectricityMeasurementPoint, ElectricityMeasurementPointDto>();
            CreateMap<ElectricityMeasurementPoint, ElectricityMeasurementPointDto>().ReverseMap();
        }
    }
}
