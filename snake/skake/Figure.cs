using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {

        protected List<Point> listPoint;              // Класс для наследования, здесь выносятся описание структуры List и метод Draw_line

        public void Draw_line()
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
