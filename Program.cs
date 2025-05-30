    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person<int> tom = new Person<int>(546, "Tom");
            //Person<string> bob = new Person<string>("a1", "Bob");

            ////int tomId = (int)tom.Id;
            ////string bobId = (string)bob.Id;


            //int tomId = tom.Id;
            //string bobId = bob.Id;
            //Console.WriteLine($"Tom's ID: {tomId}\nBob's ID: {bobId}");

            Company<Person<int>> microsoft = new Company<Person<int>>(tom);
            Console.WriteLine($"Microsoft's CEO: {microsoft.CEO.Name}\nID: {microsoft.CEO.Id}");
            Console.ReadKey();
        }
    }
}
