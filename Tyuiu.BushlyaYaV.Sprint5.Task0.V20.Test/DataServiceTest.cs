
using Tyuiu.BushlyaYaV.Sprint5.Task0.V20.Lib;

namespace Tyuiu.BushlyaYaV.Sprint5.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.SaveToFileTextData(2);
            Assert.AreEqual(File.ReadAllText(res), (37.56).ToString());
        }
    }
}
