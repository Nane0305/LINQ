using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L = 3;
            List<char> text = new List<char>("qwery12435");

            IEnumerable<char> buf = ((from sign in text
                                      where char.IsDigit(sign)
                                      select sign).Take(L)) ?? "Not Found";


            string? res = new string(buf.Take(buf.Count()).ToArray());
            if (res.Length <= 1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine(res);
            }
        }
    }
}