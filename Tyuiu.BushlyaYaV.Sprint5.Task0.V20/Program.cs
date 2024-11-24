
using Tyuiu.BushlyaYaV.Sprint5.Task0.V20.Lib;

namespace Tyuiu.BushlyaYaV.Sprint5.Task0.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Бушля Я. В.  | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #0                                                               *");
            Console.WriteLine("*Вариант #20                                                              *");
            Console.WriteLine("*Выполнил: Бушля Ярослав Владимирович | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение и сохраняет             *");
            Console.WriteLine("*  в текстовый файл OutPutFileTask0.txt                                   *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService service1 = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("x = 2                                                                     *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = service1.SaveToFileTextData(2);
            Console.WriteLine("Файл записан");
            Console.WriteLine(File.ReadLines(path).First());
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
