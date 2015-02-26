using System;

namespace MediatorPattern.Before
{
    public class UserOne : User
    {
        public UserOne(string name)
            : base(name)
        {
        }

        protected override void UserChecking()
        {
            foreach (User person in PersonList)
            {
                if (person.GetType() == typeof(UserTwo))//User will send message to UserTwo Only
                {
                    Console.WriteLine("From " + Name + ":" + Message);
                }

            }
        }
    }
}
