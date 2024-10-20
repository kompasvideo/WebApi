﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TransNeftEnergo.Application.Interfaces.Repositories;
using TransNeftEnergo.Core.Exceptions;
using TransNeftEnergo.Core.Requests;
using TransNeftEnergo.Core.Responses;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data.Repositories
{
    public class ObjectOfConsumptionRepository(
        OrganizationDb db,
        IMapper mapper)
        : IObjectOfConsumptionRepository
    {
        // 3. По указанному объекту потребления выбрать все счетчики 
        // с закончившимся сроком поверке.
        public async Task<IEnumerable<ElectricEnergyMeterResp>> GetAllMetersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            var empList = await db.ElectricityMeasurementPoints.Include(i => i.ObjectOfConsumption).Include(i => i.ElectricEnergyMeter)
                        .Where(i => i.ObjectOfConsumption.Name == objectOfConsumptionReq.Name)
                        .ToListAsync();
            if (empList.Count == 0)
                throw new ObjectOfConsumptionException("Не найден объект потребления");
            var result = empList.Select(empd => empd.ElectricEnergyMeter)
                        .Where(meter => meter != null && meter.VerificationDate < DateTime.Now)
                        .ToArray();
            return mapper.Map<ElectricEnergyMeter[], IEnumerable<ElectricEnergyMeterResp>>(result);
        }

        // 4. По указанному объекту потребления выбрать все 
        // трансформаторы напряжения с закончившимся сроком поверке.
        public async Task<IEnumerable<VoltageTransformerResp>> GetAllVoltageTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            var empList = await db.ElectricityMeasurementPoints.Include(i => i.ObjectOfConsumption).Include(i => i.VoltageTransformer)
                        .Where(i => i.ObjectOfConsumption.Name == objectOfConsumptionReq.Name)
                        .ToListAsync();
            if (empList.Count == 0)
                throw new ObjectOfConsumptionException("Не найден объект потребления");
            var result = empList.Select(v => v.VoltageTransformer)
                        .Where(meter => meter != null && meter.VerificationDate < DateTime.Now)
                        .ToArray();
            return mapper.Map<VoltageTransformer[], IEnumerable<VoltageTransformerResp>>(result);
        }

        // 5. По указанному объекту потребления выбрать все 
        // трансформаторы тока с закончившимся сроком поверке.
        public async Task<IEnumerable<CurrentTransformerResp>> GetAllCurrentTransformersToEndVerificationDate(ObjectOfConsumptionReq objectOfConsumptionReq)
        {
            var empList = await db.ElectricityMeasurementPoints.Include(i => i.ObjectOfConsumption).Include(i => i.CurrentTransformer)
                .Where(i => i.ObjectOfConsumption.Name == objectOfConsumptionReq.Name)
                .ToListAsync();
            if (empList.Count == 0)
                throw new ObjectOfConsumptionException("Не найден объект потребления");
            var result = empList.Select(v => v.CurrentTransformer)
                .Where(meter => meter != null && meter.VerificationDate < DateTime.Now)
                .ToArray();
            return mapper.Map<CurrentTransformer[], IEnumerable<CurrentTransformerResp>>(result);
        }
    }
}
