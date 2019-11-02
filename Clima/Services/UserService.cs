using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clima.DataAccess;
using Clima.Models;

namespace Clima.Services
{
    public class UserService
    {
        private readonly UserDataServiceSingleton _dataService;

        public UserService(string connectionString)
        {
            _dataService = UserDataServiceSingleton.GetInstance(connectionString);
        }

        public string AddUser(User user)
        {
            try
            {
                return _dataService.AddUser(user) ? "User registered successfully." : "Error in registering user.";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        public User GetUser(string username, string password)
        {
            try
            {
                return _dataService.GetUser(username, password);
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public string Update(User user)
        {
            try
            {
                return _dataService.UpdateUser(user) ? "User updated successfully." : "Error in updating user.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public bool VerifyUser(string username, string email)
        {
            try
            {
                return _dataService.VerifyUser(username, email);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
