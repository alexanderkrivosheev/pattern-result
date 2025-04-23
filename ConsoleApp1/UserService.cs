using Pattern.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UserService
    {
        public ResultValue<User> GetUserById(int userId) 
        {
            return ResultValue<User>.Failure("user not found");
        }
    }
}
