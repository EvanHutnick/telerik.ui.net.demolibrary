using System;
using System.Collections.Generic;
using System.Linq;

namespace Telerik.UI.Net.DemoLibrary.Classes
{
    public class HierarchicalSmallObject : SmallObject
    {
        public List<HierarchicalSmallObject> HierarchicalSmallObjects { get; set; }

        public HierarchicalSmallObject()
        {
        }
    }
}
