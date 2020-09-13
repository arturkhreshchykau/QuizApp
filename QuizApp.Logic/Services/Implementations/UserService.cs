using QuizApp.Data.App_Data;
using QuizApp.Data.Repositories.Implementations;
using QuizApp.Data.Repositories.Interfaces;
using QuizApp.Logic.Models;
using QuizApp.Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Services.Implementations
{
    public class UserService : IUserService
    {
        private IGenericRepository<User> _userRepository;

        public UserService()
        {
            _userRepository = new GenericRepository<User>();
        }

        public bool Add(UserModel item)
        {
            bool added;
            if (item != null)
            {
                User user = new User()
                {
                    UserName = item.Name,
                    UserPassword = item.Password
                };

                _userRepository.Add(user);
                added = true;
            }
            else
            {
                added = false;
            }
            return added; 
        }

        public bool Delete(int id)
        {
            bool deleted;
            if (id > 0)
            {
                _userRepository.Delete(id);
                deleted = true;
            }
            else
            {
                deleted = false;
            }
            return deleted;
        }

        public UserModel Get(int id)
        {
            if (id < 1)
            {
                return null;
            }
            else
            {
                var user = _userRepository.GetById(id);
                return new UserModel()
                {
                    ID = user.UserID,
                    Name = user.UserName,
                    Password = user.UserPassword
                };
            }  
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _userRepository.GetAll().Select(user => new UserModel { ID = user.UserID, Name = user.UserName, Password = user.UserPassword }).AsEnumerable();
        }

        public bool LogIn(UserModel item)
        {
            var allUsers = GetAll().Where(x => x.Name == item.Name
                           && x.Password == item.Password)
                           .SingleOrDefault();

            bool login = false;
            if (allUsers != null)
                login = true;

            return login;
        }

        public bool Exist(UserModel item)
        {
            var user = GetAll().Where(x => x.Name == item.Name).SingleOrDefault();
            bool exist = false;
            if (user != null)
                exist = true;

            return exist;
        }
    }
}
