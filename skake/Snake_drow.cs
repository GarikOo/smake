using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake_drow : Figure
    {
        Directoin  direction;
            public Snake_drow(Point tail, int lenght, Directoin _direction)                      // класс(часный случай фигуры) с методом 
        {
            direction = _direction;
            listPoint = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                listPoint.Add(p);
            }
        }

        internal void Move()                                                              // метод движения змейки на 1 в сторону direction
        {
            Point tail = listPoint.First();                                               // метод first - первый элемент списка
            listPoint.Remove(tail);                                                       //удаляем обьект tail из списка
            Point Head = GenNextPoint();                                                   // пользуемся методом genNextPoint который возращает обьект класса Point
            listPoint.Add(Head);
            tail.Clear();
            Head.Draw();
        }
        public Point GenNextPoint()
        {
            Point head = listPoint.Last();                                                     // брем последнюю точку из списка listPoint
            Point nextPoint = new Point(head);                                                 //создаем обьект nextPoint класса point
            nextPoint.move(1, direction);                                                      //используем метод move из класса point для обьекта nextPoint
            return nextPoint;                                                                  // возращаем точку 

        }
    }
}
