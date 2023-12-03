using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint6.Task1.V29.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startVal = -5;
            int stopVal = 5;
            int len = stopVal - startVal + 1;

            double[] WaitArray;
            WaitArray = new double[len];

            WaitArray[0] = -15.44;
            WaitArray[1] = -10.93;
            WaitArray[2] = -7.22;
            WaitArray[3] = -5.04;
            WaitArray[4] = 0;
            WaitArray[5] = -0.30;
            WaitArray[6] = 2.57;
            WaitArray[7] = 6.40;
            WaitArray[8] = 10.04;
            WaitArray[9] = 12.72;
            WaitArray[10] = 14.68;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startVal, stopVal);
            CollectionAssert.AreEqual(WaitArray, res);

        }
    }
}
