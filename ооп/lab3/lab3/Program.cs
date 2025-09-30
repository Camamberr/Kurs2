using static lab3.Program;

namespace lab3
{
    public static class StatisticOperation
    {
        public static int Sum(Stack_class s)
        {
            int sum = 0;
            foreach (int elements in s.stack)
            {
                sum += elements;
            }
            return sum;
        }
        public static int MaxMinDif(Stack_class s)
        {
            int max = s.stack.Max();
            int min = s.stack.Min();
            return max - min;
        }
        public static int CountElements(Stack_class s)
        {
            return s.stack.Count();
        }

        public static int CountSentences(this String text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;
            char[] sentenceEndings = { '.', '!', '?' };
            return text.Split(sentenceEndings, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static double Average(this Stack_class s)
        {
            double sum = s.stack.Sum();
            int count = s.stack.Count;
            return sum / count;
        }
    }

    public class Stack_class
    {
        public class Production
        {

            public int Id { get; set; }
            public string Name_of_Organization { get; set; }
            public Production(int id, string name)
            {
                this.Id = id;
                this.Name_of_Organization = name;
            }

        }
        Production production1 = new Production(123456, "Organization228");
        public class Developer
        {
            public string fullName { get; set; }
            public int Id { get; set; }
            public string Otdel { get; set; }

            public Developer(string fullName, int Id, string Otdel)
            {
                this.fullName = fullName;
                this.Id = Id;
                this.Otdel = Otdel;
            }
        }

        public Stack<int> stack { get; set; }
        public Stack_class()
        {
            stack = new Stack<int>();
        }

       static public void Information(Stack_class s)
        {
            Console.WriteLine("Элементы стека:");
            foreach(int element in s.stack)
            {
                Console.WriteLine(element);
            }
        }
        public static Stack_class operator +(Stack_class s, int stroka)
        {
            s.stack.Push(stroka);
            return s;
        }
        public static Stack_class operator --(Stack_class s)
        {
            int removed = s.stack.Pop();
            Console.WriteLine($"Удалено: {removed}");
            return s;
        }
        public static bool operator true(Stack_class s)
        {
            if (s.stack.Count == 0) return true;
            return false;
        }
        public static bool operator false(Stack_class s)
        {
            if (s.stack.Count > 0) return false;
            return true;
        }
        public static Stack_class operator >(Stack_class s, Stack_class s1)
        {
            List<int> list = new List<int>(s.stack);
            list.Sort();
            s1.stack.Clear();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                s1.stack.Push(list[i]);
            }

            return s1;
        }

        public static Stack_class operator <(Stack_class s, Stack_class s1)
        {
            List<int> list = new List<int>(s1.stack);
            list.Sort();
            s.stack.Clear();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                s.stack.Push(list[i]);
            }

            return s;
        }


        public int this[int index]
        {
            get { return stack.ElementAt(index); }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Stack_class stack1= new Stack_class();
            Stack_class stack2=new Stack_class();
            stack1 = stack1 + 10;
            stack1 = stack1 + 34;
            stack1 = stack1 + 23;
            stack1 = stack1 + 3;
            stack1 = stack1 + 99;
            Stack_class.Information(stack1);
            if (stack1)
            {
                Console.WriteLine("Стек пуст");
            }
            else
            {
                Console.WriteLine("Стек не пуст");
            }
           stack2= stack1 > stack2;
            Stack_class.Information(stack2);
            stack2 = stack2--;
            Stack_class.Information(stack2);
            Console.WriteLine($"Сумма: {StatisticOperation.Sum(stack1)}");
            Console.WriteLine($"Разница между max и min: {StatisticOperation.MaxMinDif(stack1)}");
            Console.WriteLine($"Количество элементов: {StatisticOperation.CountElements(stack1)}");
            Console.WriteLine($"Среднее значение: {stack1.Average()}");

            string text = "Здравствуй, лес. Дремучий лес? Полный сказок и чудес!";
            Console.WriteLine($"Количество предложений: {text.CountSentences()}");

            Stack_class.Developer developer1 = new Stack_class.Developer("Имя",12,"Отдел12");

            Console.WriteLine(stack1[2]);
                
        }
    }
}
