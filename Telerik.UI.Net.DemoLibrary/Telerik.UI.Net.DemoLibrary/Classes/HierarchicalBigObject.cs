using System;
using System.Collections.Generic;
using System.Linq;

namespace Telerik.UI.Net.DemoLibrary.Classes
{
    public class HierarchicalBigObject : BigObject
    {
        public List<HierarchicalBigObject> HierarchicalBigObjects { get; set; }

        public HierarchicalBigObject()
        {
        }
    }
}
