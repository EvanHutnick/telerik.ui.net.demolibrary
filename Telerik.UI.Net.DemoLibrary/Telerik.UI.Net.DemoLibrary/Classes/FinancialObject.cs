using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik.UI.Net.DemoLibrary.Classes
{
    public class FinancialObject
    {
        public int Id { get; set; }
        public DateTime DateValue { get; set; }

        public double Open { get; set; }
        public double Close { get; set; }
        public double High { get; set; }
        public double Low { get; set; }

        public FinancialObject()
        {

        }        
    }
}
