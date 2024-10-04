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
            
            List<AccountingPeriod> accountingPeriods = AddAccountingPeriod();

            context.SaveChanges();
        }

        private static List<ElectricityMeasurementPoint> AddElectricityMeasurementPoint(OrganizationDb context, List<ObjectOfConsumption> objectOfConsumptions)
        {
            List<ElectricityMeasurementPoint> electricityMeasurementPoints = new List<ElectricityMeasurementPoint>()
                {
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка поставки электроэнергии 1",
                        ObjectOfConsumption = objectOfConsumptions[0]
                    },
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка поставки электроэнергии 2",
                        ObjectOfConsumption = objectOfConsumptions[1]
                    },
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка поставки электроэнергии 3",
                        ObjectOfConsumption = objectOfConsumptions[2]
                    },
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка поставки электроэнергии 4",
                        ObjectOfConsumption = objectOfConsumptions[3]
                    },
                    new ElectricityMeasurementPoint
                    {
                        Name = "Точка поставки электроэнергии 5",
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
                        SubsidiaryOrganization = subsidiaryOrganizations[4]
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
                            Name = "Организация 1"
                        },
                        new Organization
                        {
                            Name = "Организация 2"
                        },
                        new Organization
                        {
                            Name = "Организация 3"
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
