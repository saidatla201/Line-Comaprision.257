using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparision257
{
    public class Comparisionbetweenpoints
    {
        public static void Firstpoints()
        {
            Console.WriteLine("Enter the First line  Co-ordinates");
            Console.WriteLine("Enter the X1 value"); 
            double x1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the X2 value");
            double x2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y1 value");
            double y1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y2 value");
            double y2= Convert.ToInt32(Console.ReadLine());


            double length =Math.Sqrt ((x2 - x1) * (x2-x1 ) + (y2 - y1)* (y2-y1));
            Console.WriteLine("Comparision between First line Co-ordinates" + length);


        }
    }
}
