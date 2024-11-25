
using Tyuiu.BushlyaYaV.Sprint5.Task3.V21.Lib;

namespace Tyuiu.BushlyaYaV.Sprint5.Task3.V21.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(wait, fileInfo.Exists);
        }
    }
}
