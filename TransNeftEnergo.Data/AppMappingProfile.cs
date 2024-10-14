using AutoMapper;
using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<SubsidiaryOrganization, SubsidiaryOrganizationDto>();
            CreateMap<SubsidiaryOrganization, SubsidiaryOrganizationDto>().ReverseMap();
            CreateMap<ElectricityMeasurementPoint, ElectricityMeasurementPointDto>();
            CreateMap<ElectricityMeasurementPoint, ElectricityMeasurementPointDto>().ReverseMap();
            //CreateMap<IEnumerable<CalculationDevice>, IEnumerable<CalculationDeviceDto>>();
            //CreateMap<IEnumerable<CalculationDevice>, IEnumerable<CalculationDeviceDto>>().ReverseMap();
            CreateMap<IEnumerable<ElectricEnergyMeter>, IEnumerable<ElectricEnergyMeterDto>>();
            CreateMap<IEnumerable<ElectricEnergyMeter>, IEnumerable<ElectricEnergyMeterDto>>().ReverseMap();
            CreateMap<IEnumerable<VoltageTransformer>, IEnumerable<VoltageTransformerDto>>();
            CreateMap<IEnumerable<VoltageTransformer>, IEnumerable<VoltageTransformerDto>>().ReverseMap();
            CreateMap<IEnumerable<CurrentTransformer>, IEnumerable<CurrentTransformerDto>>();
            CreateMap<IEnumerable<CurrentTransformer>, IEnumerable<CurrentTransformerDto>>().ReverseMap();

            CreateMap<ElectricityMeasurementPoint, ElectricityMeasurementPointReq>();
            CreateMap<ElectricityMeasurementPoint, ElectricityMeasurementPointReq>().ReverseMap();
            CreateMap<ElectricEnergyMeter, ElectricEnergyMeterReq>();
            CreateMap<ElectricEnergyMeter, ElectricEnergyMeterReq>().ReverseMap();
            CreateMap<VoltageTransformer, VoltageTransformerReq>();
            CreateMap<VoltageTransformer, VoltageTransformerReq>().ReverseMap();
            CreateMap<CurrentTransformer, CurrentTransformerReq>();
            CreateMap<CurrentTransformer, CurrentTransformerReq>().ReverseMap();
            CreateMap<CalculationDevice, CalculationDeviceDto>();
            CreateMap<CalculationDevice, CalculationDeviceDto>().ReverseMap();
        }
    }
}
