using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Island:Land
    {
        public string Island_name;
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
        public override int GetHashCode()
        {
            int hash = UNESCOcount;
            hash = hash * 56;
            hash = hash +5;
            return hash;
        }
        public override string ToString()
        {
            return $"\tИнформация об острове\n " +
                $"\tНвазание острова: {Island_name} \n" +
                   $"\tПлощадь: {Square} \n" +
                   $"\tВысота над уровнем моря: {altitude} \n" +
                   $"\t {isVulkanFunc()} \n" +
                   $"\tКоличество объектов наследия Юнеско: {UNESCOcount} \n";

        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        bool isVulkan=false;
        private string isVulkanFunc()
        {
            if (isVulkan == true)
            {
                return "На острове есть вулкан.";
            }
            else
            {
                return "На острове нет вулкана.";
            }
        }
        public Island(string islandName, double square, double altitude, int unescoCount, bool hasVulkan)
        {
            this.Island_name = islandName;
            this.Square = square;
            this.Altitude = altitude;
            this.UNESCO_count = unescoCount;
            this.isVulkan = hasVulkan;
        }
    }
}
