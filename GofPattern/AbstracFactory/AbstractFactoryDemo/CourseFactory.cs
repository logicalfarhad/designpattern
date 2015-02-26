using System;

namespace AbstracFactory.AbstractFactoryDemo
{
    public class CourseFactory
    {
        public static AbstractCourse CreateCourse(String courseName)
        {
            AbstractCourse abstractCourse = null;
            if (courseName.Equals("ONet", StringComparison.OrdinalIgnoreCase))
            {
                abstractCourse = new ONet();
            }
            else if (courseName.Equals("OJava", StringComparison.OrdinalIgnoreCase))
            {
                abstractCourse = new OJava();
            }
            else if (courseName.Equals("CJava", StringComparison.OrdinalIgnoreCase))
            {
                abstractCourse = new CJava();
            }
            else if (courseName.Equals("CNet", StringComparison.OrdinalIgnoreCase))
            {
                abstractCourse = new CNet();
            }
            abstractCourse.CreateCourseMaterial();
            abstractCourse.CreateCourseSchedule();
            return abstractCourse;
        }
    }
}
