using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_0_0()
        {
            //arange
            double x = 0;
            double expected = 0;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method1(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_05_0546()
        {
            //arange
            double x = 0.5;
            double expected = 0.546;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method2(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_1_0()
        {
            //arange
            double x = 1;
            double expected = 0;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method3(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_double_0_0()
        {
            //arange
            double x = 0;
            double expected = 0;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method1(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_double_05_1092()
        {
            //arange
            double x = 0.5;
            double expected = 1.092;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method2(x);
            actual = Math.Round(actual, 3);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_double_1_0()
        {
            //arange
            double x = 1;
            double expected = 0;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method3(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_3_0139()
        {
            //arange
            double x = 3;
            double expected = -0.14;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method1(x);
            actual = Math.Round(actual, 2);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_3_0143()
        {
            //arange
            double x = 3;
            double expected = -0.143;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method2(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_3_26()
        {
            //arange
            double x = 3;
            double expected = 26;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method3(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_double_3_52()
        {
            //arange
            double x = 3;
            double expected = 52;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method3(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
