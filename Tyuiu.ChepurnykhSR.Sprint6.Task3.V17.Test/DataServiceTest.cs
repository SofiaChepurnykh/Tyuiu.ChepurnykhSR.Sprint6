﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint6.Task3.V17.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                {  22 , 32, -16 , 24 , 27 },
                {  3, -20,  24, -20,  25 },
                {  21,  17  ,-8 ,-19 , 17 },
                { 8 , 22 , 28,  27,  19 },
                { 11,  20,  12,  27,  29 }
            };

            int[,] wait = {
                { 22 , 32, -16 , -20 ,  27},
                {   3, -20,  24, -19,  25},
                {  21,  17  ,-8 ,24,  17},
                { 8 , 22 ,    28, 27,  19},
                {  11,  20,  12,  27,  29}
            };

            int[,] res = ds.Calculate(matrix);


            CollectionAssert.AreEqual(wait, res);
        }
    }
}
