using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FominIN.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            double result = CalculateY(x);
            string resultText = result.ToString("F3");

            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            File.WriteAllText(path, resultText);

            return path;
        }

        static double CalculateY(double x)
        {
            return x / Math.Sqrt(x * x + x);
        }
    
    }
}
