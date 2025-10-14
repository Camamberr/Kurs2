using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class Land: IGeoObj
    {
        public abstract double square {  get; set; }
        public abstract double altitude { get; set; }
        public abstract int UNESCOcount {  get; set; }
        public virtual void Climatic()
        {
            Console.WriteLine("Климат умеренный");
        }
        public override string ToString()
        {
            return $"\tИнформация о суше\n " +
                   $"\tПлощадь: {square} \n" +
                   $"\tВысота над уровнем моря: {altitude} \n" +
                   $"\tКоличество объектов наследия Юнеско: {UNESCOcount} \n";

        }
    }
}
