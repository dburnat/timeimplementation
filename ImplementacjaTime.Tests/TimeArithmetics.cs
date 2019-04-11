using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementacjaTime.Tests
{
    [TestClass]
    public class TimeArithmetics
    {
        [DataTestMethod]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)10, (byte)0, (byte)0, (byte)11, (byte)0, (byte)0, (byte)23, (byte)0, (byte)0)]
        [DataRow((byte)12, (byte)20, (byte)0, (byte)0, (byte)21, (byte)0, (byte)11, (byte)59, (byte)0)]
        [DataRow((byte)12, (byte)20, (byte)0, (byte)0, (byte)0, (byte)2, (byte)12, (byte)19, (byte)58)]
        [DataRow((byte)12, (byte)20, (byte)0, (byte)0, (byte)21, (byte)02, (byte)11, (byte)58, (byte)58)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)1, (byte)0, (byte)23, (byte)59, (byte)0)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)1, (byte)1, (byte)23, (byte)58, (byte)59)]

        public void OperatorMinus(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7, byte b8, byte b9)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);
            Time time3 = new Time(b7, b8, b9);

            Assert.IsTrue(time1 - time2 == time3);
        }

        [DataTestMethod]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)10, (byte)0, (byte)0, (byte)5, (byte)0, (byte)0, (byte)15, (byte)0, (byte)0)]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)12, (byte)0, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)12, (byte)0, (byte)0, (byte)11, (byte)0, (byte)0, (byte)23, (byte)0, (byte)0)]
        [DataRow((byte)12, (byte)0, (byte)50, (byte)1, (byte)0, (byte)10, (byte)13, (byte)1, (byte)0)]
        [DataRow((byte)12, (byte)50, (byte)50, (byte)0, (byte)10, (byte)10, (byte)13, (byte)1, (byte)0)]

        public void OperatorPlus(byte b1, byte b2, byte b3, byte b4, byte b5, byte b6, byte b7, byte b8, byte b9)
        {
            Time time1 = new Time(b1, b2, b3);
            Time time2 = new Time(b4, b5, b6);
            Time time3 = new Time(b7, b8, b9);

            Assert.IsTrue(time1 + time2 == time3);
        }

        [DataTestMethod]
        [DataRow((byte)0, (byte)0, (byte)0, 25, 0, 0, (byte)1, (byte)0, (byte)0)]
        public void OperatorPlusTimePeriod(byte b1, byte b2, byte b3, long b4, long b5, long b6, byte b7, byte b8, byte b9)
        {
            Time time1 = new Time(b1, b2, b3);
            TimePeriod time2 = new TimePeriod(b4, b5, b6);
            Time time3 = new Time(b7, b8, b9);

            Assert.IsTrue(time1.Plus(time2) == time3);
        }

        [DataTestMethod]
        [DataRow((byte)0, (byte)0, (byte)0, 25, 0, 0, (byte)1, (byte)0, (byte)0)]
        public void OperatorTimePlusTimePeriod(byte b1, byte b2, byte b3, long b4, long b5, long b6, byte b7, byte b8, byte b9)
        {
            Time time1 = new Time(b1, b2, b3);
            TimePeriod time2 = new TimePeriod(b4, b5, b6);
            Time time3 = new Time(b7, b8, b9);

            Assert.IsTrue(Time.Plus(time1, time2) == time3);
        }
    }
}
