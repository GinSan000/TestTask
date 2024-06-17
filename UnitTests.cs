
using SquareComputing;
namespace SquareTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_6_return_133_10()
        {
            Circle circle = new Circle("Ęđóă", 6);
            double expectedResult = 113.10;
            double actualResult = circle.GetSquare();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Circle_22_5_return_1590_43()
        {
            Circle circle = new Circle("Ęđóă", 22.5);
            double expectedResult = 1590.43;
            double actualResult = circle.GetSquare();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_5_4_3_return_6()
        {
            Triangle triangle = new Triangle("Ňđĺóăîëüíčę", 5, 4, 3);
            double expectedResult = 6;
            double actualResult = triangle.GetSquare();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Triangle_11_10_3_return_14_70()
        {
            Triangle triangle = new Triangle("Ňđĺóăîëüíčę", 11, 10, 3);
            double expectedResult = 14.70;
            double actualResult = triangle.GetSquare();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Triangle_10_10_10_return_43_30()
        {
            Triangle triangle = new Triangle("Ňđĺóăîëüíčę", 10, 10, 10);
            double expectedResult = 43.30;
            double actualResult = triangle.GetSquare();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Triangle_2_6_9_IsTriangle_return_true()
        {
            Triangle triangle = new Triangle("Ňđĺóăîëüíčę", 5, 6, 9);
            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}
