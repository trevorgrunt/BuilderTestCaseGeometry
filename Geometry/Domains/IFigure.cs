using System.Collections.Generic;

namespace TestCaseGeometry.Domains
{
    public interface IFigure
    {
        string Name { get; }
        List<double> Sides { get; set; }
        double Perimetr { get; }
        double Square { get; }
    }
}
