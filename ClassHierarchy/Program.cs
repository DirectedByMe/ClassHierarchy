using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    class Program
    {
        static void Main (string[] args)
        {
            Box box = new Box(23);
            Shape cylinder = new Cylinder(13, 8);
            Shape pyramid = new Pyramid(9, 11);
            Shape ball = new Ball(6);

            Console.WriteLine("We have the following shapes:\n");

            box.DisplayInfo();
            cylinder.DisplayInfo();
            pyramid.DisplayInfo();
            ball.DisplayInfo();

            Console.WriteLine();

            if (box.Add(ball))
            {
                box.ConteinerDisplayInfo();
            }

            if (box.Add(cylinder))
            {
                box.ConteinerDisplayInfo();
            }

            if (box.Add(pyramid))
            {
                box.ConteinerDisplayInfo();
            }
        }
    }
}
