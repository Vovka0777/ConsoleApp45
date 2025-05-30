using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Segment<int> segment1 = new Segment<int>(1, 2, 3, 4);
            Segment<long> segment2 = new Segment<long>(5, 6, 7, 8);
            Segment<double> segment3 = new Segment<double>(1.1, 2.2, 3.3, 4.4);

            Console.WriteLine(segment1.ToString());
            Console.WriteLine($"Length of segment1: {segment1.Length()}");
            Console.WriteLine(segment2.ToString());
            Console.WriteLine($"Length of segment2: {segment2.Length()}");
            Console.WriteLine(segment3.ToString());
            Console.WriteLine($"Length of segment3: {segment3.Length()}");
            Console.ReadKey();
        }
    }
}
