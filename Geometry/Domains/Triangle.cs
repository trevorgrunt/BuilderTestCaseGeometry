using System;
using System.Collections.Generic;
using System.Linq;

namespace TestCaseGeometry.Domains
{
    public class Triangle : IFigure
    {
        private readonly string _name;
        private readonly List<double> _sides;
        private readonly double _square;
        public Triangle(List<double> sides)
        {
            // Квадрат гипотенузы равен сумме квадратов катетов 
            if (Math.Pow(sides[0],2) + Math.Pow(sides[1],2) == Math.Pow(sides[2],2))
            {
                _name = "Rectangular triangle";
            }
            else
            {
                _name = "Triangle";
            }          
            _sides = sides;
        }

        public Triangle()
        {
             _name = "Triangle";
        }

        public string Name => _name;

        public List<double> Sides { get; set; }

        public double Perimetr => _sides.Sum() / 2;

        public double Square => Math.Sqrt(Perimetr * (Perimetr - Sides[0]) * (Perimetr - Sides[1]) * (Perimetr - Sides[2]));
    }
}
