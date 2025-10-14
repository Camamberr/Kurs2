using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Sea : Water
    {
        string sostav;
        public double Square;
        public double square
        {
            get => Square;
            set => Square = value;
        }
        public override string Sostav
        {
            get => sostav;
            set => sostav = value;
        }
       public bool isPriliv=false;
        public override void Consistence()
        {
            Console.WriteLine("В море вода жидкая.");
        }


        public override string ToString()
        {
            return $"\tИнформация о море\n " +
                   $"\tСолёность: {Sostav} \n" +
                   $"\t {isPrilivFunc()} \n" +
                   $"\tПлощадь: {square} \n";

        }
        private string isPrilivFunc()
        {
            if (isPriliv == true)
            {
                return "Сейчас прилив.";
            }
            else
            {
                return "Сейчас отлив.";
            }
        }
        public Sea(string sostav, double square, bool isPriliv)
        {
            this.sostav = sostav;
            this.Square = square;
            this.isPriliv = isPriliv;
        }

    }
}
