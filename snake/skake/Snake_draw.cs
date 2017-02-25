using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake_draw : Figure
    {
         Directoin  direction;
        public Snake_draw(Point tail, int lenght, Directoin _direction)                      // класс(часный случай фигуры) с методом 
        {
            direction = _direction;
            pointList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                pointList.Add(p);
            }
        }
        internal void Move()                                                              // метод движения змейки на 1 в сторону direction
        {
            Point tail = pointList.First();                                               // метод first - первый элемент списка
            pointList.Remove(tail);                                                       //удаляем обьект tail из списка
            Point Head = GenNextPoint();                                                   // пользуемся методом genNextPoint который возращает обьект класса Point
            pointList.Add(Head);
            tail.Clear();
            Head.Draw();
        }

        public Point head() {
            return GenNextPoint();
           
        }

        public void ArrowKey(ConsoleKey key)                                                // обрабатывает нажатие стрелок и переносит в direction
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Directoin.left;
            else if (key== ConsoleKey.RightArrow)
                direction = Directoin.right;
            else if (key == ConsoleKey.UpArrow)
                direction = Directoin.down;
            else if (key == ConsoleKey.DownArrow)
                direction = Directoin.up;
        }
        public Point GenNextPoint()
        {
            Point head = pointList.Last();                                                     // брем последнюю точку из списка listPoint
            Point nextPoint = new Point(head);                                                 //создаем обьект nextPoint класса point
            nextPoint.move(1, direction);                                                      //используем метод move из класса point для обьекта nextPoint
            return nextPoint;                                                                  // возращаем точку 

        }
        internal bool Eat(Point food)
        {
            Point head = GenNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pointList.Add(food);
                return true;
            }
            else
                return false;
        }


    }

}
