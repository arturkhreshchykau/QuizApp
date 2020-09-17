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
    public class TestService : ITestService
    {
        private readonly IGenericRepository<Test> _testRepository;
        public TestService()
        {
            _testRepository = new GenericRepository<Test>();
        }
        public bool Add(TestModel item)
        {
            bool added;
            if (item != null)
            {
                Test test = new Test()
                {
                    TestName = item.TestName,
                    CategoryID = item.CategoryID,
                    Timer = item.Timer,
                    isLiveCheck = item.isLiveCheck,
                };

                _testRepository.Add(test);
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
                _testRepository.Delete(id);
                deleted = true;
            }
            else
            {
                deleted = false;
            }
            return deleted;
        }

        public TestModel Get(int id)
        {
            if (id < 1)
            {
                return null;
            }
            else
            {
                var test = _testRepository.GetById(id);
                return new TestModel()
                {
                    TestID = test.TestID,
                    TestName = test.TestName,
                    CategoryID = test.CategoryID,
                    Timer = test.Timer,
                    isLiveCheck = test.isLiveCheck,
                };
            }
        }

        public IEnumerable<TestModel> GetAll()
        {
            return _testRepository.GetAll()
                .Select(test => new TestModel {
                    TestID = test.TestID,
                    TestName = test.TestName,
                    CategoryID = test.CategoryID,
                    Timer = test.Timer,
                    isLiveCheck = test.isLiveCheck,
                }).AsEnumerable();
        }

        public bool Update(TestModel item)
        {
            bool updated;
            if (item != null && item.TestID > 0 )
            {
                Test test = new Test()
                {
                    TestID = item.TestID,
                    TestName = item.TestName,
                    CategoryID = item.CategoryID,
                    Timer = item.Timer,
                    isLiveCheck = item.isLiveCheck
                };

                _testRepository.Update(test);
                updated = true;
            }
            else
            {
                updated = false;
            }

            return updated;
        }
    }
}
