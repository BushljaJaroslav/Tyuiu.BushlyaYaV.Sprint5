using Tyuiu.BushlyaYaV.Sprint5.Task7.V13.Lib;
namespace Tyuiu.BushlyaYaV.Sprint5.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V13.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(wait, fileInfo.Exists);
        }
    }
}
