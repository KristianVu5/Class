using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal class Orchard : LandParcel
    {
        public string TreeType { get; private set; }
        public int TreesPerHa { get; set; }
        public double AvgFruitPerTree { get; set; }
        public double MaintenanceCostPerTree { get; set; }

        public Orchard(
      double area, string location, string treeType, int treesPerHa, double avgFruitPerTree, double maintenanceCostPerTree)
      : base(area, location)
        {
            TreeType = treeType;
            TreesPerHa = treesPerHa;
            AvgFruitPerTree = avgFruitPerTree;
            MaintenanceCostPerTree = maintenanceCostPerTree;
        }

        public override double CalculateAnnualYield()
        {
            return Area * TreesPerHa * AvgFruitPerTree / 1000.0;
        }

        public override double CalculateMaintenanceCost()
        {
            return Area * TreesPerHa * MaintenanceCostPerTree;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(
                $"Tree: {TreeType}, {TreesPerHa} trees/ha, " +
                $"Avg yield: {AvgFruitPerTree:F2} kg");
        }

    }
}
