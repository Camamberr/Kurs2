using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class Water
    {
        public abstract string Sostav { get; set; }
        public virtual void Consistence()
        {
            Console.WriteLine("Вода жидкая.");
        }
        public override string ToString()
        {
            return $"\tИнформация о воде\n " +
                   $"\tСолёность: {Sostav} \n";

        }
    }
}
