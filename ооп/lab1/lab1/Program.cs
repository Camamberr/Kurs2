using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите значение переменной типа bool (true/false)");
                bool boolValue = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа byte (от 0 до 255)");
                byte byteValue = byte.Parse(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа sbyte (от -128 до 127)");
                sbyte sbyteValue =Convert.ToSByte(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа char (один символ unicode)");
                char charValue =Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа decimal (до 29 десятичных цифр)");
                decimal decimalValue =Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа double (число с плавающей точкой)");
                double doubleValue =Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа float (число с плавающей точкой)");
                float floatValue =Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа short (от -32768 до 32767)");
                short shortValue =Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа ushort (от 0 до 65535)");
                ushort ushortValue = Convert.ToUInt16(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа int (от -2147483648 до 2147483647)");
                int intValue =Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа uint (от 0 до 4294967295)");
                uint uintValue =Convert.ToUInt32(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа long (от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807)");
                long longValue = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа ulong (от 0 до 18 446 744 073 709 551 615)");
                ulong ulongValue =Convert.ToUInt64(Console.ReadLine());

                Console.WriteLine("Введите значение переменной типа string (набор символов unicode)");
                string stringValue =Console.ReadLine();

                Console.WriteLine("Введите значение переменной типа object");
                object objectValue =Console.ReadLine();

                Console.WriteLine($"Значение переменной типа bool: {boolValue}");
                Console.WriteLine($"Значение переменной типа byte: {byteValue}");
                Console.WriteLine($"Значение переменной типа sbyte: {sbyteValue}");
                Console.WriteLine($"Значение переменной типа char: {charValue}");
                Console.WriteLine($"Значение переменной типа decimal: {decimalValue}");
                Console.WriteLine($"Значение переменной типа double: {doubleValue}");
                Console.WriteLine($"Значение переменной типа float: {floatValue}");
                Console.WriteLine($"Значение переменной типа short: {shortValue}");
                Console.WriteLine($"Значение переменной типа ushort: {ushortValue}");
                Console.WriteLine($"Значение переменной типа int: {intValue}");
                Console.WriteLine($"Значение переменной типа uint: {uintValue}");
                Console.WriteLine($"Значение переменной типа long: {longValue}");
                Console.WriteLine($"Значение переменной типа ulong: {ulongValue}");
                Console.WriteLine($"Значение переменной типа string: {stringValue}");
                Console.WriteLine($"Значение переменной типа object: {objectValue}");

                //Неявное приведение

                short isvalue = 6;
                int invalue = isvalue;
                long lonvalue = isvalue;
                float flvalue = isvalue;
                double dbvalue = isvalue;
                decimal decvalue = isvalue;

                //явное приведение
                int iv = 34;
                short sv = (short)iv;
                byte bs = (byte)iv;
                float fs = (float)dbvalue;
                double ds = (double)decvalue;
                sbyte ssv =(sbyte) bs;

                //упаковка и распаковка значимых типов

                int x = 5;
                object o = x;
                int y = (int)o;

                byte bt = (byte)(int)o;

                //неявно типизированная переменная
                var typeval = "asdf";
                Console.WriteLine(typeval.GetType());
                var typeval1 = 12;
                Console.WriteLine(typeval1.GetType());

                //nullable переменная

                int? oiu = null;
                Console.WriteLine(oiu.HasValue);

                oiu = 2;
                Console.WriteLine(oiu.HasValue);

                //СТРОКИ
                string str1 = "Peach pretty kitty";
                string str2 = "Orange little silk";
                string str3 = "lady";
                //сравнение
                if (str1 == str2)
                {
                    Console.WriteLine("Строки равны");
                }
                else
                {
                    Console.WriteLine("Строки не равны");
                }
                Console.WriteLine(String.Compare(str1, str2));

                //сцепление(конкатенация)
                Console.WriteLine($"Строка str3:{str3}. Строка str2: {str2}.");
                Console.WriteLine("Результат сцепления:" + str3 + " " + str2);
                Console.WriteLine(String.Concat(str3," ",str2));

                //копирование
                string str4= String.Copy(str3);
                Console.WriteLine(str4);

                //выделение подстроки
                 Console.WriteLine(str1.Substring(2, 6));

                //разделение строки на слова
                string[] strArr = str1.Split(' ');
                Console.WriteLine("Результат разделения на слова:");
                for(int i = 0; i < strArr.Length; i++)
                {
                    Console.WriteLine(strArr[i]);
                }

                //вставка
                Console.WriteLine(str3.Insert(4, str1));

                //удаление
                Console.WriteLine(str2.Remove(6,7));

                //интерполирование
                Console.WriteLine($"Строка str3: {str3}");

                //пустая и null строки
                string empty_str = "";
                string nul_str = null;
                Console.WriteLine(String.IsNullOrEmpty(empty_str));
                Console.WriteLine(String.IsNullOrEmpty(nul_str));

                Console.WriteLine(empty_str.Insert(0,"honey"));
                Console.WriteLine(String.Concat(nul_str,empty_str));

                //string builder
                StringBuilder sb = new StringBuilder("Играем в кошки-мышки");
               Console.WriteLine(sb.Remove(3,5));
                sb.Insert(0, "Куклы ");
                sb.Append(" Шарики");
                Console.WriteLine(sb);

                //массивы

                //многомерный массив

                int[,] big_arr = new int[3, 3] { { 1, 2, 3 }, { 12, 13, 14 }, { 16, 17, 18 } };
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        Console.Write("\t" + big_arr[i,j]);
                    }
                    Console.WriteLine();
                }
    string[] str_arr = new string[6] { "cat", "dog", "parrot", "peacock", "chicken", "snake" };
                for(int i = 0; i < str_arr.Length; i++)
                {
                    Console.WriteLine(str_arr[i]);
                }
                Console.WriteLine($"Длина массива: {str_arr.Length}");
                Console.WriteLine("Введите номер элемента, который вы хотите заменить.");
                int str_change_num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите слово, на которое вы хотите заменить");
                str_arr[str_change_num] = Console.ReadLine();
                Console.WriteLine("Измененный массив: ");
                for(int i = 0; i < str_arr.Length; i++)
                {
                    Console.WriteLine(str_arr[i]); 
                }
                //зубчатый массив
                float[][] arr_fl = { new float[2], new float[3], new float[4] };
                for(int i = 0; i < arr_fl.Length; i++)
                {
                    for( int j = 0; j < arr_fl[i].Length;j++)
                    {
                        Console.WriteLine("Введите элемент массива");
                        arr_fl[i][j] = Convert.ToSingle(Console.ReadLine());
                    }
                }
                Console.WriteLine("Вывод массива:");
                for(int i = 0; i < arr_fl.Length; i++)
                {
                    for(int j = 0;j < arr_fl[i].Length; j++)
                    {
                        Console.Write("\t"+arr_fl[i][j]);
                    }
                    Console.WriteLine();
                }

                //неявно типизированные
                var sdp = new[] { true,false};
                var poi = "adf";
             

            //кортежи
            (int, string, char, string, ulong)tlip = (3, "qwer", 'a', "uytr", 12346);
            Console.WriteLine(tlip);
            Console.WriteLine(tlip.Item2);
            Console.WriteLine(tlip.Item3);
            Console.WriteLine(tlip.Item4);
            //распаковка
            var (it1, it2, it3, it4, it5) = tlip;
            Console.WriteLine(it1);
            var (it6, _, it8, it9, it10) = (7, "blink", 's', "aef", 12348998765);
            Console.WriteLine(it8);
            //сравнение
            var tuple1 = (word:"qwe", number:5);
            var tuple2 = (word: "qwe", number:5);
                Console.WriteLine( tuple1== tuple2);

            //функции
            (int,int,int,string)loc_func(int[] array,string strr)
            {
                int max_num = array.Max();
                int min_num=array.Min();
                int sum_num = array.Sum();
                string strr_first = strr.Substring(0,1);
                return(max_num,min_num,sum_num,strr_first);
            }
            int[] integer_array = { 20, 1, 5, 12, 35 };
            string str_funs = "Собака";
            Console.WriteLine(loc_func(integer_array, str_funs));

            int iMax = int.MaxValue;
            void check_func()
            {
                try
                {
                    checked
                    {
                        int v1 = iMax + 3;
                    }
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Переполнение");
                 }
            }
            void uncheck_func()
            {
                    unchecked
                    {
                        int v2 = iMax+3;
                    }
            }
            Console.WriteLine("Checked");
            check_func();
            Console.WriteLine("Unchecked");
           uncheck_func();
        }
    }
}
