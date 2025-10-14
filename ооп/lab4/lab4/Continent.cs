using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Continent:Land
    {
        public string continent_name;
        double Square;
        public override double square
        {
            get => Square;
            set => Square = value;
        }
        double Altitude;
        public override double altitude
        {
            get => Altitude;
            set => Altitude = value;
        }
        int UNESCO_count;
        public override int UNESCOcount
        {
            get => UNESCO_count;
            set => UNESCO_count = value;
        }

        public int CountryValue;

        public override string ToString()
        {
            return $"\tИнформация о континенте\n " +
                    $"\tНвазание континента: {continent_name} \n" +
                   $"\tПлощадь: {Square} \n" +
                   $"\tВысота над уровнем моря: {altitude} \n"+
                   $"\tКоличество стран на континенте: {CountryValue} \n" +
                   $"\tКоличество объектов наследия Юнеско: {UNESCOcount} \n";

        }
        public override void Climatic()
        {
            Console.WriteLine("Климат засушливый");
        }
        public Continent(string continentName, double square, double altitude, int unescoCount, int countryValue)
        {
            this.continent_name = continentName;
            this.Square = square;
            this.Altitude = altitude;
            this.UNESCO_count = unescoCount;
            this.CountryValue = countryValue;
        }


    }
}
