using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FominIN.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            using (StreamWriter sw = File.CreateText(path))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sw.Write($"{matrix[i, j]}");
                        if (j != matrix.GetLength(1) - 1)
                        {
                            sw.Write(";");
                        }
                    }
                    sw.WriteLine();
                }
            }

            return path;
        }
    }
}