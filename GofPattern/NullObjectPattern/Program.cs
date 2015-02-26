using System;
using NullObjectPattern.Helper;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser user = UserRepository.GetUserRoleByName("zodu");
            String role = user.GetUserRole();
            Console.WriteLine(role);
        }
    }
}
