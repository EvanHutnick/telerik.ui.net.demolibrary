using System;
using System.Linq;

namespace Telerik.UI.Net.DemoLibrary.Classes
{
    public class ChartObject
    {
        public int Id { get; set; }
        public int CategoryInt { get; set; }
        public double DoubleValue { get; set; }
        public string CategoryString { get; set; }
        public DateTime CategoryDateTime { get; set; }

        public ChartObject()
        {
        }
    }
}
