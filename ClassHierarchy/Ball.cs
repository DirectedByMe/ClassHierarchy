using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public class Ball : Shape
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double R;

        public Ball(double radius)
        {
            R = radius;
            _name = "Ball";
        }

        public override double Volume()
        {
            try
            {
                double result = (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
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
            Console.WriteLine($"{_name} with radius {R} has a volume {Volume()}");
        }
    }

    
}
