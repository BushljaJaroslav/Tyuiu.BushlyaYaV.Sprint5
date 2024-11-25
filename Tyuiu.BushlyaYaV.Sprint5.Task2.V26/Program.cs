
using Tyuiu.BushlyaYaV.Sprint5.Task2.V26.Lib;

namespace Tyuiu.BushlyaYaV.Sprint5.Task2.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { 2, -3, -3 },
                                         {-8, 8, 0 },
                                         { -6, 1, 0 }};
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Бушля Я. В. | ИСТН-б-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Бушля Ярослав Владимирович | ИСТН-б-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
