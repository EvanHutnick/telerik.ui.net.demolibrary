using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.UI.Net.DemoLibrary.Classes;
using Telerik.UI.Net.DemoLibrary.Static;

namespace Telerik.UI.Net.DemoLibrary.Generators
{
    public static class LargeObjectGenerator
    {
        private static Random rnd = new Random();

        public static List<BigObject> GetBigObjects(int count) {
            List<BigObject> items = new List<BigObject>();

            for (int i = 0; i < count; i++)
            {
                BigObject bo = CreateBigObject(i);
                items.Add(bo);
            }

            return items;
        }

        public static BigObject CreateBigObject(int i = 1)
        {
            BigObject bo = new BigObject();
            bo.Id = i;
            bo.Name = "Object " + i.ToString();
            bo.Description = TextGenerator.GetRandomText();
            bo.IsActive = (i % 2 == 0 ? true : false);
            bo.DateValue = DateTime.Today.AddDays(-i);
            bo.IntItem = rnd.Next(0, 200);
            bo.DoubleItem = rnd.NextDouble();
            bo.FloatItem = (float)(rnd.NextDouble() * rnd.Next(3, 27));
            bo.Uri = "http://www.telerik.com";
            bo.Email = TextGenerator.GetEmail();            

            return bo;
        }

        public static List<HierarchicalBigObject> GetBigHierarchy(int rootCount)
        {
            List<HierarchicalBigObject> tree = new List<HierarchicalBigObject>();
                       
            for (int i = 0; i < rootCount; i++)
            {
                HierarchicalBigObject hbo = CreateHierarchicalBigObject(i);

                for (int j = 0; j < 4; j++)
                {
                    HierarchicalBigObject hboChild = CreateHierarchicalBigObject(j);
                    hbo.HierarchicalBigObjects.Add(hboChild);
                }

                tree.Add(hbo);
            }

            return tree;
        }

        public static HierarchicalBigObject CreateHierarchicalBigObject(int i = 1)
        {
            HierarchicalBigObject hbo = new HierarchicalBigObject();
            hbo.Id = i;
            hbo.Name = "Object " + i.ToString();
            hbo.Description = TextGenerator.GetRandomText();
            hbo.IsActive = (i % 2 == 0 ? true : false);
            hbo.DateValue = DateTime.Today.AddDays(-i);
            hbo.IntItem = rnd.Next(0, 200);
            hbo.DoubleItem = rnd.NextDouble();
            hbo.FloatItem = (float)(rnd.NextDouble() * rnd.Next(3, 27));
            hbo.Uri = "http://www.telerik.com";
            hbo.Email = TextGenerator.GetEmail();

            return hbo;
        }
    }
}
