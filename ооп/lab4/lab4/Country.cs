using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public sealed class Country : Continent
    {
        public string country_name;
        public string capital_name;

        double Square;
        public override double square
        {
            get => Square;
            set => Square = value;
        }

        int UNESCO_count;
        public override int UNESCOcount
        {
            get => UNESCO_count;
            set => UNESCO_count = value;
        }
        public Country(string continentName, double continentSquare, double altitude, int continentUNESCOcount, int countryValue, string countryName, string capitalName, double countrySquare, int countryUNESCOcount)
    : base(continentName, continentSquare, altitude, continentUNESCOcount, countryValue)
        {
            this.country_name = countryName;
            this.capital_name = capitalName;
            this.Square = countrySquare;   
            this.UNESCO_count = countryUNESCOcount;
        }


        public override string ToString()
        {
            return $"\tИнформация о стране\n" +
                   $"\tНазвание: {country_name} \n" +
                   $"\tСтолица: {capital_name} \n" +
                   $"\tПлощадь: {Square} \n" +
                   $"\tКоличество объектов наследия Юнеско: {UNESCOcount} \n";
        }
    }

}
