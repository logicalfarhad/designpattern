using System;

namespace NullObjectPattern.Helper
{
    public class User : IUser
    {
        public String Name { get; set; }
        public String Roll { get; set; }
        public string GetUserRole()
        {
            return Roll;
        }
    }
}