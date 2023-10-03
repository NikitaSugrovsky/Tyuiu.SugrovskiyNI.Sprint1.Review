using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint1.TaskReview.V1.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint1.TaskReview.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: SprintReview                                                     * ");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* Вычисляет математическое выражение по исходным значениям данных         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*        b + sqrt(b^(2)+4ac)                                              *");
            Console.WriteLine("*  z =  --------------------  - a^2c+b^-2                                 *");
            Console.WriteLine("*               2a                                                        *");


            Console.WriteLine("Введите значение X:");
            double xDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение B:");
            double bDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение C:");
            double cDouble = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate(xDouble, bDouble, cDouble));


            Console.ReadKey();
        }
    }
}
