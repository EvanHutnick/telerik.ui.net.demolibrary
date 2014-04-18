using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Net.DemoLibrary.Classes;

namespace Telerik.UI.Net.DemoLibrary.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // just a small project so we can see what gets returned from various values

            List<SmallObject> smallObjects = Generators.SmallObjectGenerator.GetSmallObjects(50);

            string stop = "here";
        }
    }
}
