namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentConstructorTestName()
        {
            string name = "Maria Petrova";
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual(student.Name, "Maria Petrova");
        }

        [TestMethod]
        public void StudentConstructorTestUniqueNumber()
        {
            string name = "Maria Petrova";
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual(student.UniqueNumber, 12345);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        public void UniqueNumberTestStartValue()
        {
            string name = "Maria Petrova";
            int uniqueNumber = 10000;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void UniqueNumberTestEndValue()
        {
            string name = "Maria Petrova";
            int uniqueNumber = 99999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestStartValueMinusOne()
        {
            string name = "Maria Petrova";
            int uniqueNumber = 9999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestEndValuePlusOne()
        {
            string name = "Maria Petrova";
            int uniqueNumber = 100000;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestEndValuePlus10000()
        {
            string name = "Maria Petrova";
            int uniqueNumber = 109999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestZero()
        {
            string name = "Maria Petrova";
            int uniqueNumber = 0;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestIntMaxValue()
        {
            string name = "Maria Petrova";
            int uniqueNumber = int.MaxValue;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumberTestNegativeValue()
        {
            string name = "Maria Petrova";
            int uniqueNumber = -55555;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void ToStringTest()
        {
            string name = "Maria Petrova";
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            string expected = "Student Maria Petrova, ID 12345; ";
            string actual;
            actual = student.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}