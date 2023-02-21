using FindMaximum;
using NUnit.Framework.Internal;

namespace FindMaxTest
{
    public class Tests
    {
        FindMaxGenric<int> intfindMaximum = new FindMaxGenric<int>();
        FindMaxGenric<float> floatfindMaximum = new FindMaxGenric<float>();
        FindMaxGenric<string> stringfindMaximum = new FindMaxGenric<string>();
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}