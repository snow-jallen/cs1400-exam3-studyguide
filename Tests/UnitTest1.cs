using System;
using Code;
using NUnit.Framework;

namespace Tests
{
    public class CircleDiameterTests
    {
        [Test]
        public void FindDiameter()
        {
            var actual = Program.CircleDiameter(78.53975);
            var expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaOfZeroThrowsException()
        {
            try
            {
                var actual = Program.CircleDiameter(0);
                Assert.Fail("No exception was thrown");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Area must be > 0", ex.Message);
            }
        }

        [Test]
        public void NegativeAreaThrowsException()
        {
            try
            {
                var actual = Program.CircleDiameter(-1);
                Assert.Fail("No exception was thrown");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Area must be > 0", ex.Message);
            }
        }

        [Test]
        public void ValidSideLength()
        {
            var actual = Program.RightTriangleSideLength(3, 90, 4);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InvalidAngle()
        {
            try
            {
                var actual = Program.RightTriangleSideLength(3, 45, 4);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Only works with right angles", ex.Message);
            }
        }

        [Test]
        public void AverageScore()
        {
            var actualResult = Program.ProcessTestScores();
            Assert.AreEqual(85.75M, actualResult.AverageScore);
        }
        
        [Test]
        public void MaxScore()
        {
            var actualResult = Program.ProcessTestScores();
            Assert.AreEqual(97, actualResult.MaxScore);
        }
                
        [Test]
        public void MaxScoreName()
        {
            var actualResult = Program.ProcessTestScores();
            Assert.AreEqual("Todd", actualResult.MaxScoreName);
        }        

        [Test]
        public void MinScore()
        {
            var actualResult = Program.ProcessTestScores();
            Assert.AreEqual(62, actualResult.MinScore);
        }
                
        [Test]
        public void MinScoreName()
        {
            var actualResult = Program.ProcessTestScores();
            Assert.AreEqual("Sally", actualResult.MinScoreName);
        }
    }
}