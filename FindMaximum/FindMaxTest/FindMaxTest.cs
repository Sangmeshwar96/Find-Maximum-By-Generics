using FindMaximum;
using System.Collections.Generic;
using NUnit.Framework.Internal;

namespace FindMaxTest
{
    public class Tests
    {
        FindMaxGeneric<int> intfindMaximum = new FindMaxGeneric<int>();
        FindMaxGeneric<float> floatfindMaximum = new FindMaxGeneric<float>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = intfindMaximum.FindMaximumGeneric(26, 17, 12);
            Assert.AreEqual(26, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = intfindMaximum.FindMaximumGeneric(26, 36, 30);
            Assert.AreEqual(36, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = intfindMaximum.FindMaximumGeneric(26, 36, 45);
            Assert.AreEqual(45, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxFirstFloat_WhenAnalysed_ShouldReturnFirstMax()
        {
            float result = floatfindMaximum.FindMaximumGeneric(26.25f, 17.36f, 12.25f);
            Assert.AreEqual(26.25f, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxSecondFloat_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = floatfindMaximum.FindMaximumGeneric(26.26f, 36.63f, 30.36f);
            Assert.AreEqual(36.63f, result);
            //Assert.Pass();
        }
        [Test]
        public void GivenMaxThirdFloat_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = floatfindMaximum.FindMaximumGeneric(26.21f, 36.23f, 45.36f);
            Assert.AreEqual(45.36f, result);
            //Assert.Pass();
        }
    }
}