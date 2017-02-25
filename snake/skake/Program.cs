using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(23, 3, '!');
            //   p1.Draw();



            Wall walls = new Wall(20, 15);
            walls.Draw();

            Point p = new Point(3, 3, 'a');
            Snake_draw snake = new Snake_draw(p, 9, Directoin.up);
            snake.Draw_line();

            food_generatior food_creator = new food_generatior(20, 20, '%');
            Point food = food_creator.Createfood();
            food.Draw();
            
            while (true)
            {
                if (snake.Eat(food) )
                {   

                    food = food_creator.Createfood();
                    food.Draw();
                }
                else
                {
                    if (walls.IsHit(snake.head()))
                        {
                        return;
                        }
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ArrowKey(key.Key);

                }
                
                
            }
        }
      
    }
}
