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
            Point p1 = new Point();  //  выделение памяти под структуру Point и создание обьекта P1 
            p1.x = 23;               //  инициализация значений в оъекте P1 значения x 
            p1.y = 21;               //  инициализация значений в оъекте P1 значения y 
                                     //  инициализация значения sym, Происходит по умолчанию в классе Point 
            p1.Draw(p1.x,p1.y);     //  вызов метода Draw класса Point
            Console.ReadLine();     //  заглушка 
        }
      
    }
}
