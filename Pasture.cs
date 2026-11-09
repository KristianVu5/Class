using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Pasture : LandParcel
    {
        public double GrassYieldPerHa { get; set; }
        public int LivestockCount { get; set; }
        public double MaintenanceCostPerAnimal { get; set; }
        private const double LandMaintenanceCostPerHa = 50.0;

        public Pasture(double area, string location, double grassYieldPerHa, int livestockCount, double maintenanceCostPerAnimal)
            : base(area, location)
        {
            GrassYieldPerHa = grassYieldPerHa;
            LivestockCount = livestockCount;
            MaintenanceCostPerAnimal = maintenanceCostPerAnimal;
        }

        public override double CalculateAnnualYield()
        {
            return Area * GrassYieldPerHa;
        }

        public override double CalculateMaintenanceCost()
        {
            return Area * LandMaintenanceCostPerHa
                 + LivestockCount * MaintenanceCostPerAnimal;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(
                $"Grass yield: {GrassYieldPerHa:F2} ton/ha, " +
                $"Livestock: {LivestockCount}");
        }

    }
}
