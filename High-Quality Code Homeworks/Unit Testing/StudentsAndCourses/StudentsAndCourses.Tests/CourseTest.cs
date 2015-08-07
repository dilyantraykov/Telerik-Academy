namespace TestSchool
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseConstructorTestName()
        {
            string name = "Javascript";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, "Javascript");
        }

        [TestMethod]
        public void CourseConstructorTestListStudents()
        {
            string name = "Javascript";
            Student maria = new Student("Maria Petrova", 12345);
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.AddStudent(maria);
            Assert.IsTrue(course.Students.Contains(maria));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestNullValue()
        {
            string name = null;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameTestEmptyString()
        {
            string name = string.Empty;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        public void AddStudentTestOneStudent()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            course.AddStudent(maria);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        public void AddStudentTestTwoStudents()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.AddStudent(maria);
            course.AddStudent(petar);
            Assert.IsTrue(course.Students.Count == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentTestSameStudentTwoTimes()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            course.AddStudent(maria);
            course.AddStudent(maria);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentTestMoreThanMaximumStudents()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.AddStudent(new Student("Maria Petrova", 12345));
            course.AddStudent(new Student("Maria Petrova", 12346));
            course.AddStudent(new Student("Maria Gocheva", 12347));
            course.AddStudent(new Student("Maria Mihaylova", 12348));
            course.AddStudent(new Student("Maria Grozeva", 12349));
            course.AddStudent(new Student("Maria Toneva", 12350));
            course.AddStudent(new Student("Maria Gecheva", 12351));
            course.AddStudent(new Student("Maria Gacheva", 12352));
            course.AddStudent(new Student("Maria Donkova", 12353));
            course.AddStudent(new Student("Maria Vrankova", 12354));
            course.AddStudent(new Student("Maria Drakonova", 12355));
            course.AddStudent(new Student("Maria Bobeva", 12356));
            course.AddStudent(new Student("Maria Kateva", 12357));
            course.AddStudent(new Student("Maria Bonkova", 12358));
            course.AddStudent(new Student("Maria Kolova", 12359));
            course.AddStudent(new Student("Maria Simova", 12360));
            course.AddStudent(new Student("Maria Koleva", 12361));
            course.AddStudent(new Student("Maria Popova", 12362));
            course.AddStudent(new Student("Maria Tsolova", 12363));
            course.AddStudent(new Student("Maria Doneva", 12364));
            course.AddStudent(new Student("Maria Dakova", 12365));
            course.AddStudent(new Student("Maria Makova", 12366));
            course.AddStudent(new Student("Maria Petkova", 12367));
            course.AddStudent(new Student("Maria Kamenova", 12368));
            course.AddStudent(new Student("Maria Vuchkova", 12369));
            course.AddStudent(new Student("Maria Komnina", 12370));
            course.AddStudent(new Student("Maria Burdina", 12371));
            course.AddStudent(new Student("Maria Hristova", 12372));
            course.AddStudent(new Student("Petar Marinov", 23445));
            course.AddStudent(new Student("Petar Krastev", 23446));
        }

        [TestMethod]
        public void RemoveStudentTest()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.AddStudent(maria);
            course.AddStudent(petar);
            course.RemoveStudent(petar);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingStudentTest()
        {
            string name = "Javascript";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student maria = new Student("Maria Petrova", 12345);
            course.RemoveStudent(maria);
        }

        [TestMethod]
        public void ToStringTestOneStudent()
        {
            string name = "Javascript";
            Student maria = new Student("Maria Petrova", 12345);
            IList<Student> students = new List<Student>();
            Course javascript = new Course(name, students);
            javascript.AddStudent(maria);
            string expected = "Course name Javascript; Student Maria Petrova, ID 12345; ";
            string actual;
            actual = javascript.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringTestTwoStudents()
        {
            string name = "Javascript";
            Student maria = new Student("Maria Petrova", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            IList<Student> students = new List<Student>();
            Course javascript = new Course(name, students);
            javascript.AddStudent(maria);
            javascript.AddStudent(petar);
            string expected = "Course name Javascript; Student Maria Petrova, ID 12345; Student Petar Marinov, ID 23445; ";
            string actual;
            actual = javascript.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}