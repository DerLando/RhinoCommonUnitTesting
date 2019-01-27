using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Geometry;
using Geodesics;

namespace RhinoPluginTests
{
    [TestClass]
    public class EVectorTests
    {
        [DataTestMethod]
        [DataRow(1,0)]
        [DataRow(0.05,3)]
        [DataRow(-40.23,3.14235)]
        public void GetUnitize_ShouldBeUnitizing(double x, double y)
        {
            // Arrange
            double expected = 1.0;
            EVector testVector = new EVector(x, y).GetUnitized();

            // Act
            double actual = testVector.Length;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
