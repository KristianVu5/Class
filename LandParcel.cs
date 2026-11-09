using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    internal abstract class LandParcel
    {
        public int Id { get;}  
        public double Area { get;}
        public string Location { get;}

        public static int TotalParcels { get; private set; }

        protected LandParcel(double area, string location)
        {
            Area = area;
            Location = location;
            Id = ++TotalParcels;
        }

        public static int GetTotalParcels()
        {
            return TotalParcels;
        }

        public abstract double CalculateAnnualYield();
        public abstract double CalculateMaintenanceCost();

        public virtual void DisplayInfo()
        {
            Console.WriteLine(
                $"ID: {Id}, Area: {Area} ha, Location: {Location}");
            Console.WriteLine("--------------------------------------------");
        }

    }
}
