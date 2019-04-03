using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рефакторирайте_oбем_на_пирамида
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = 0;
            double widht = 0;
            double hight = 0;
            double Volume = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            widht = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            hight = double.Parse(Console.ReadLine());
            Volume = (lenght * widht * hight)/3 ;
            Console.WriteLine("Pyramid Volume: {0:F2}", Volume);

        }
    }
}
