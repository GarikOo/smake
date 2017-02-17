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

        public Point()                  //конструктор 1
        {
        }
        
        public Point( int point_x, int point_y, char sym_char = '@')         //кончтруктор 2
        {
            x = point_x;
            y = point_y;
            sym = sym_char;
        }
                
        public void Draw()        
        {
            Console.SetCursorPosition(x, y);                           
            Console.Write(sym);                                         
        }
    }
}
