using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.UI.Net.DemoLibrary.Classes;
using Telerik.UI.Net.DemoLibrary.Static;

namespace Telerik.UI.Net.DemoLibrary.Generators
{
    public static class SmallObjectGenerator
    {
        public static List<SmallObject> GetSmallObjects(int count) {
            List<SmallObject> items = new List<SmallObject>();

            for (int i = 0; i < count; i++)
            {
                items.Add(CreateSmallObject(i));
            }

            return items;
        }

        public static SmallObject CreateSmallObject(int i = 1)
        {
            SmallObject so = new SmallObject();
            so.Id = i;
            so.Name = "Object " + i.ToString();
            so.Description = TextGenerator.GetRandomText();
            so.IsActive = (i % 2 == 0 ? true : false);
            so.DateValue = DateTime.Today.AddDays(-i);

            return so;
        }

        public static List<HierarchicalSmallObject> GetSmallHierarchy(int rootCount)
        {
            List<HierarchicalSmallObject> tree = new List<HierarchicalSmallObject>();
                       
            for (int i = 0; i < rootCount; i++)
            {
                HierarchicalSmallObject hso = CreateHierarchicalSmallObject(i);

                for (int j = 0; j < 4; j++)
                {
                    HierarchicalSmallObject hsoChild = CreateHierarchicalSmallObject(j);
                    hso.HierarchicalSmallObjects.Add(hsoChild);
                }

                tree.Add(hso);
            }

            return tree;
        }

        public static HierarchicalSmallObject CreateHierarchicalSmallObject(int i = 1)
        {
            HierarchicalSmallObject hso = new HierarchicalSmallObject();
            hso.Id = i;
            hso.Name = "Object " + i.ToString();
            hso.Description = TextGenerator.GetRandomText();
            hso.IsActive = (i % 2 == 0 ? true : false);
            hso.DateValue = DateTime.Today.AddDays(-i);

            return hso;
        }
    }
}
