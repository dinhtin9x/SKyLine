using System;
using System.Collections.Generic;
using System.Linq;
using SkyLine.Models;

namespace SkyLine.DataAccess
{
    public class UserDA : DataAccessBase<User>
    {
        public UserDA() :base()
        {
        }

        public override int Add(User b)
        {
            throw new NotImplementedException();
        }

        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        public User CheckLogin(User user)
        {
            return ctx.Users.FirstOrDefault(b => b.UserName == user.UserName && b.Password == user.Password );
        }
    }
}
