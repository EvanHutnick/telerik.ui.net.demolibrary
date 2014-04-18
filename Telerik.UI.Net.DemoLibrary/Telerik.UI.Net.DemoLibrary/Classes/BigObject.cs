using System;
using System.Linq;

namespace Telerik.UI.Net.DemoLibrary.Classes
{
    public class BigObject : SmallObject
    {
        public int IntItem { get; set; }
        public double DoubleItem { get; set; }
        public string Uri { get; set; }
        public string Email { get; set; }
        public float FloatItem { get; set; }

        public BigObject()
        {
        }
    }
}
