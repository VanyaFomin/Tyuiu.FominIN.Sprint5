﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.FominIN.Sprint5.Task2.V29.Lib;

namespace Tyuiu.FominIN.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Tyuiu\source\repos\C#\Tyuiu.FominIN.Sprint5\Tyuiu.FominIN.Sprint5.Task2.V29\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
