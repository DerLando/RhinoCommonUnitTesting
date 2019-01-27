using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Geometry;
using Geodesics;

namespace RhinoPluginTests
{
    [TestClass]
    public class ELineTests
    {
        [DataTestMethod]
        [DataRow(0, 0, 1, 1, 1, 0)]
        [DataRow(-3, 2, 0, -2, (-4/3.0), -2)]
        [DataRow(12, -4, -21, 8, (-4/11.0), (4/11.0))]
        public void ELine_TwoPointConstructor(double x1, double y1, double x2, double y2, double m, double b)
        {
            // Arrange
            double[] expected = {m, b};
            ELine testLine = new ELine(new GPoint(x1, y1), new GPoint(x2, y2));

            // Act
            double[] actual = testLine.Equation;

            // Assert
            CollectionAssert.AreEqual(expected, actual, new DoubleComparer());
        }
    }
}
