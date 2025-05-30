using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Segment <T>
    {
        public T x1,x2, y1, y2;

        public T X1 { get => x1; set => x1 = value; }
        public T X2 { get => x2; set => x2 = value; }
        public T Y1 { get => y1; set => y1 = value; }
        public T Y2 { get => y2; set => y2 = value; }

        public Segment(T x1, T y1, T x2, T y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }
        public override string ToString()
        {
            return $"Segment: ({X1}, {Y1}) to ({X2}, {Y2})";
        }

        public double Length()
        {

            return Math.Sqrt((Convert.ToDouble(X2) - Convert.ToDouble(X1)) * (Convert.ToDouble(X2) - Convert.ToDouble(X1)) + (Convert.ToDouble(Y2) - Convert.ToDouble(Y1)) * (Convert.ToDouble(Y2) - Convert.ToDouble(Y1)));
        }
    }
}
