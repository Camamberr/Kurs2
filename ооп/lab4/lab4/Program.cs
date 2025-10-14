using lab4;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Land Eurasia = new Continent("Евразия", 30000000, 500, 100, 35);
            Land Belarus = new Country("Евразия", 30000000, 500, 100, 35, "Беларусь", "Минск", 207600, 4);
            Land Madagascar = new Island("Мадагаскар", 587041, 800, 3, true);
            Sea Baltic = new Sea("Слабосолёная", 377000, true);
            Printer printer=new Printer();

            Land[] objs = { Eurasia, Belarus, Madagascar };
            foreach (var obj in objs)
            {
                Printer.IAmPrinting(obj);
                if (obj is Island)
                {
                    Console.WriteLine("Это остров");
                }
                else if (obj is Country)
                {
                    Console.WriteLine("Это страна");
                }
                else if (obj is Continent)
                {
                    Console.WriteLine("Это континент");
                }
            }
            Country x = Madagascar as Country;
            if (x != null)
            {
                Console.WriteLine("Это страна");
            }
            User_class user = new User_class();

            user.Writing();

            IWrite writer = user;
            writer.Writing();
        }
    }
}

