using System;
using AbstracFactory.AbstractFactory;
using AbstracFactory.AbstractFactoryDemo;

namespace AbstracFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String selection = Console.ReadLine();
            AbstractCourse course = CourseFactory.CreateCourse(selection);
            course.DisplayCourseDetails(); String courseName = Console.ReadLine();
            var offlineCourseFactory = new OnlineCourseFactory();
            AbstractCourse abstractCourse = offlineCourseFactory.CreateCourse(courseName);
            abstractCourse.DisplayCourseDetails();


            courseName = Console.ReadLine();
            var onlineCourseFactory = new OnlineCourseFactory();
            abstractCourse = onlineCourseFactory.CreateCourse(courseName);
            abstractCourse.DisplayCourseDetails();


            Console.ReadKey();
        }

    }
}
