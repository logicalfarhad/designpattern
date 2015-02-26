namespace AbstracFactory.AbstractFactoryDemo
{
    public abstract class AbstractCourseFactory
    {
        public AbstractCourse CreateCourse(string courseName)
        {
            AbstractCourse abstractCourse = GetCourse(courseName);
            abstractCourse.CreateCourseMaterial();
            abstractCourse.CreateCourseSchedule();
            return abstractCourse;
        }
        protected abstract AbstractCourse GetCourse(string courseName);
    }
}
