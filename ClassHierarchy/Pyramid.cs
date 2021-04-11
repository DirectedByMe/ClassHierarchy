using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public class Pyramid : Shape
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double S;
        public double H;

        public Pyramid (double baseArea, double height)
        {
            S = baseArea;
            H = height;
            _name = "Pyramid";
        }

        public override double Volume()
        {
            try
            {
                double result = S * H / 3;
                return result;
            }

            catch (Exception exception)
            {
                Console.WriteLine("Error, return 0");
                return 0;
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{_name} with base Area {S} and height {H} has a volume {Volume()}");
        }
    }
}
