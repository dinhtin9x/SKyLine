using System;
using SkyLine.DataAccess;
using SkyLine.Models;

namespace SkyLine.BusinessLogic
{
    public class UserBL
    {
        UserDA userDA;
        public UserBL()
        {
            userDA = new UserDA();
        }

        /// <summary>
        /// Checks the login.
        /// </summary>
        /// <returns><c>true</c>, if login was checked, <c>false</c> otherwise.</returns>
        /// <param name="user">User.</param>
        public object CheckLogin(User user)
        {
            User userInfo;
            userInfo = userDA.CheckLogin(user);

            if (userInfo == null)
            {
                return new { isCorrect = false, message = "User name or password incorect!" };
            }
            else if(userInfo.FromDate != null && userInfo.ToDate != null && (userInfo.FromDate > DateTime.Now || userInfo.ToDate < DateTime.Now))
            {
                return new { isCorrect = false, message = "Account expired!" };
            }else
            {
                return userInfo;
            }
        }
    }
}
