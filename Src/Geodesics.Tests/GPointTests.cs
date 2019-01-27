using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Geometry;
using Geodesics;

namespace RhinoPluginTests
{
    [TestClass]
    public class GPointTests
    {
        [DataTestMethod]
        [DataRow(0,0,1,1,1,1)]
        [DataRow(1,2,0,0,-1,-2)]
        [DataRow(-3, 2, 1, -2, 4, -4)]
        public void MinusOperator_ShouldWorkForSimpleValues(double x1, double y1, double x2, double y2, double vx,
            double vy)
        {
            // Arrange
            // From pt1 to pt2
            double[] expected = {vx, vy};
            EVector testVector = new GPoint(x2, y2) - new GPoint(x1, y1);

            // Act
            double[] actual = {testVector.X, testVector.Y};

            // Assert
            CollectionAssert.Equals(expected, actual);
        }
    }
}
