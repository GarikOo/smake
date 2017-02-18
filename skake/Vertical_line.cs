using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Vertical_line :Figure                                                // вертикальная линия является наследником фигуры
    {
        
        public Vertical_line(int yUp, int yDown, int x, char sym = '@')
        {
            listPoint = new List<Point>();                                      //создаем лист list_POint в котором хранятся обьекты класса Point 
            for (int y = yUp; y <= yDown; y++)                                  //пробегаем циклом с заданого yUp по yDown с x-овой координаты
            {
                Point p = new Point(x, y, sym);                                // создаем обьект p класса Point  с передачей значений x,yUp,sym
                listPoint.Add(p);
            }

        }

    }
}