namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> _dataEx4 = new List<int> { -12, -33, 134, 12, 5, -3, 55, 185, 5, 58, 5, 10 };

            var res = _dataEx4.Where(x => x > 0)
                    .Select(x => x % 10)
                    .Distinct()
                    .ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}