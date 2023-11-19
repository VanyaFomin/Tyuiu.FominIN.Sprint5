using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FominIN.Sprint5.Task2.V29.Lib;

namespace Tyuiu.FominIN.Sprint5.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Фомин И. Н. | ПКТб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Обработка файлов                                                       *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #29                                                                  *");
            Console.WriteLine("* Выполнил: Фомин Иван Николаевич | ПКТб-23-1                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов,                         *");
            Console.WriteLine("* заполненный значениями с клавиатуры.                                         *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                     *");
            Console.WriteLine("********************************************************************************");

            int[,] mtrx = new int[3, 3] { { 9, 2, 5 },
                                          { 3, 2, 4 },
                                          { 2, 8, 8 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < colums; i++)
            {
                for (int j = 0; j < colums; j ++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();




        }
    }
}
