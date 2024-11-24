
using Tyuiu.BushlyaYaV.Sprint5.Task0.V20.Lib;

namespace Tyuiu.BushlyaYaV.Sprint5.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\nefor\source\repos\Tyuiu.BushlyaYaV.Sprint5\Tyuiu.BushlyaYaV.Sprint5.Task0.V20\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
            Assert.AreEqual("29,36", File.ReadAllText(path));
        }
    }
}
