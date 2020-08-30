using QuizApp.Data.App_Data;
using QuizApp.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic
{
    public static class LogicHelper
    {
        public static bool CreateNewAccount(Account account)
        {
            bool created = true;
            try
            {
                using (var db = new QuizDBEntities())
                {
                    var res = db.Users.Where(x => x.UserName == account.UserName).ToList();
                    if (res.Count > 0)
                    {
                        created = false;
                    }
                    else
                    {
                        User user = new User();
                        user.UserName = account.UserName;
                        user.UserPassword = account.UserPassword;
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                }
                return created;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool Login(Account account)
        {
            bool login = true;
            try
            {
                using (var db = new QuizDBEntities())
                {
                    var log = db.Users.Where(x => x.UserName == account.UserName
                            && x.UserPassword == account.UserPassword)
                            .SingleOrDefault();
                    if (log == null)
                        login = false;
                }
                return login;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
