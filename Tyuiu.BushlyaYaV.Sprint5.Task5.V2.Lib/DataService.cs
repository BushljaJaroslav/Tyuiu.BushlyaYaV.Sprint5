
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.BushlyaYaV.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {

            double count = 0;
            double sum = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace('.', ',');
                    line = line.Replace(',', ' ');
                    line = line.Replace(' ', '\n');


                    if (Convert.ToDouble(line) > 0)
                    {
                        sum = sum + Convert.ToDouble(line);
                        count += 1;
                    }
                }
                double res = sum / count;
                return Math.Round(res, 3);
            }
        }
    }
}
