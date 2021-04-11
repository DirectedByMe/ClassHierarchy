using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public class Cylinder : Shape
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double R;
        public double H;
        public Cylinder (double baseRadius, double height)
        {
            R = baseRadius;
            H = height;
            _name = "Cylinder";
        }

        public override double Volume()
        {
            try
            {
                double result = Math.PI * Math.Pow(R, 2) * H;
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
            Console.WriteLine($"{_name} with base radius {R} and height {H} has a volume {Volume()}");
        }
    }
}
