using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Class
{
    internal class CropField : LandParcel, IOrganicLand
    {
        public string CropType { get; private set; }
        public double FertilizerCostPerHa { get; private set; }
        public double YieldPerHa { get; private set; }
        public bool CertifiedOrganic { get; private set; }


        public CropField(double area, string location, string cropType, double fertilizerCostPerHa,
            double yieldPerHa, bool organic) : base(area, location)
        {
            CropType = cropType;
            FertilizerCostPerHa = fertilizerCostPerHa;
            YieldPerHa = yieldPerHa;
            CertifiedOrganic = organic;
        }

        public override double CalculateAnnualYield()
        {
            return Area * YieldPerHa;
        }

        public override double CalculateMaintenanceCost()
        {
            return Area * FertilizerCostPerHa;
        }

        public bool IsCertifiedOrganic()
        {
            return CertifiedOrganic;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(
                $"Crop: {CropType}, Yield/ha: {YieldPerHa:F2}, " +
                $"Organic: {IsCertifiedOrganic()}");
        }

       

    }
}
