using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstracFactory.AbstractFactoryDemo
{
    public class OnlineCourseFactory : AbstractCourseFactory
    {
        protected override AbstractCourse GetCourse(string courseName)
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
            return abstractCourse;
        }
    }
}
