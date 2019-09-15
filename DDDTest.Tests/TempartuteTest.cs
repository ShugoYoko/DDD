using System;
using DDD.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    [TestClass]
    public class TempartuteTest
    {
        [TestMethod]
        public void 小数点以下2けた丸め()
        {
            var t = new Temparture(12.3f);

            Assert.AreEqual(12.3f, t.Value);
            Assert.AreEqual("12.30", t.DisplayValue);
            Assert.AreEqual("12.30℃", t.DisplayValueWithUnit);
            Assert.AreEqual("12.30 ℃", t.DisplayValueWithUnitSpace);
        }

        [TestMethod]
        public void 濃度Equal()
        {
          

            var t1 = new Temparture(12.3f);
            var t2 = new Temparture(12.3f);

            Assert.AreEqual(true, t1.Equals(t2));
        }

        [TestMethod]
        public void 濃度値Equal()
        {


            var t1 = new Temparture(12.3f);
            var t2 = new Temparture(12.3f);

            Assert.AreEqual(true, t1==t2);
        }
    }
}
