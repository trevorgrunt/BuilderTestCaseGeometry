using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCaseGeometry.Domains;

namespace TestCaseGeometry.Factories
{
    public class CircleFactory : FigureFactory
    {
        private readonly double _radius;

        public CircleFactory(double radius)
        {
            _radius = radius;
        }

        public override IFigure GetFigure()
        {
            Circle figure = new(_radius)
            {

            };
            return figure;
        }
    }
}
