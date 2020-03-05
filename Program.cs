using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            Circle c = new Circle(10.10101, 15.15151, 5.54545);
            c.ShowCircle();
            Console.ReadKey();
        }
    }
}