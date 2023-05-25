using TestCaseGeometry.Domains;
using TestCaseGeometry.Factories;

namespace GeometryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleCreate()
        {
            Circle testCircleEmpty = new Circle();
            Assert.AreEqual(testCircleEmpty.Name, "Circle");

            Circle testCircleFilled = new Circle(5);
            Assert.AreEqual(testCircleEmpty.Name, "Circle");
        }

        [TestMethod] 
        public void CircleSquare()
        {
            Circle testCircleEmpty = new Circle();
            Assert.AreEqual(testCircleEmpty.Square, 0);

            Circle testCircleFilled = new Circle(5);
            Assert.AreEqual(testCircleFilled.Square, 78.53981633974483);
        }
    }
}