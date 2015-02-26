using System;

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();


            person.Name = "Person";
            person.Email = "xyz@mail.com";
            person.Address.Street = "221B";


            Person person1 = person.Clone() as Person;
            person1.Name = "Person";
            person1.Email = "xyz@mail.com";
            person1.Address.Street = "221B Baker Street";


            Console.WriteLine("Before Cloning.......");
            Console.WriteLine("Name:{0} and Email:{1}, Street:{2}", person.Name, person.Email, person.Address.Street);

            Console.WriteLine("After Cloning.......");
            Console.WriteLine("Name:{0} and Email:{1}, Street:{2}", person1.Name, person1.Email, person1.Address.Street);
        }
    }
}
