using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab2.Program;

namespace lab2
{
    internal class Program
    {
       public partial class Airline
        {
            int max_time { get; set; }
             const int number_of_airport = 1;
            string destination;
            int flight_number;
            string aircraft_type { get; set; }
            string departure_time { get; set; }
            string num_day_week;
            private readonly int id;

            static int num_of_obj=0;
            private Airline(int id)
            {
                this.id=id;
                num_of_obj++;
                Console.WriteLine(num_of_obj++);
            }

            public static Airline Method(int id)
            {
                return new Airline(id);
            }

            public Airline() => max_time=12;
            public Airline(string destination,int flight_number, string departure_time, string num_day_week="вторник",string aircraft_type="Авиалайнер")
            {
               this.destination = destination;
                this.flight_number = flight_number;
                this.departure_time = departure_time;
                this.num_day_week = num_day_week;
                this.aircraft_type = aircraft_type;
                this.id = (flight_number * 2) - 3;
            }
            public Airline(int flight_number,string departure_time, string num_day_week,string aircraft_type)
            {
                this.destination = "Москва";
                this.flight_number = flight_number;
                this.departure_time = departure_time;
                this.num_day_week = num_day_week;
                this.aircraft_type = aircraft_type;
                this.id= (flight_number * 2) - 3;
            }


            public int Get_flight_number
            {
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Число должно быть положительным");
                    }
                    else
                    {
                        flight_number = value;
                    }
                }
                get
                {
                    return flight_number;
                }
            }
            public string Get_day
            {
                set
                {
                    num_day_week=value;
                }
                get
                {
                    return num_day_week;
                }
            }
            
            public string Get_Destination
            {
                set
                {
                    destination = value;
                }
                get
                {
                    return destination;
                }
            }

            public void RefOutFunc(ref int a, out int b)
            {
                b=a+9;
            }
            public override int GetHashCode()
            {
                int hash = 17;
                hash = 23 + num_of_obj.GetHashCode();
                hash = hash * 2;
                return hash;
            }

            public override bool Equals(object obj)
            {
                if(obj is Airline airline)return destination == airline.destination;
                return false;
            }

            public override string ToString()
            {
                return $"Пункт назначения: {destination}. Время отправления:{departure_time}";
            }

        }

        public partial class Airline
        {
            public static void Information(Airline airline)
            {
                Console.WriteLine("Пункт назначения: " + airline.destination);
                Console.WriteLine("Номер рейса: " + airline.flight_number);
                Console.WriteLine("Время вылета: " + airline.departure_time);
                Console.WriteLine("Дни недели: " + airline.num_day_week);
                Console.WriteLine("Тип самолёта: " + airline.aircraft_type);
                Console.WriteLine("Id: " + airline.id);
            }
        }


        static void Main(string[] args)
        {
            // Анонимный тип
            var anonymousAirline = new
            {
                Destination = "Минск",
                FlightNumber = 123,
                DepartureTime = "14:30",
                NumDayWeek = "вторник",
                AircraftType = "Авиалайнер",
                Id = (123 * 2) - 3
            };

            Console.WriteLine("Анонимный тип:");
            Console.WriteLine($"Пункт назначения: {anonymousAirline.Destination}");
            Console.WriteLine($"Номер рейса: {anonymousAirline.FlightNumber}");
            Console.WriteLine($"Время вылета: {anonymousAirline.DepartureTime}");
            Console.WriteLine($"День недели: {anonymousAirline.NumDayWeek}");
            Console.WriteLine($"Тип самолёта: {anonymousAirline.AircraftType}");
            Console.WriteLine($"Id: {anonymousAirline.Id}");

            //инициализация объектов
            Airline flight1 = new Airline("Минск", 101, "08:30");
            Airline flight2 = new Airline(202, "12:45", "среда", "Турбовинтовой");
            Airline flight3 = new Airline();

            //Information
            Airline.Information(flight1);
            Console.WriteLine();

            Airline.Information(flight2);
            Console.WriteLine();

            flight1.Get_flight_number = 303;
            Console.WriteLine("Обновлённый номер рейса flight1: " + flight1.Get_flight_number);
            Console.WriteLine();

            // Сравнение
            Console.WriteLine("flight1.Equals(flight2): " + flight1.Equals(flight2));
            Console.WriteLine("flight1.Equals(flight1): " + flight1.Equals(flight1));
            Console.WriteLine();

            // Проверка типа
            Console.WriteLine("Тип flight1: " + flight1.GetType());
            Console.WriteLine();

            // Вызов ToString
            Console.WriteLine("ToString flight2: " + flight2.ToString());
            Console.WriteLine();

            //ref и out
            int x = 5;
            int y;
            flight1.RefOutFunc(ref x, out y);
            Console.WriteLine($"После RefOutFunc: x = {x}, y = {y}");
            Console.WriteLine();

            // Массив
            Airline[] flights = new Airline[4];
            flights[0] = flight1;
            flights[1] = flight2;
            flights[2] = new Airline("Минск", 404, "18:00", "пятница", "Реактивный");
            flights[3] = new Airline("Дубай", 356, "20:00", "вторник", "Кукурузник");

            Console.WriteLine("Информация о рейсах в массиве:");
            foreach (var flight in flights)
            {
                Airline.Information(flight);
                Console.WriteLine();
            }

            Console.WriteLine("Рейсы во вторник:");
            string day = "вторник";
            foreach(var flight in flights)
            {
                if (day == flight.Get_day)
                {
                    Airline.Information(flight);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Пункт назначения - Минск:");
            string destination_town = "Минск";
            foreach (var flight in flights)
            {
                if (destination_town == flight.Get_Destination)
                {
                    Airline.Information(flight);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Количество созданных объектов при помощи закрытого конструктора:");
            Airline example = Airline.Method(2);
        }
    }
}
