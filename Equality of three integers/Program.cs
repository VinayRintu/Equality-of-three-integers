using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_of_three_integers
{
    internal class Program
    {
        // Here we can use if condition also to compare values, but here used ternary operator
        static void Main(string[] args)
        {
            int x = 1, y = 2, z = 3;
            Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);
            Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));
            x = 1; y = 3; z = 3;
            Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);
            Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));
            x = 3; y = 3; z = 3;
            Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);
            Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));
            Console.ReadLine();
        }
        public static int test(int x, int y, int z)
        {
            return (x == y && y == z) ? 3 : (x != y && y != z && x != z) ? 0 : 2;
        }
    }
}
