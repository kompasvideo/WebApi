using AutoMapper;
using TransNeftEnergo.Core.Entity;
using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;
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

            CreateMap<ElectricityMeasurementPointReq, ElectricityMeasurementPoint>();
            CreateMap<ElectricEnergyMeter, ElectricEnergyMeterReq>();
            CreateMap<ElectricEnergyMeter, ElectricEnergyMeterReq>().ReverseMap();
            CreateMap<VoltageTransformerReq, VoltageTransformer>();
            CreateMap<CurrentTransformerReq, CurrentTransformer>();
            CreateMap<CalculationDevice, CalculationDeviceDto>();
            CreateMap<CalculationDevice, CalculationDeviceDto>().ReverseMap();
            CreateMap<ElectricEnergyMeter, ElectricEnergyMeterResp>();
            CreateMap<CalculationDevice, CalculationDeviceResp>();
            CreateMap<VoltageTransformer, VoltageTransformerResp>();
            CreateMap<CurrentTransformer, CurrentTransformerResp>();
        }
    }
}
