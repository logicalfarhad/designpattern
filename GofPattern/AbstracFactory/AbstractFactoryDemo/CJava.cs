using System;

namespace AbstracFactory.AbstractFactoryDemo
{
    public class CJava : AbstractCourse
    {
        public CJava()
        {
            Name = "Offline Java";
            Duraion = 3.00;
        }
        public override void CreateCourseMaterial()
        {
            Console.WriteLine("Creating Offline Course Material for Java");
        }

        public override void CreateCourseSchedule()
        {
            Console.WriteLine("Creating Offline Course Schedule for Java");
        }

        public override void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name:{0} Duration:{1} hour", Name, Duraion);
        }
    }
}
