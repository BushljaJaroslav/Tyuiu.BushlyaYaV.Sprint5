
using Tyuiu.BushlyaYaV.Sprint5.Task6.V14.Lib;
namespace Tyuiu.BushlyaYaV.Sprint5.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V14.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}
