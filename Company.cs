using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Company
    {
        private string Name;
        private double Budget;

        private CropField Field;
        private Orchard Orchard;
        private Vineyard Vineyard;
        private Pasture Pasture;

        public Company(string name, double budget, CropField field, Orchard orchard, Vineyard vineyard, Pasture pasture)
        {
            Name = name;
            Budget = budget;
            Field = field;
            Orchard = orchard;
            Vineyard = vineyard;
            Pasture = pasture;
        }

        public void DisplayReport()
        {
            Console.WriteLine("-REPORT-");
            Console.WriteLine();

            double totalYield = 0;
            double totalCost = 0;

            DisplayParcel(Field, "CropField");
            DisplayParcel(Orchard, "Orchard");
            DisplayParcel(Vineyard, "Vineyard");
            DisplayParcel(Pasture, "Pasture");

            totalYield =
                Field.CalculateAnnualYield()
                + Orchard.CalculateAnnualYield()
                + Vineyard.CalculateAnnualYield()
                + Pasture.CalculateAnnualYield();

            totalCost =
                Field.CalculateMaintenanceCost()
                + Orchard.CalculateMaintenanceCost()
                + Vineyard.CalculateMaintenanceCost()
                + Pasture.CalculateMaintenanceCost();

            Console.WriteLine($"Total yield: {totalYield:F2} tons");
            Console.WriteLine($"Total cost: {totalCost:F2} Eur");
            Console.WriteLine($"Total parcels: {LandParcel.GetTotalParcels()}");
        }

        private void DisplayParcel(LandParcel parcel, string type)
        {
            Console.WriteLine(
                $"{type} | Area: {parcel.Area:F0} ha | Location: {parcel.Location}");

            parcel.DisplayInfo();

            Console.WriteLine(
                $"Yield: {parcel.CalculateAnnualYield():F2} tons");

            Console.WriteLine(
                $"Cost: {parcel.CalculateMaintenanceCost():F2} Eur");

            Console.WriteLine();
        }
    }
}
