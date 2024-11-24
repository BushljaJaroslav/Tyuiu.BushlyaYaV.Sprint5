
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BushlyaYaV.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double x1 = Math.Round(2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x, 3);
            File.WriteAllText(path, x1.ToString());
            return path;
            
        }
    }
}
