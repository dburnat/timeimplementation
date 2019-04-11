using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementacjaTime.Tests
{
    [TestClass]
    public class TimePeriodRelations
    {
        public void OperatorPlus(long b1, long b2, long b3, long b4, long b5, long b6, long b7, long b8, long b9)
        {
            TimePeriod time1 = new TimePeriod(b1, b2, b3);
            TimePeriod time2 = new TimePeriod(b4, b5, b6);
            TimePeriod time3 = new TimePeriod(b7, b8, b9);

            Assert.IsTrue(time1 + time2 == time3);
        }

        [DataTestMethod]
        [DataRow(0, 0, 0, 0, 0, 0, 0, 0, 0)]
        [DataRow(10, 0, 0, 11, 0, 0, -1, 0, 0)]
        [DataRow(12, 20, 0, 0, 21, 0, 11, 59, 0)]
        [DataRow(12, 20, 0, 0, 0, 2, 12, 19, 58)]
        [DataRow(12, 20, 0, 0, 21, 02, 11, 58, 58)]


        public void OperatorMinus(long b1, long b2, long b3, long b4, long b5, long b6, long b7, long b8, long b9)
        {
            TimePeriod time1 = new TimePeriod(b1, b2, b3);
            TimePeriod time2 = new TimePeriod(b4, b5, b6);
            TimePeriod time3 = new TimePeriod(b7, b8, b9);

            Assert.IsTrue(time1 - time2 == time3);
        }

        [DataTestMethod]
        [DataRow(22, 0, 0, 12, 0, 0, 34, 0, 0)]

        public void TimePeriodPlus(long b1, long b2, long b3, long b4, long b5, long b6, long b7, long b8, long b9)
        {
            TimePeriod time1 = new TimePeriod(b1, b2, b3);
            TimePeriod time2 = new TimePeriod(b4, b5, b6);
            TimePeriod time3 = new TimePeriod(b7, b8, b9);

            Assert.IsTrue(time1.Plus(time2) == time3);
        }

        [DataTestMethod]
        [DataRow(10, 0, 0, 13, 0, 0, 23, 0, 0)]

        public void TimePeriodPlusTimePerios(long b1, long b2, long b3, long b4, long b5, long b6, long b7, long b8, long b9)
        {
            TimePeriod time1 = new TimePeriod(b1, b2, b3);
            TimePeriod time2 = new TimePeriod(b4, b5, b6);
            TimePeriod time3 = new TimePeriod(b7, b8, b9);

            Assert.IsTrue(TimePeriod.Plus(time1, time2) == time3);
        }
    }
}
