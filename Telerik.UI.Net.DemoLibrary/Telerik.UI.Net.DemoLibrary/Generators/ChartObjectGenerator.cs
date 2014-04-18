using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.UI.Net.DemoLibrary.Classes;

namespace Telerik.UI.Net.DemoLibrary.Generators
{
    public static class ChartObjectGenerator
    {
        private static Random rnd = new Random();

        public static List<ChartObject> GetChartObjects(int count)
        {
            List<ChartObject> items = new List<ChartObject>();

            for (int i = 0; i < count; i++)
            {
                ChartObject co = CreateChartObject(i, rnd.NextDouble() * 100.0d);

                items.Add(co);
            }

            return items;
        }

        public static List<ChartObject> GetChartObjectsSinCurve(int count)
        {
            List<ChartObject> items = new List<ChartObject>();

            double seed = rnd.NextDouble() * 10.0d;

            for (int i = 0; i < count; i++)
            {
                ChartObject co = CreateChartObject(i, Math.Sin(seed + i));

                items.Add(co);
            }

            return items;
        }

        public static ChartObject CreateChartObject(int i, double doubleValue)
        {
            ChartObject co = new ChartObject();
            co.Id = i;
            co.DoubleValue = doubleValue;
            co.CategoryInt = i;
            co.CategoryString = "Category " + i.ToString();
            co.CategoryDateTime = DateTime.Today.AddDays(i);

            return co;
        }
    }
}
