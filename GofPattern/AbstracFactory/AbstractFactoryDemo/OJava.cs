using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstracFactory.AbstractFactoryDemo
{
    public class OJava : AbstractCourse
    {
        public OJava()
        {
            Name = "Online Java";
            Duraion = 2.00;
        }
        public override void CreateCourseMaterial()
        {
            Console.WriteLine("Creating Online Course Material for Java");
        }

        public override void CreateCourseSchedule()
        {
            Console.WriteLine("Creating Online Course Schedule for Java");
        }

        public override void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name:{0} Duration:{1} hour", Name, Duraion);
        }
    }
}
