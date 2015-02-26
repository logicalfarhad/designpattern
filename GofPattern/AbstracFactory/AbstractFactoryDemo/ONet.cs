using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstracFactory.AbstractFactoryDemo
{
    public class ONet : AbstractCourse
    {
        public ONet()
        {
            Name = "Online .Net";
            Duraion = 1.30;
        }
        public override void CreateCourseMaterial()
        {
            Console.WriteLine("Creating Online Course Material for .NET");
        }
        public override void CreateCourseSchedule()
        {
            Console.WriteLine("Creating Online Course Schedule for .NET");
        }
        public override void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name:{0} Duration:{1} hour", Name, Duraion);
        }
    }
}
