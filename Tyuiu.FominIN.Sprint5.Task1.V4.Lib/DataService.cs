using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FominIN.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (double x = startValue; x <= stopValue; x++)
                    {
                        double result;
                        if (x != -1)
                        {
                            result = Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x;
                        }
                        else
                        {
                            result = 0;
                        }
                        writer.WriteLine($"{result:F2}");
                        Console.WriteLine($"{result:F2}");
                    }
                }
                return path;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return string.Empty;
            }
        }
        
    }
}
