using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseGeometry.Domains
{
    public class Circle : IFigure
    {
        private readonly string _name;
        private readonly double _square;
        private readonly double _radius;

        public Circle(double radius)
        {
            _name = "Circle";
            _radius = radius;
        }

        public Circle()
        {
            _name = "Circle";
        }

        public string Name => _name;

        public List<double> Sides { get; set; }

        public double Perimetr => 2 * Math.PI * _radius;
        public double Square => Math.PI * Math.Pow(_radius, 2);
    }
}
