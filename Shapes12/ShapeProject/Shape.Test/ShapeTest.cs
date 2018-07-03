using System;
using System.Globalization;
using Xunit;
using ShapeProject;
using Xunit.Abstractions;

namespace Shape.Test
{

    public class ShapeTest
    {
        private readonly ITestOutputHelper _output;

        public ShapeTest(ITestOutputHelper output)
        {
            _output = output;
        }


        [Fact]
        public void DrawRectangle()
        {
            ShapeProject.Shape r = new Rectangle("Rectangle", 10, 10);

            var actual1 = r.GetName();
            var actual2 = r.GetArea();
            _output.WriteLine(actual1);
            _output.WriteLine(actual2.ToString(CultureInfo.CurrentCulture));
            Assert.Equal("The shape of this is: Rectangle", actual1);
            Assert.Equal(100, actual2);
        }

        [Fact]
        public void DrawSquare()
        {
            ShapeProject.Shape s = new Square("Square", 10);

            var actual1 = s.GetName();
            var actual2 = s.GetArea();
            _output.WriteLine(actual1);
            _output.WriteLine(actual2.ToString(CultureInfo.CurrentCulture));
            Assert.Equal("This shape is derived from rectangle: Square", actual1);
            Assert.Equal(100, actual2);
        }

        [Fact]
        public void DrawCircle()
        {
            ShapeProject.Shape c = new Circle("Circle", 2.5);

            var actual1 = c.GetName();
            var actual2 = c.GetArea();
            _output.WriteLine(actual1);
            _output.WriteLine(Math.Round(actual2, 3).ToString(CultureInfo.CurrentCulture));
            Assert.Equal("This is overriden: Circle", actual1);
            Assert.Equal(19.635, Math.Round(actual2, 3));
        }

        [Fact]
        public void DrawTriangle()
        {
            ShapeProject.Shape t = new Triangle("Triangle", 10, 5);

            var actual1 = t.GetName();
            var actual2 = t.GetArea();
            _output.WriteLine(actual1);
            _output.WriteLine(actual2.ToString(CultureInfo.CurrentCulture));
            Assert.Equal("I think this should be: Triangle", actual1);
            Assert.Equal(25, actual2);
        }

        [Fact]
        public void DrawIsocelesTriangle()
        {
            ShapeProject.Shape iT = new IsocelesTriangle("Isoceles Triangle", 10, 5);

            var actual1 = iT.GetName();
            var actual2 = iT.GetArea();
            _output.WriteLine(actual1);
            _output.WriteLine(actual2.ToString(CultureInfo.CurrentCulture));
            Assert.Equal("My Parent is triangle: Isoceles Triangle", actual1);
            Assert.Equal(25, actual2);
        }
    }
}
