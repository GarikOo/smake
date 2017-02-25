using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {

        protected List<Point> pointList = new List<Point>();              // Класс для наследования, здесь выносятся описание структуры List и метод Draw_line

        public bool IsHit(Point wall_point)
        {
            for (int i = 0; i < pointList.Count; i++)
            {
                if (wall_point.IsHit(pointList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        protected void Concat(Figure f)
        {
            pointList.AddRange(f.pointList);
        }


        public void Draw_line()
        {
            pointList.ForEach(point => point.Draw());
            //for (int i = 0; i < listPoint.Count; i++)
            //{
            //    listPoint[i].Draw();
            //}
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
