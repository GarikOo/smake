using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Wall : Figure
    {
        private List<Figure> wallList = new List<Figure>();

        public Wall(int mapWight, int mapHeight)
        {
            Horizontal_line line_H_1 = new Horizontal_line(0, mapWight - 2, 0, '+');    // Horizontal_line(с какого x, по какой x, c какого y наченается отресовка, каким символом)           
            Horizontal_line line_H_2 = new Horizontal_line(0, mapWight - 2, mapHeight - 1, '+');
            Vertical_line line_v_1 = new Vertical_line(1, mapHeight - 1, 0, '+');     // Vertical_line(с какого y, по какой y, c какого x наченается отресовка, каким символом)           
            Vertical_line line_v_2 = new Vertical_line(1, mapHeight - 1, mapWight - 2, '+');
            Concat(line_H_1);
            Concat(line_H_2);
            Concat(line_v_1);
            Concat(line_v_2);
            wallList.Add(line_H_1);
            wallList.Add(line_H_2);
            wallList.Add(line_v_1);
            wallList.Add(line_v_2);
        }
        //internal bool ISNT(Figure figure)
        //{
        //    foreach (var Wall in walllist)
        //    {
        //        Wall.Draw_line();
        //    }
        //}
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw_line();
            }
        }


    }

}
