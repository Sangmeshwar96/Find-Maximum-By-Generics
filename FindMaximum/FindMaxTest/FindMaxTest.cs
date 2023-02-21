using FindMaximum;
using System.Collections.Generic;
using NUnit.Framework.Internal;

namespace FindMaxTest
{
    public class Tests
    {
        FindMaxGeneric<int> intfindMaximum = new FindMaxGeneric<int>();
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
    }
}