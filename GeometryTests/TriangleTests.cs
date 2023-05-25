using TestCaseGeometry.Domains;
using TestCaseGeometry.Factories;

namespace GeometryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleCreate()
        {
            Triangle testTriangleEmpty = new Triangle();
            Assert.AreEqual(testTriangleEmpty.Name, "Triangle");

            Triangle testTriangleFilled = new Triangle(new List<double> { 3.0, 4.0, 5.0 });
            Assert.AreEqual(testTriangleFilled.Name, "Rectangular triangle");
        }

        [TestMethod]
        public void TriangleSquare()
        {
            Triangle testTriangleEmpty = new Triangle();
            Assert.AreEqual(testTriangleEmpty.Square, 0);

            Triangle testTriangleFilled = new Triangle(new List<double> { 3.0, 4.0, 5.0 });
            Assert.AreEqual(testTriangleFilled.Square, 6);
        }
    }
}