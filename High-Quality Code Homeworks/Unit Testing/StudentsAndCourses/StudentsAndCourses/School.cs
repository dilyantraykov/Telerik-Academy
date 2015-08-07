using System;
using System.Collections.Generic;

public class SchoolClass
{
    public SchoolClass(List<Course> courses = null)
    {
        this.Courses = new List<Course>();
    }

    public List<Course> Courses { get; set; }

    public void AddCourse(Course course)
    {
        this.Courses.Add(course);
    }

    public void RemoveCourse(Course course)
    {
        bool courseFound = false;
        for (int i = 0; i < this.Courses.Count; i++)
        {
            if (this.Courses[i].Name == course.Name)
            {
                courseFound = true;
                this.Courses.Remove(course);
            }
        }

        if (!courseFound)
        {
            throw new ArgumentException("There is not any course with this name.");
        }
    }
}