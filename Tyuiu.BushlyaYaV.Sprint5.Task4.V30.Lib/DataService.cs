
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BushlyaYaV.Sprint5.Task4.V30.Lib
{
    public class DataService : ISprint5Task4V30
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path).Replace('.', ','));
            return Math.Round((Math.Pow(x, 3) - Math.Tan(x)) + 2.03 * x, 3);

        }
    }
}
