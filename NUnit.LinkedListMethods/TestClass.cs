using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShaKyList;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestConstructor()
        {
            ShaKyList temp = new ShaKyList();
            ShaKyList tempData = temp;

            Assert.That(temp == tempData);
        }

        [Test]
        public void TestResistNullInsert()
        {
            ShaKyList temp = new ShaKyList();
            temp.Insert(null, 0);

            Assert.AreEqual(0, temp.Count);
        }

        [Test]
        public void TestStringInsert()
        {
            ShaKyList temp = new ShaKyList();
            string x = "Hello World";
            temp.Insert(x, 0);

            Assert.AreEqual(x, temp[0]);
        }

        [Test]
        public void TestIntInsert()
        {
            ShaKyList temp = new ShaKyList();
            int x = 10;
            temp.Insert(x, 0);

            Assert.AreEqual(x, temp[0]);
        }

        [Test]
        public void TestDoubleInsert()
        {
            ShaKyList temp = new ShaKyList();
            double x = 10.23;
            temp.Insert(x, 0);

            Assert.AreEqual(x, temp[0]);
        }

        [Test]
        public void TestFloatInsert()
        {
            ShaKyList temp = new ShaKyList();
            float x = 10.234f;
            temp.Insert(x, 0);

            Assert.AreEqual(x, temp[0]);
        }

        [Test]
        public void TestRemoveAt()
        {
            ShaKyList temp = new ShaKyList() { 1, 2 };
            temp.RemoveAt(1);

            Assert.AreEqual(1, temp.Count);
        }

        [Test]
        public void TestContainsTrue()
        {
            ShaKyList temp = new ShaKyList() { 10 };

            Assert.AreEqual(true, temp.Contains(10));

        }

        [Test]
        public void TestContainsFalse()
        {
            ShaKyList temp = new ShaKyList() { 10 };

            Assert.AreEqual(false, temp.Contains(15));

        }
    }
}
