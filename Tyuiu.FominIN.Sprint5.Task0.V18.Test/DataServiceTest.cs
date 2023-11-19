using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.FominIN.Sprint5.Task0.V18.Lib;

namespace Tyuiu.FominIN.Sprint5.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Tyuiu\source\repos\C#\Tyuiu.FominIN.Sprint5\Tyuiu.FominIN.Sprint5.Task0.V18\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);

            Assert.IsTrue(fileInfo.Exists);
        }
    }
}
