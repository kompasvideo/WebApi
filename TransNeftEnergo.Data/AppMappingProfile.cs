using AutoMapper;
using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<ElectricityMeasurementPointReq, ElectricityMeasurementPoint>();
            CreateMap<ElectricEnergyMeterReq, ElectricEnergyMeter>();
            CreateMap<VoltageTransformerReq, VoltageTransformer>();
            CreateMap<CurrentTransformerReq, CurrentTransformer>();
            CreateMap<ElectricEnergyMeter, ElectricEnergyMeterResp>();
            CreateMap<CalculationDevice, CalculationDeviceResp>();
            CreateMap<VoltageTransformer, VoltageTransformerResp>();
            CreateMap<CurrentTransformer, CurrentTransformerResp>();
        }
    }
}
