
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BushlyaYaV.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string strX = File.ReadAllText(path);
                
                double x;
                while ((strX = reader.ReadLine()) != null)
                {
                    strX = strX.Replace(".", ",");
                    x = Convert.ToDouble(strX);
                    if (Math.Abs(x) >= 10 && Math.Abs(x) <= 99)
                    {
                        res *= x;
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
