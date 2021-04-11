using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public class Box : Shape
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double H;
        public List<Shape> Conteiner;

        public Box(double height)
        {
            H = height;
            _name = "Cube";
            Conteiner = new List<Shape>();
        }

        public override double Volume()
        {
            try
            {
                double result = Math.Pow(H, 3);
                return result;
            }

            catch
            {
                Console.WriteLine("Error, return 0");
                return 0;
            }
        }

        public bool Add(Shape shape)
        {
            if ((this.Volume() - this.FilledVolume()) > shape.Volume())
            {
                Conteiner.Add(shape);
                Console.WriteLine($"A {shape.Name} of volume {shape.Volume()} placed in a container");
                return true;
            }
            else
            {
                Console.WriteLine($"A {shape.Name} of volume {shape.Volume()} cannot be placed in a container. A conteiner with a volume of {this.Volume()} is full of {this.FilledVolume()}");
                return true;
            }
        }

        private double FilledVolume()
        {
            double vol = 0;
            foreach (Shape element in Conteiner)
            {
                vol += element.Volume();
            }
            return vol;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"A {_name} with an edge height {H} has a volume {Volume()}");
        }

        public void ConteinerDisplayInfo()
        {
            Console.WriteLine($"The {Volume()} container is full of {FilledVolume()}. The following shapes are placed in the container:");
            foreach (Shape element in Conteiner)
            {
                element.DisplayInfo();
            }
            Console.WriteLine();
        }

    }

}
