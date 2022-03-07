using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZcapter1
{
    public class Segments
    {
        private int Point1;
        private int Point2;
        private int Point3;
        public void SetDots(int Point1, int Point2, int Point3)
        {
            this.Point1 = Point1;
            this.Point2 = Point2;
            this.Point3 = Point3;
        }
        public void Sgmnt()
        {
            int C = Point1 + Point2;
            int D = Point2 + Point3;
            Console.WriteLine("Длина отрезка A и B = " + C + ", длина отрезка B и C = " + D);
            int F = D + C;
            Console.WriteLine("Сумма отрезков = " + F);
        }
        
    }
}
