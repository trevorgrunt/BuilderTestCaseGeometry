using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCaseGeometry.Domains;

namespace TestCaseGeometry.Factories
{
    public abstract class FigureFactory
    {
        public abstract IFigure GetFigure();
    }
}
