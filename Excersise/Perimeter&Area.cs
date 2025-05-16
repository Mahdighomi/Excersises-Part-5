using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise
{
    public class Perimeter_Area
    {
        public static void Perimiter()
        {
            Console.WriteLine("Give me the first Triangle side : ");
            double SideA = Double.Parse(Console.ReadLine());           
            Console.WriteLine("Give me the second Triangle side : ");
            double SideB = Double.Parse(Console.ReadLine());           
            Console.WriteLine("Give me the third Triangle side : ");
            double SideC = Double.Parse(Console.ReadLine());

            double Result = SideA + SideB + SideC;
            Console.WriteLine($"Your perimiter of this Triangle is {Result}");
            Console.WriteLine("*********");
        }

        public static void Area()
        {
            Console.WriteLine("Give me the Base side : ");
            double Base = Double.Parse(Console.ReadLine());
            Console.WriteLine("Give me the Height Triangle : ");
            double Height = Double.Parse(Console.ReadLine());

            double Result = 0.5*Base*Height;
            Console.WriteLine($"Your area of this Triangle is {Result}");
            Console.WriteLine("*********");
        }
    }
}
