using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern.Helper
{
    public class NullUser : IUser
    {
        public string GetUserRole()
        {
            return "No User";
        }
    }
}
