using QuizApp.Logic.Models;
using QuizApp.Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Services.Implementations
{
    public class TestService : ITestService
    {
        public bool Add(TestModel item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TestModel item)
        {
            throw new NotImplementedException();
        }

        public TestModel Get(TestModel item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TestModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
