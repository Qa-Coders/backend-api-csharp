using APIT5MD2;
using System;

namespace API_TDD.test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestStartWithUppercase()
        {
            string[] words = { "Dog", "Cat", "Horse", "Mouse" };
            foreach(var word in words)
            {
                bool result = word.FirstCharUppercase();
                Assert.IsTrue(result, 
                    String.Format("Expected to '{0}': true; But: {1}",
                    word, result));
            }
        }

        [TestMethod]
        public void TestStartWithDowncase()
        {
            string[] words = { "cog", "cat", "horse", "mouse" };
            foreach (var word in words)
            {
                bool result = word.FirstCharUppercase();
                Assert.IsFalse(result,
                    String.Format("Expected to '{0}': true; But: {1}",
                    word, result));
            }
        }
    }
}