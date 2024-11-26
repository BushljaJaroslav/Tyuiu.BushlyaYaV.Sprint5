
using Tyuiu.BushlyaYaV.Sprint5.Task5.V20.Lib;

namespace Tyuiu.BushlyaYaV.Sprint5.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string path = @"C:\DataSprint5\InPutDataFileTask5V20.txt";
            Assert.AreEqual(5.5, ds.LoadFromDataFile(path));
        }
    }
}
