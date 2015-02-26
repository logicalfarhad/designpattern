using System.Collections.Generic;
using System.Linq;

namespace NullObjectPattern.Helper
{
    public class UserRepository
    {
        public static IUser GetUserRoleByName(string name)
        {
            List<User> userList = PopulateUserList();

            User user = (from p in userList
                         where p.Name == name
                         select p).FirstOrDefault();
            if (user == null)
            {
                return new NullUser();
            }
            return user;
        }



        private static List<User> PopulateUserList()
        {
            List<User> userList = new List<User>();

            userList.Add(new User()
            {
                Name = "forhad",
                Roll = "bit0213"
            });

            return userList;
        }
    }
}