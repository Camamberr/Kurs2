using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Printer
    {
        public static void IAmPrinting(Land land)
        {
            Console.WriteLine("Тип объекта: " + land.GetType().Name);
            Console.WriteLine(land.ToString());
        }

        public static void IAmPrinting(IGeoObj geoObj)
        {
            Console.WriteLine("Тип объекта: " + geoObj.GetType().Name);
            Console.WriteLine(geoObj.ToString());
        }
    }
}
