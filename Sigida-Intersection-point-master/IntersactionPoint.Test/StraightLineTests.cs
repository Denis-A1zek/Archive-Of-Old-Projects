using IntersactionPont.MathLogic;
using IntersactionPont.MathLogic.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;

namespace IntersactionPoint.Test
{
    [TestClass]
    public class StraightLineTests
    {
        [TestMethod]
        public void Checking_Correct_Y_Recevied_FromX()
        {
            //Arrange 
            var expected = new Vector2(5, 3.429f);

            Line line = new Line(new Vector2(3, 4), new Vector2(10, 2));

            var straightLine = new StraightLine(line);
            
            //Act
            var act = straightLine.FindPointY(5);

            var actual = new Vector2(act.X, (float)Math.Round(act.Y, 3));

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
