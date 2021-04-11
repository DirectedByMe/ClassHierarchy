using System;

namespace ClassHierarchy
{
    public abstract class Shape
    {
        public abstract string Name { get; set; }
        public abstract double Volume();
        public abstract void DisplayInfo();
    }
}
