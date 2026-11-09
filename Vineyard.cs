using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Vineyard : LandParcel, IOrganicLand
    {
        public string GrapeVariety { get; set; }
        public int VinesPerHa { get; set; }
        public double AvgFruitPerVine { get; set; }
        public double MaintenanceCostPerVine { get; set; }
        private bool CertifiedOrganic { get; set; }

        public Vineyard(double area, string location, string grapeVariety, int vinesPerHa, double avgFruitPerVine, double maintenanceCostPerVine, bool organic)
                        : base(area, location)
        {
            GrapeVariety = grapeVariety;
            VinesPerHa = vinesPerHa;
            AvgFruitPerVine = avgFruitPerVine;
            MaintenanceCostPerVine = maintenanceCostPerVine;
            CertifiedOrganic = organic;
        }

        public override double CalculateAnnualYield()
        {
            return Area * VinesPerHa * AvgFruitPerVine / 1000.0;
        }

        public override double CalculateMaintenanceCost()
        {
            return Area * VinesPerHa * MaintenanceCostPerVine;
        }

        public bool IsCertifiedOrganic()
        {
            return CertifiedOrganic;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(
                $"Tree: Grapevine, Variety: {GrapeVariety}, " +
                $"Organic: {IsCertifiedOrganic()}");
        }
    }
}
