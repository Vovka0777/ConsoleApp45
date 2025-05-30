using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<int> p1 = new Point<int>(3, 4);
            //string s1 = (string)p1.X;
            Point<uint> p2 = new Point<uint>(5, 6);
            Point<double> p3 = new Point<double>(1.5, 2.5);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());

            Console.Read();
        }
    }
}
