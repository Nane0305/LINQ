namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int D = 5;
            List<int> list1 = new List<int> { -10, 21, 35, 9, 10, -33, 40, 165, -25 };

            var result_1 = list1.FirstOrDefault(x => (x > 0) && (x % 10 == D));

            Console.WriteLine(result_1);
            Console.ReadKey();
        }
    }
}