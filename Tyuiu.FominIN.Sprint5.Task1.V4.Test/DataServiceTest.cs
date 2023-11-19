using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.FominIN.Sprint5.Task1.V4.Lib;

namespace Tyuiu.FominIN.Sprint5.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Tyuiu\source\repos\C#\Tyuiu.FominIN.Sprint5\Tyuiu.FominIN.Sprint5.Task1.V4\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
