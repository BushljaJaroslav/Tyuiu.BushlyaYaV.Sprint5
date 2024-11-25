
using Tyuiu.BushlyaYaV.Sprint5.Task3.V21.Lib;

namespace Tyuiu.BushlyaYaV.Sprint5.Task3.V21.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

           FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
