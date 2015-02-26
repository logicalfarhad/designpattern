using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstracFactory.AbstractFactoryDemo
{
    public class CorporateCourseFactory
    {
        public static AbstractCourse CreateCourse(string selection)
        {
            AbstractCourse course = null;
            if (selection == "CJavaCourse")
            {
                course = new CJavaCourse();
            }
            else if (selection == "CNetCourse")
            {
                course = new CNetCourse();
            }
            return course;
        }
    }

}
