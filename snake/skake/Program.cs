using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(23,3,'!');  // конструктор 2  объект p1
            p1.Draw();

            Point test = new Point();        // конструктор 1  обьект test
            test.x = 1;
            test.y = 4;
            test.sym = 'a';
            test.Draw();

            Point p2 = new Point(12, 12);    //конструктор 2 оъект p2
            p2.Draw();

            Console.ReadLine();     
        }
      
    }
}
