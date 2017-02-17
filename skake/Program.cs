using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(23,3,'!');  
             //   p1.Draw();


            Horizontal_line line_H_1 = new Horizontal_line(0,20,0,'+');    // Horizontal_line(с какого x, по какой x, c какого y наченается отресовка, каким символом)
            line_H_1.Draw_line();
            Horizontal_line line_H_2 = new Horizontal_line(0, 20, 21, '+');
            line_H_2.Draw_line();

            Vertical_line line_v_1 = new Vertical_line(1, 20, 0, 'a');     // Vertical_line(с какого y, по какой y, c какого x наченается отресовка, каким символом)
            line_v_1.Draw_line();
            Vertical_line line_v_2 = new Vertical_line(1, 20, 20, 'a');
            line_v_2.Draw_line();

            Console.ReadLine();     
        }
      
    }
}
