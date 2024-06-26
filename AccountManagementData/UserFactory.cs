﻿using ParkingManagementModels;

namespace ParkingManagementData
{
    public class UserFactory
    {
        private List<User> dummyUsers = new List<User>();

        public List<User> GetDummyUsers()
        {
            dummyUsers.Add(CreateDummyUser("Admin123!", "Admin", "Admin@pup.com"));
            dummyUsers.Add(CreateDummyUser("Test123!", "Test", "Test@pup.com"));
            dummyUsers.Add(CreateDummyUser("Hello123!", "Hello", "Hello@pup.com"));
            dummyUsers.Add(CreateDummyUser("Bye123!", "Bye", "Bye@pup.com"));

            return dummyUsers;
        }

        private User CreateDummyUser(string colorNum, string name, string emailaddress)
        {
            User user = new User
            {
                name = name,
                colorNum = colorNum,
                profile = new UserProfile { emailAddress = emailaddress, profileName = name },
                dateUpdated = DateTime.Now,
                dateVerified = DateTime.Now.AddDays(1),
                status = 1
            };

            return user;
        }

    }
}