using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bug_dotnet_test
{
    [TestClass]
    public class MyTestClass
    {
        [DataRow((char)8)] //html logger to print an error and results in an empty file
        [DataRow((char)122)]
        [TestMethod]
        public void UselessTestMethod(char key)
        {
            Assert.IsTrue(key > 0);
        }
    }
}
