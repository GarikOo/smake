using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class food_generatior
    {
        int mapHeight;
        int mapLength;
        char sym;

        Random random = new Random();

        public food_generatior(int mapHeight, int mapLength, char sym) {

            this.mapHeight = mapHeight;
            this.mapLength = mapLength;
            this.sym = sym;

        }

        public Point Createfood()
        {
            int x = random.Next(2 , mapHeight-2);
            int y = random.Next(2, mapLength-2);
            return new Point (x, y, sym);
        }
    }
}
