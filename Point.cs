using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Point<T>
    {
        T x;
        T y;
        public T X { get; set; }
        public T Y { get; set; }

        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
