using Microsoft.Extensions.DependencyInjection;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(IServiceScope scope)
        {
            var services = scope.ServiceProvider.GetRequiredService<OrganizationDb>;
            OrganizationDb context = services.Invoke();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            List<Organization> organizations = AddOrganizations(context);
            List<SubsidiaryOrganization> subsidiaryOrganizations = AddSubsidiaryOrganizations(context, organizations);
            List<ObjectOfConsumption> objectOfConsumptions = AddObjectOfConsumption(context, subsidiaryOrganizations);
            List<ElectricitySupplyPoint> electricitySupplyPoints = AddElectricitySupplyPoint(context, objectOfConsumptions);
            List<CalculationDevice> calculationDevices = AddCalculationDevice(context, electricitySupplyPoints);
            List<ElectricityMeasurementPoint> electricityMeasurementPoints = AddElectricityMeasurementPoint(context, objectOfConsumptions);
            //List<AccountingPeriod> accountingPeriods = AddAccountingPeriod(context, calculationDevices, electricityMeasurementPoints);
            AddCalculationDeviceToElectricityMeasurementPoint(calculationDevices, electricityMeasurementPoints);
            List<ElectricEnergyMeter> electricEnergyMeters = AddElectricEnergyMeter(context, electricityMeasurementPoints);
            List<CurrentTransformer> currentTransformers = AddCurrentTransformer(context, electricityMeasurementPoints);
            List<VoltageTransformer> voltageTransformers = AddVoltageTransformer(context, electricityMeasurementPoints);
            context.SaveChanges();
        }

        private static List<VoltageTransformer> AddVoltageTransformer(OrganizationDb context, List<ElectricityMeasurementPoint> electricityMeasurementPoints)
        {
            List<VoltageTransformer> voltageTransformers = new List<VoltageTransformer>()
                {
                    new VoltageTransformer
                    {
                        Number = "211",
                        Type = Enums.VoltageTransformerType.Type1,
                        VerificationDate = new DateTime(2025,12,01),
                        KTN ="50/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[0]
                    },
                    new VoltageTransformer
                    {
                        Number = "212",
                        Type = Enums.VoltageTransformerType.Type3,
                        VerificationDate = new DateTime(2025,12,01),
                        KTN ="50/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[1]
                    },
                    new VoltageTransformer
                    {
                        Number = "214",
                        Type = Enums.VoltageTransformerType.Type1,
                        VerificationDate = new DateTime(2025,12,01),
                        KTN ="50/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[2]
                    },
                    new VoltageTransformer
                    {
                        Number = "215",
                        Type = Enums.VoltageTransformerType.Type2,
                        VerificationDate = new DateTime(2025,12,01),
                        KTN ="50/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[3]
                    },
                    new VoltageTransformer
                    {
                        Number = "216",
                        Type = Enums.VoltageTransformerType.Type3,
                        VerificationDate = new DateTime(2025,12,01),
                        KTN ="50/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[4]
                    },
                };
            if (!context.VoltageTransformers.Any())
            {
                context.VoltageTransformers.AddRange(voltageTransformers);
            }
            return voltageTransformers;
        }

        private static List<CurrentTransformer> AddCurrentTransformer(OrganizationDb context, List<ElectricityMeasurementPoint> electricityMeasurementPoints)
        {
            List<CurrentTransformer> currentTransformers = new List<CurrentTransformer>()
                {
                    new CurrentTransformer
                    {
                        Number = "111",
                        Type = Enums.CurrentTransformerType.Type1,
                        VerificationDate = new DateTime(2025,12,01),
                        KTT = "100/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[0]
                    },
                    new CurrentTransformer
                    {
                        Number = "112",
                        Type = Enums.CurrentTransformerType.Type1,
                        VerificationDate = new DateTime(2025,12,01),
                        KTT = "100/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[1]
                    },
                    new CurrentTransformer
                    {
                        Number = "114",
                        Type = Enums.CurrentTransformerType.Type3,
                        VerificationDate = new DateTime(2025,12,01),
                        KTT = "100/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[2]
                    },
                    new CurrentTransformer
                    {
                        Number = "115",
                        Type = Enums.CurrentTransformerType.Type2,
                        VerificationDate = new DateTime(2025,12,01),
                        KTT = "100/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[3]
                    },
                    new CurrentTransformer
                    {
                        Number = "116",
                        Type = Enums.CurrentTransformerType.Type3,
                        VerificationDate = new DateTime(2025,12,01),
                        KTT = "100/5",
                        ElectricityMeasurementPoint = electricityMeasurementPoints[4]
                    },
                };
            if (!context.CurrentTransformers.Any())
            {
                context.CurrentTransformers.AddRange(currentTransformers);
            }
            return currentTransformers;
        }

        private static List<ElectricEnergyMeter> AddElectricEnergyMeter(OrganizationDb context, List<ElectricityMeasurementPoint> electricityMeasurementPoints)
        {
            List<ElectricEnergyMeter> electricEnergyMeters = new List<ElectricEnergyMeter>()
                {
                    new ElectricEnergyMeter
                    {
                        Name = "Счётчик электрической энергии 1",
                        Type = Enums.MeterType.Type1,
                        VerificationDate = new DateOnly(2025,12,1),
                        ElectricityMeasurementPoint = electricityMeasurementPoints[0]
                    },
                    new ElectricEnergyMeter
                    {
                        Name = "Счётчик электрической энергии 2",
                        Type = Enums.MeterType.Type2,
                        VerificationDate = new DateOnly(2025,12,1),
                        ElectricityMeasurementPoint = electricityMeasurementPoints[1]
                    },
                    new ElectricEnergyMeter
                    {
                        Name = "Счётчик электрической энергии 3",
                        Type = Enums.MeterType.Type3,
                        VerificationDate = new DateOnly(2025,12,1),
                        ElectricityMeasurementPoint = electricityMeasurementPoints[2]
                    },
                    new ElectricEnergyMeter
                    {
                        Name = "Счётчик электрической энергии 4",
                        Type = Enums.MeterType.Type1,
                        VerificationDate = new DateOnly(2025,12,1),
                        ElectricityMeasurementPoint = electricityMeasurementPoints[3]
                    },
                    new ElectricEnergyMeter
                    {
                        Name = "Счётчик электрической энергии 5",
                        Type = Enums.MeterType.Type2,
                        VerificationDate = new DateOnly(2025,12,1),
                        ElectricityMeasurementPoint = electricityMeasurementPoints[4]
                    },
                };
            if (!context.ElectricEnergyMeters.Any())
            {
                context.ElectricEnergyMeters.AddRange(electricEnergyMeters);
            }
            return electricEnergyMeters;
        }

        private static void AddCalculationDeviceToElectricityMeasurementPoint(List<CalculationDevice> calculationDevices, List<ElectricityMeasurementPoint> electricityMeasurementPoints)
        {
            calculationDevices[0].AccountingPeriods.Add( new AccountingPeriod { 
                    ElectricityMeasurementPoint = electricityMeasurementPoints[0], 
                    StartDate = new DateTime(2024,1,1),
                    EndDate = new DateTime(2024,2,1),
            });
            calculationDevices[0].ElectricityMeasurementPoints.Add(electricityMeasurementPoints[0]);

            calculationDevices[1].AccountingPeriods.Add(new AccountingPeriod
            {
                ElectricityMeasurementPoint = electricityMeasurementPoints[1],
                StartDate = new DateTime(2024, 1, 1),
                EndDate = new DateTime(2024, 2, 1),
            });
            calculationDevices[1].ElectricityMeasurementPoints.Add(electricityMeasurementPoints[1]);

            calculationDevices[2].AccountingPeriods.Add(new AccountingPeriod
            {
                ElectricityMeasurementPoint = electricityMeasurementPoints[2],
                StartDate = new DateTime(2024, 1, 1),
                EndDate = new DateTime(2024, 2, 1),
            });
            calculationDevices[2].ElectricityMeasurementPoints.Add(electricityMeasurementPoints[2]);

            calculationDevices[3].AccountingPeriods.Add(new AccountingPeriod
            {
                ElectricityMeasurementPoint = electricityMeasurementPoints[3],
                StartDate = new DateTime(2024, 1, 1),
                EndDate = new DateTime(2024, 2, 1),
            });
            calculationDevices[3].ElectricityMeasurementPoints.Add(electricityMeasurementPoints[3]);

            calculationDevices[4].AccountingPeriods.Add(new AccountingPeriod
            {
                ElectricityMeasurementPoint = electricityMeasurementPoints[4],
                StartDate = new DateTime(2024, 1, 1),
                EndDate = new DateTime(2024, 2, 1),
            });
            calculationDevices[4].ElectricityMeasurementPoints.Add(electricityMeasurementPoints[4]);
        }
        //private static List<AccountingPeriod> AddAccountingPeriod(OrganizationDb context, List<CalculationDevice> calculationDevices, List<ElectricityMeasurementPoint> electricityMeasurementPoints)
        //{
        //List<AccountingPeriod> accountingPeriods = new List<AccountingPeriod>()
        //    {
        //        new AccountingPeriod
        //        {
        //            StartDate = new DateTime(2024,1,1),
        //            EndDate = new DateTime(2024,2,1),
        //            CalculationDevice = calculationDevices[0],
        //            ElectricityMeasurementPoint = electricityMeasurementPoints[0]
        //        },
        //        new AccountingPeriod
        //        {
        //            StartDate = new DateTime(2024,1,1),
        //            EndDate = new DateTime(2024,2,1),
        //            CalculationDevice = calculationDevices[1],
        //            ElectricityMeasurementPoint = electricityMeasurementPoints[1]
        //        },
        //        new AccountingPeriod
        //        {
        //            StartDate = new DateTime(2024,1,1),
        //            EndDate = new DateTime(2024,2,1),
        //            CalculationDevice = calculationDevices[2],
        //            ElectricityMeasurementPoint = electricityMeasurementPoints[2]
        //        },
        //        new AccountingPeriod
        //        {
        //            StartDate = new DateTime(2024,1,1),
        //            EndDate = new DateTime(2024,2,1),
        //            CalculationDevice = calculationDevices[3],
        //            ElectricityMeasurementPoint = electricityMeasurementPoints[3]
        //        },
        //        new AccountingPeriod
        //        {
        //            StartDate = new DateTime(2024,1,1),
        //            EndDate = new DateTime(2024,2,1),
        //            CalculationDevice = calculationDevices[4],
        //            ElectricityMeasurementPoint = electricityMeasurementPoints[4]
        //        },
        //    };
        //if (!context.AccountingPeriods.Any())
        //{
        //    context.AccountingPeriods.AddRange(accountingPeriods);
        //}
        //return accountingPeriods;
        //}

        private static List<ElectricityMeasurementPoint> AddElectricityMeasurementPoint(OrganizationDb context, List<ObjectOfConsumption> objectOfConsumptions)
        {
            List<ElectricityMeasurementPoint> electricityMeasurementPoints = new List<ElectricityMeasurementPoint>()
                {
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка измерения электроэнергии 1",
                        ObjectOfConsumption = objectOfConsumptions[0]
                    },
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка измерения электроэнергии 2",
                        ObjectOfConsumption = objectOfConsumptions[1]
                    },
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка измерения электроэнергии 3",
                        ObjectOfConsumption = objectOfConsumptions[2]
                    },
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка измерения электроэнергии 4",
                        ObjectOfConsumption = objectOfConsumptions[3]
                    },
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка измерения электроэнергии 5",
                        ObjectOfConsumption = objectOfConsumptions[4]
                    },
                };
            if (!context.ElectricityMeasurementPoints.Any())
            {
                context.ElectricityMeasurementPoints.AddRange(electricityMeasurementPoints);
            }
            return electricityMeasurementPoints;
        }

        private static List<CalculationDevice> AddCalculationDevice(OrganizationDb context, List<ElectricitySupplyPoint> electricitySupplyPoints)
        {
            List<CalculationDevice> calculationDevices = new List<CalculationDevice>()
                {
                    new CalculationDevice
                    {
                        Name = "расчётный прибор учёта 1",
                        ElectricitySupplyPoint = electricitySupplyPoints[0]
                    },
                    new CalculationDevice
                    {
                        Name = "расчётный прибор учёта 2",
                        ElectricitySupplyPoint = electricitySupplyPoints[1]
                    },
                    new CalculationDevice
                    {
                        Name = "расчётный прибор учёта 3",
                        ElectricitySupplyPoint = electricitySupplyPoints[2]
                    },
                    new CalculationDevice
                    {
                        Name = "расчётный прибор учёта 4",
                        ElectricitySupplyPoint = electricitySupplyPoints[3]
                    },
                    new CalculationDevice
                    {
                        Name = "расчётный прибор учёта 5",
                        ElectricitySupplyPoint = electricitySupplyPoints[4]
                    },
                };
            if (!context.CalculationDevices.Any())
            {
                context.CalculationDevices.AddRange(calculationDevices);
            }
            return calculationDevices;
        }

        private static List<ElectricitySupplyPoint> AddElectricitySupplyPoint(OrganizationDb context, List<ObjectOfConsumption> objectOfConsumptions)
        {
            List<ElectricitySupplyPoint> electricitySupplyPoints = new List<ElectricitySupplyPoint>()
                {
                    new ElectricitySupplyPoint
                    {
                        Name = "Точка поставки электроэнергии 1",
                        MaxPower = 45_000_000,
                        ObjectOfConsumption = objectOfConsumptions[0]
                    },
                    new ElectricitySupplyPoint
                    {
                        Name = "Точка поставки электроэнергии 2",
                        MaxPower = 50_000_000,
                        ObjectOfConsumption = objectOfConsumptions[1]
                    },
                    new ElectricitySupplyPoint
                    {
                        Name = "Точка поставки электроэнергии 3",
                        MaxPower = 55_000_000,
                        ObjectOfConsumption = objectOfConsumptions[2]
                    },
                    new ElectricitySupplyPoint
                    {
                        Name = "Точка поставки электроэнергии 4",
                        MaxPower = 60_000_000,
                        ObjectOfConsumption = objectOfConsumptions[3]
                    },
                    new ElectricitySupplyPoint
                    {
                        Name = "Точка поставки электроэнергии 5",
                        MaxPower = 100_000_000,
                        ObjectOfConsumption = objectOfConsumptions[4]
                    },
                };
            if (!context.ElectricitySupplyPoints.Any())
            {
                context.ElectricitySupplyPoints.AddRange(electricitySupplyPoints);
            }
            return electricitySupplyPoints;
        }

        private static List<ObjectOfConsumption> AddObjectOfConsumption(OrganizationDb context, List<SubsidiaryOrganization> subsidiaryOrganizations)
        {
            List<ObjectOfConsumption> objectOfConsumptions = new List<ObjectOfConsumption>()
                {
                    new ObjectOfConsumption
                    {
                        Name = "ПС 110/10 Весна",
                        Address = "Адрес_1",
                        SubsidiaryOrganization = subsidiaryOrganizations[0]
                    },
                    new ObjectOfConsumption
                    {
                        Name = "ПС 110/10 Лето",
                        Address = "Адрес_2",
                        SubsidiaryOrganization = subsidiaryOrganizations[1]
                    },
                    new ObjectOfConsumption
                    {
                        Name = "ПС 110/10 Осень",
                        Address = "Адрес_3",
                        SubsidiaryOrganization = subsidiaryOrganizations[3]
                    },
                    new ObjectOfConsumption
                    {
                        Name = "ПС 110/10 Зима",
                        Address = "Адрес_4",
                        SubsidiaryOrganization = subsidiaryOrganizations[1]
                    },                    
                    new ObjectOfConsumption
                    {
                        Name = "ПС 220/10 Весна",
                        Address = "Адрес_4",
                        SubsidiaryOrganization = subsidiaryOrganizations[0]
                    },
                };
            if (!context.ObjectOfConsumptions.Any())
            {
                context.ObjectOfConsumptions.AddRange(objectOfConsumptions);
            }
            return objectOfConsumptions;
        }

        private static List<SubsidiaryOrganization> AddSubsidiaryOrganizations(OrganizationDb context, List<Organization> organizations)
        {
            List<SubsidiaryOrganization> subsidiaryOrganizations = new List<SubsidiaryOrganization>()
                {
                    new SubsidiaryOrganization
                    {
                        Name = "Дочерняя организация 1",
                        Address = "Адрес_1",
                        Organization = organizations[0]
                    },
                    new SubsidiaryOrganization
                    {
                        Name = "Дочерняя организация 2",
                        Address = "Адрес_2",
                        Organization = organizations[1]
                    },
                    new SubsidiaryOrganization
                    {
                        Name = "Дочерняя организация 3",
                        Address = "Адрес_3",
                        Organization = organizations[2]
                    },
                    new SubsidiaryOrganization
                    {
                        Name = "Дочерняя организация 4",
                        Address = "Адрес_4",
                        Organization = organizations[0]
                    },
                };
            if (!context.SubsidiaryOrganizations.Any())
            {
                context.SubsidiaryOrganizations.AddRange(subsidiaryOrganizations);
            }
            return subsidiaryOrganizations;
        }

        private static List<Organization> AddOrganizations(OrganizationDb context)
        {
            List<Organization> organizations = new List<Organization>()
                {
                    new Organization
                        {
                            Name = "Организация 1",
                            Address = "Адрес_1",
                        },
                        new Organization
                        {
                            Name = "Организация 2",
                            Address = "Адрес_2",
                        },
                        new Organization
                        {
                            Name = "Организация 3",
                            Address = "Адрес_3",
                        }
                };
            if (!context.Organizations.Any())
            {
                context.Organizations.AddRange(organizations);
            }
            return organizations;
        }
    }
}
