using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstracFactory.AbstractFactoryDemo
{
    public class OfflineCourseFactory : AbstractCourseFactory
    {
        protected override AbstractCourse GetCourse(string courseName)
        {
            AbstractCourse abstractCourse = null;
            if (courseName.Equals("CJava", StringComparison.OrdinalIgnoreCase))
            {
                abstractCourse = new CJava();
            }
            else if (courseName.Equals("CNet", StringComparison.OrdinalIgnoreCase))
            {
                abstractCourse = new CNet();
            }
            return abstractCourse;
        }
    }
}
