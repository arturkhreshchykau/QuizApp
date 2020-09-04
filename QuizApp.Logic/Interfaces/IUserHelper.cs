using QuizApp.Data.App_Data;
using QuizApp.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Interfaces
{
    public interface IUserHelper
    {
        bool Exist(UserModel user);
        bool GetUser(UserModel user);
        void Add(UserModel user);
    }
}
