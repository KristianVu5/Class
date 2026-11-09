using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Class
{
    internal class Program
    {
        public static void Main()
        {
            CropField field = new CropField(25, "Dobrich", "Wheat", 100, 6.5, true);

            Orchard orchard = new Orchard(15, "Sliven", "Apple", 400, 30, 1.2);

            Vineyard vineyard = new Vineyard(10, "Melnik", "Cabernet", 3500, 2.2, 0.8, true);

            Pasture pasture = new Pasture(40, "Kardzhali", 5.5, 80, 60);

            Company company = new Company("AgroFuture Ltd.", 300, field, orchard, vineyard, pasture);

            company.DisplayReport();
        }
    }
}