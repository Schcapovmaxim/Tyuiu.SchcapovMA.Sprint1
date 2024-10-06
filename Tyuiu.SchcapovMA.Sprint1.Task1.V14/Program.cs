using Tyuiu.SchcapovMA.Sprint1.Task1.V14.Lib;
namespace Tyuiu.SchcapovMA.Sprint1.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Щапов М.А. | ИБКСб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле a*b/c + (a/(b + c)) и печатает результат *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            double a, b, c;
            Console.WriteLine("Введите значение a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение c:");
            c = Convert.ToDouble(Console.ReadLine());





            Console.WriteLine("* a * b / c + (a / (b + c))                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(a, b, c));
            Console.ReadKey();
        }
    }
}
