using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Horizontal_line   : Figure
    {
        
    public Horizontal_line(int xLeft, int xRight,int y, char sym ='@')
        {
            pointList = new List<Point>();                                    //создаем лист list_POint в котором хранятся обьекты класса Point 
            for (int x = xLeft;  x <= xRight; x++)                            //пробегаем циклом с заданого xLeft по xRight с y-овой координаты
            {
                Point p = new Point(x, y, sym);                                // создаем обьект p класса Point  с передачей значений Xleft,y,sym
                pointList.Add(p);                                              // добавляем обьект в список listPoint 
            }
            
        }
    }
}
