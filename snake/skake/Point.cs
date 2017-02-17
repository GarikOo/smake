using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
       public int x;
       public int y;
       public char sym;

        public void Draw( int x = 0, int y = 0, char sym = '@' )        //метод класса Point (+ значения по умолчанию)
        {
            Console.SetCursorPosition(x, y);                            // установка курсора на значение координат
            Console.Write(sym);                                         //вывод символа Sym 
        }
    }
}
