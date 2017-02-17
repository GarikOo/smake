using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Horizontal_line
    {
        List<Point> listPoint;
    public Horizontal_line(int xLeft, int xRight,int y, char sym ='@') {
            listPoint = new List<Point>();                                    //создаем лист list_POint в котором хранятся обьекты класса Point 
            for (int x = xLeft;  x <= xRight; x++)                            //пробегаем циклом с заданого xLeft по xRight с y-овой координаты
            {
                Point p = new Point(x, y, sym);                                // создаем обьект p класса Point  с передачей значений Xleft,y,sym
                listPoint.Add(p);                                              // добавляем обьект в список listPoint 
            }
            
        }

        public void Draw_line()                                                // проресовка линии через метода Draw в классе Point
        {
            for (int i = 0; i < listPoint.Count; i++)
            {
                listPoint[i].Draw();
            }
            //если не сработает то херани то что  в коментах
            /*
             * foreach(Poin p in listPoint)
             * {
             *  p.draw
             * }
             */

        }

    }
}
