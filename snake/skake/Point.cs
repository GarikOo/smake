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
       public char sym;                                                      // каким символом огтресовывать точку 

        public Point()                                                       //конструктор для пустой точки 
        {
        }
        public Point(Point p)                                                //конструктор для инициализации точки при передачи ей другой точки 
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }      
        public Point( int point_x, int point_y, char sym_char = '@')         //кончтруктор для точки сост из x,y, char
        {
            x = point_x;
            y = point_y;
            sym = sym_char;
        }
        public void move(int offset, Directoin direction)                    // метод сдвига точки по значению offset и в направлении Direction
        {
            if (direction == Directoin.right)
            {
                x = x + offset;
            }
            else if(direction == Directoin.left)
            {
                x = x - offset;
            }
            if (direction == Directoin.up)
            {
                y = y + offset;
            }
            else if (direction == Directoin.down)
            {
                y = y - offset;
            }



        }                  
        public void Draw()                                                   // метод отресовки Point 
        {
            Console.SetCursorPosition(x, y);                           
            Console.Write(sym);                                         
        }
        public void Clear()                                                  // методо изменение Sym точки на ' '
        {
            sym = ' ';
            Draw();
        }
        public bool IsHit(Point p)                                          // проверка на равенство координат
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
