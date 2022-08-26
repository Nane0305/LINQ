using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 1, -2, 3, 5, -8 };

            var query = from i in arrayInt group i by i < 0 into res select res;
            var pos = query.AsEnumerable().Where(i => i.Key == false).First().First();
            var pos2 = query.AsEnumerable().Where(i => i.Key == true).Last().Last();

            Console.WriteLine("The array: ");
            foreach (var item in query)
            {
                foreach (var elem in item)
                {
                    Console.Write($"{elem}\t");
                }
                Console.WriteLine();    
            }
            
            Console.WriteLine(pos);
            Console.WriteLine(pos2);
        }
    }
}