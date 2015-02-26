using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AbstracFactory.AbstractFactoryDemo
{
    public class CNet : AbstractCourse
    {
        public CNet()
        {
            Name = "Offline .Net";
            Duraion = 2.30;

        }
        public override void CreateCourseMaterial()
        {
            Console.WriteLine("Creating Offline Course Material for .NET");
        }

        public override void CreateCourseSchedule()
        {
            Console.WriteLine("Creating Offline Course Schedule for .NET");
        }

        public override void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name:{0} Duration:{1} hour", Name, Duraion);
        }
    }
}
