using Tyuiu.BushlyaYaV.Sprint5.Task7.V13.Lib;
namespace Tyuiu.BushlyaYaV.Sprint5.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Бушля Я.В. | ИСТНб-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #5                                                            *");
            Console.WriteLine("* Тема: Файлы                                                          *");
            Console.WriteLine("* Задание #7                                                           *");
            Console.WriteLine("* Вариант #13                                                          *");
            Console.WriteLine("* Выполнил: Бушля Ярослав Владимирович | ИСТНб-24-1                    *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных.Удалить все строчные *");
            Console.WriteLine("* латинские буквы из файла.Полученный результат сохранить в файл.      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V13.txt");

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine(ds.LoadDataAndSave(path));
        }
    }
}
