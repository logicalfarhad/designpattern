using System;

namespace MediatorPattern.Before
{
    public class UserTwo : User
    {
        public UserTwo(string name)
            : base(name)
        {
        }

        protected override void UserChecking()
        {
            foreach (User person in PersonList)
            {
                if (person.GetType() == typeof(UserOne))
                {
                    Console.WriteLine("From " + Name + ":" + Message);
                }
            }
        }
    }
}
