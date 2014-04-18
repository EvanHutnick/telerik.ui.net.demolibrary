using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.UI.Net.DemoLibrary.Classes;

namespace Telerik.UI.Net.DemoLibrary.Generators
{
    public static class FinancialObjectGenerator
    {
        public static Random rnd = new Random();

        public static List<FinancialObject> GetFinancialObjects(int count)
        {
            List<FinancialObject> items = new List<FinancialObject>();
            double lastClose = 10.0d;

            for (int w = 0; w < count; w++)
            {
                FinancialObject fo = CreateFinancialObject(w, lastClose);

                lastClose = fo.Close;

                items.Add(fo);
            }

            return items;
        }

        public static FinancialObject CreateFinancialObject(int intBase = 1, double lastClose = 10.0d)
        {
            FinancialObject fo = new FinancialObject();
            fo.Id = intBase;
            fo.DateValue = DateTime.Today.AddMinutes(intBase * 30);
            fo.Open = lastClose;

            int direction = (rnd.Next() % 2 == 0 ? 1 : -1);

            fo.Close = fo.Open + (rnd.Next(2, 10) * direction);

            if (direction > 0)
            {
                fo.High = fo.Close + rnd.Next(1, 4);
                fo.Low = fo.Open - rnd.Next(1, 4);
            }
            else
            {
                fo.High = fo.Open + rnd.Next(1, 4);
                fo.Low = fo.Close - rnd.Next(1, 4);
            }

            return fo;
        }
    }
}
