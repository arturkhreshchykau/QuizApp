using QuizApp.Data.App_Data;
using QuizApp.Logic.Interfaces;
using QuizApp.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic
{
    public class UserHelper : IUserHelper
    {
        public string UserName { get; set; }
        private readonly QuizDBEntities _quizDB;

        public UserHelper()
        {
            _quizDB = new QuizDBEntities();
        }

        public bool Exist(UserModel userModel)
        {
            bool exist = false;
            var res = _quizDB.Users.Where(x => x.UserName == userModel.Name).ToList();
            if (res.Count > 0)
            {
                exist = true;
            }
            return exist;
        }

        public void Add(UserModel userModel)
        {
            User user = new User() 
            {
                UserName = userModel.Name,
                UserPassword = userModel.Password
            };
            _quizDB.Users.Add(user);
            _quizDB.SaveChanges();
        }

        public bool GetUser(UserModel userModel)
        {
            bool exist = true;
            var user = _quizDB.Users.Where(x => x.UserName == userModel.Name
                        && x.UserPassword == userModel.Password)
                        .SingleOrDefault();
            if (user == null)
            {
                exist = false;
            }

            return exist;
        }
    }
}
