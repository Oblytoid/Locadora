using Locadora.src.model;
using Locadora.src.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.controller
{
    class UserController
    {
        static UserRepository userRepository = new UserRepository();

        public static bool RegisterUser(User user)
        {
            userRepository.SaveUser(user);
            return true;
        }

        public static void DeleteUser(User user)
        {
            userRepository.DeleteUser(user);
        }

        public static void UpdateUser(User user, bool saveImage)
        {
            userRepository.UpdateUser(user, saveImage);
        }

        public static List<User> GetAllUsers(bool filter = false, string search = "")
        {
            return userRepository.GetUsers(filter, search);
        }

        public static User GetUser(int id)
        {
            return userRepository.GetUserById(id);
        }
    }
}
