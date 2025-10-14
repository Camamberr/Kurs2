using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class User_class: Writing_class, IWrite
    {
        public override void Writing()
        {
            Console.WriteLine("Метод класса!");
        }
        void IWrite.Writing()
        {
            Console.WriteLine("Метод интерфейса!");
        }
    }
}
