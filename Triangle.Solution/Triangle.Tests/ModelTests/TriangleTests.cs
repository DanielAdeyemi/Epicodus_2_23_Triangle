using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void ValidateTriangle_ValidSides_Valid()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual("valid", testTriangle.ValidateTriangle(3,4,5));
        }

        [TestMethod]
        public void ValidateTriangle_ValidSides_Invalid()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual("invalid", testTriangle.ValidateTriangle(3,-4,0));
        }
        [TestMethod]
        public void ValidateTriangle_ValidTriangle_Invalid()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual("invalid", testTriangle.ValidateTriangle(2,2,8));
        }

        [TestMethod]
        public void ValidateTriangle_IsoscaleTriangle_True()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual("Isosceles Triangle", testTriangle.ValidateTriangle(4,4,5));
        }

        [TestMethod]
        public void ValidateTriangle_EquilateralTriangle_True()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual("Equilateral Triangle", testTriangle.ValidateTriangle(4,4,4));
        }

        [TestMethod]
        public void ValidateTriangle_ScaleneTriangle_True()
        {
            Triangle testTriangle = new Triangle();
            Assert.AreEqual("Scalene Triangle", testTriangle.ValidateTriangle(3,4,5));
        }
    }
}
