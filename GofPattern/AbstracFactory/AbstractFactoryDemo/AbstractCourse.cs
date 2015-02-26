using System;

namespace AbstracFactory.AbstractFactoryDemo
{
    public abstract class AbstractCourse
    {
        protected String Name { get; set; }
        protected Double Duraion { get; set; }
        public abstract void CreateCourseMaterial();
        public abstract void CreateCourseSchedule();
        public abstract void DisplayCourseDetails();
    }
}
