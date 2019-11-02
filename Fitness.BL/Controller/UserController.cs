using Fitness.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fitness.BL.Controller
{
    /// <summary>
    /// User controller
    /// </summary>
    public class UserController : ControllerBase
    {
        private const string USERS_FILE_NAME = "users.dat";
        /// <summary>
        /// Application users
        /// </summary>
        public List<User> Users { get; }

        /// <summary>
        /// Current user
        /// </summary>
        public User CurrentUser { get; }

        /// <summary>
        /// Is new user
        /// </summary>
        public bool IsNewUser { get; } = false;

        /// <summary>
        /// Create a new user controller
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("User name cannot be null", nameof(userName));
            }

            Users = GetUsersData();
            CurrentUser = Users.SingleOrDefault(u => u.Name == userName);

            if (CurrentUser == null)
            {
                CurrentUser = new User(userName);
                Users.Add(CurrentUser);
                IsNewUser = true;
                Save();
            }
        }

        /// <summary>
        /// Get saved user list
        /// </summary>
        /// <returns></returns>
        private List<User> GetUsersData()
        {
            return Load<List<User>>(USERS_FILE_NAME) ?? new List<User>();
        }

        public void SetNewUserData(string genderName, DateTime birthDate, double weight = 1, double height = 1)
        {
            // Проверка

            CurrentUser.Gender = new Gender(genderName);
            CurrentUser.BirthDate = birthDate;
            CurrentUser.Weight = weight;
            CurrentUser.Height = height;
            Save();
        }

        /// <summary>
        /// Save user data
        /// </summary>
        public void Save()
        {
            Save(USERS_FILE_NAME, Users);
        }
    }
}
