using System;
using Xunit;

namespace ClassHierarchy.Test
{
    public class UnitTestClassHierarchy
    {
        [Fact]
        public void BoxVolumeTest()
        {
            Box box = new Box(10);

            double result = box.Volume();

            Assert.Equal(1000.0, result, 5);
        }

        [Fact]
        public void BallVolumeTest()
        {
            var ball = new Ball(15.0);

            double vol = ball.Volume();

            Assert.Equal(14137.167, vol, 3);
        }

        [Fact]

        public void CylinderVolumeTest()
        {
            var cylinder = new Cylinder(12.0, 5.0);

            double vol = cylinder.Volume();

            Assert.Equal(2261.9467, vol, 3);
        }

        [Fact]

        public void PyramidVolumeTest()
        {
            var pyramide = new Pyramid(10.0, 7.0);

            double vol = pyramide.Volume();

            Assert.Equal(23.333, vol, 3);
        }

    }
}
