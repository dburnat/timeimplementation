using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImplementacjaTime;

namespace ImplementacjaTime.Tests
{
    [TestClass]
    public class TimePeriodUnit
    {

        [DataTestMethod]
        [DataRow(0, 0, 0, 0, 0, 0)]

        public void OperatorEquals(long l1, long l2, long l3, long l4, long l5, long l6)
        {
            TimePeriod time1 = new TimePeriod(l1, l2, l3);
            TimePeriod time2 = new TimePeriod(l4, l5, l6);

            Assert.IsTrue(time1.Equals(time2));

        }

        [DataTestMethod]
        [DataRow(0, 0, 0, 0, 0, 0)]

        public void OperatorRownaSie(long l1, long l2, long l3, long l4, long l5, long l6)
        {
            TimePeriod time1 = new TimePeriod(l1, l2, l3);
            TimePeriod time2 = new TimePeriod(l4, l5, l6);

            Assert.IsTrue(time1 == time2);

        }
        [DataTestMethod]
        [DataRow(1, 0, 0, 0, 0, 0)]

        public void OperatorNieRownaSie(long l1, long l2, long l3, long l4, long l5, long l6)
        {
            TimePeriod time1 = new TimePeriod(l1, l2, l3);
            TimePeriod time2 = new TimePeriod(l4, l5, l6);

            Assert.IsTrue(time1 != time2);

        }

        [DataTestMethod]
        [DataRow(1, 0, 0, 0, 0, 0)]

        public void OperatorWieksze(long l1, long l2, long l3, long l4, long l5, long l6)
        {
            TimePeriod time1 = new TimePeriod(l1, l2, l3);
            TimePeriod time2 = new TimePeriod(l4, l5, l6);

            Assert.IsTrue(time1 > time2);

        }

        [DataTestMethod]
        [DataRow(1, 0, 0, 0, 0, 0)]
        [DataRow(0, 0, 0, 0, 0, 0)]
        public void OperatorWiekszeLubRowne(long l1, long l2, long l3, long l4, long l5, long l6)
        {
            TimePeriod time1 = new TimePeriod(l1, l2, l3);
            TimePeriod time2 = new TimePeriod(l4, l5, l6);

            Assert.IsTrue(time1 >= time2);

        }

        [DataTestMethod]
        [DataRow(1, 0, 0, 2, 0, 0)]

        public void OperatorMniejsze(long l1, long l2, long l3, long l4, long l5, long l6)
        {
            TimePeriod time1 = new TimePeriod(l1, l2, l3);
            TimePeriod time2 = new TimePeriod(l4, l5, l6);

            Assert.IsTrue(time1 < time2);

        }
        [DataTestMethod]
        [DataRow(1, 0, 0, 2, 0, 0)]
        [DataRow(2, 0, 0, 2, 0, 0)]
        public void OperatorMniejszeLubRowne(long l1, long l2, long l3, long l4, long l5, long l6)
        {
            TimePeriod time1 = new TimePeriod(l1, l2, l3);
            TimePeriod time2 = new TimePeriod(l4, l5, l6);

            Assert.IsTrue(time1 <= time2);

        }

       


    }


}
