﻿using WashingManagementData;
using WashingManagementModels;

namespace WashingManagementServices
{
    public class UserTransactionServices
    {
        UserValidationServices validationServices = new UserValidationServices();
        UserData userData = new UserData();

        public bool CreateUser(User user)
        {
            bool result = validationServices.CheckIfUserNameExists(user.name);

            if (result)
            {
                userData.AddUser(user);
            }

            return result ;
        }

        public bool UpdateUser(User user)
        {
            bool result = validationServices.CheckIfUserNameExists(user.name);

            if (result)
            {
                userData.UpdateUser(user);
            }

            return result;
        }


    }
}
