using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZcapter1
{
    internal class Progr
    {
        static void Main(string[] args)
        {
            Segments first = new Segments();
            first.SetDots(5, 7, 16);
            first.Sgmnt();
            Console.ReadLine();
        }

    }
}
