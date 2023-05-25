using TestCaseGeometry.Domains;
using System.Collections.Generic;

namespace TestCaseGeometry.Factories
{
    public class TriangleFactory : FigureFactory
    {
        private readonly List<double> _sides;

        public TriangleFactory(List<double> sides)
        {
            _sides = sides;
        }

        public override IFigure GetFigure()
        {
            Triangle figure = new(_sides)
            {
                Sides = _sides
            };
            return figure; 
        }
    }
}
