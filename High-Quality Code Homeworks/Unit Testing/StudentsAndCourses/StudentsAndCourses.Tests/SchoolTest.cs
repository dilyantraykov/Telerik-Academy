namespace TestSchool
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolClassTest
    {
        [TestMethod]
        public void SchoolConstructorTest()
        {
            List<Course> courses = new List<Course>();
            SchoolClass school = new SchoolClass(courses);
            Assert.IsNotNull(school);
        }

        [TestMethod]
        public void AddCourseTest()
        {
            List<Course> courses = new List<Course>();
            Course javascript = new Course("Javascript");
            SchoolClass school = new SchoolClass(courses);
            school.AddCourse(javascript);
            Assert.AreEqual(javascript.Name, school.Courses[0].Name);
        }

        [TestMethod]
        public void RemoveCourseTest()
        {
            List<Course> courses = new List<Course>();
            SchoolClass school = new SchoolClass(courses);
            Course javascript = new Course("Javascript");
            school.AddCourse(javascript);
            school.RemoveCourse(javascript);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingCourseTest()
        {
            List<Course> courses = new List<Course>();
            SchoolClass school = new SchoolClass(courses);
            Course javascript = new Course("Javascript");
            school.RemoveCourse(javascript);
        }
    }
}