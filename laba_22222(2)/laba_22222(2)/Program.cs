using System;
namespace Lab_2_2
{
    class Search
    {
        public string name { get; set; }
        public string type { get; set; }
        public int number { get; set; }
        public int weight { get; set; }
        static int count { get; set; }
        public Search(string y, string n, int d, int f)
        {
            name = y;
            type = n;
            number = d;
            weight = f;
        }
        public Search[] arr = new Search[10];
        public void Count()
        {
            count = arr.Length;
            Console.WriteLine("Кiлькiсть об’єктiв: " + count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search("", "", 0, 0);
            for (int i = 0; i < search.arr.Length; i++)
            {
                Console.Write("Найменування: ");
                string name = Console.ReadLine();
                Console.Write("Тип: ");
                string type = Console.ReadLine();
                Console.Write("Кiлькiсть: ");
                int number = Convert.ToInt16(Console.ReadLine());
                Console.Write("Вага 1 деталi(г): ");
                int weight = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("");
                search.arr[i] = new Search(name, type, number, weight);
            }
            search.Count();
            Console.WriteLine("");
            int b=0;
            int a = 0;
            int min= search.arr[0].weight;
            for (int i = 0; i < search.arr.Length; i++)
            {
                if (search.arr[i].number > 10)
                {
                    a++;
                }
                if(search.arr[i].weight<min)
                {
                    min = search.arr[i].weight;
                    b=i;
                }

            
            }
            if (a > 0)
                Console.WriteLine("Кiлькiсть одного типу деталей якi бiльше за 10: " + a);
            else
                Console.WriteLine("Кiлькiсть одного типу деталей не перевищує 10");
            Console.WriteLine("");
            Console.WriteLine("найменьша вага однiєї деталi належить: "+ search.arr[b].name);
        }
    }
}
