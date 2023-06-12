using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntersactionPont.MathLogic;
using System.Numerics;
using IntersactionPont.MathLogic.Model;

namespace IntersactionPoint.Test
{
    [TestClass]
    public class IntersactionsPointTests
    {

        [TestMethod]
        public void IntersectionPoint_Check_IsCrosing()
        {
            //Arrange
            Vector2 expected = new Vector2(8, 4);

            Line line = new Line(new Vector2(2,2), new Vector2(11,5));
            Line line2 = new Line(new Vector2(2,7), new Vector2(12,2));
            var intersaction = new IntersectionsPoint(line, line2);

            //Act
            var actual = intersaction.Find();

            //Assert 
            Assert.AreEqual(expected, actual.Result, $"Test completed with \"{actual.Message}\"");
        }

        [TestMethod]
        public void IntersectionPoint_Check_IsParallel()
        {
            //Arrange
            Vector2 expected = new Vector2(0, 0);

            Line line = new Line(new Vector2(2, 3), new Vector2(6, 7));
            Line line2 = new Line(new Vector2(8, 1), new Vector2(11, 4));
            var intersaction = new IntersectionsPoint(line, line2);

            //Act
            var actual = intersaction.Find();

            //Assert 
            Assert.AreEqual(expected, actual.Result, $"Test completed with \"{actual.Message}\"");
        }

        [TestMethod]
        public void IntersectionPoint_Check_IsNotCross()
        {
            //Arrange
            Vector2 expected = new Vector2(0, 0);

            Line line = new Line(new Vector2(3, 4), new Vector2(10, 2));
            Line line2 = new Line(new Vector2(5, 6), new Vector2(1, 9));
            var intersaction = new IntersectionsPoint(line, line2);

            //Act
            var actual = intersaction.Find();

            //Assert 
            Assert.AreEqual(expected, actual.Result, $"Test completed with \"{actual.Message}\"");
        }


    }
}
