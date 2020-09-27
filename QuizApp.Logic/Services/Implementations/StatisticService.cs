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
    public class StatisticService : IStatisticService
    {
        private readonly IGenericRepository<Statistic> _statisticRepository;
        public StatisticService()
        {
            _statisticRepository = new GenericRepository<Statistic>();
        }

        public bool Add(StatisticModel item)
        {
            bool added;
            if (item != null)
            {
                Statistic statistic = new Statistic()
                {
                    StatisticID = item.StatisticID,
                    UserID = item.UserID,
                    TestID = item.TestID,
                    CorrectAnswer = item.CorrectAnswer,
                    Passed = item.Passed,
                    QuestionsTotal = item.QuestionsTotal
                };

                _statisticRepository.Add(statistic);
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
                _statisticRepository.Delete(id);
                deleted = true;
            }
            else
            {
                deleted = false;
            }
            return deleted;
        }

        public StatisticModel Get(int id)
        {
            if (id < 1)
            {
                return null;
            }
            else
            {
                var statistic = _statisticRepository.GetById(id);
                return new StatisticModel()
                {
                    StatisticID = statistic.StatisticID,
                    UserID = statistic.UserID,
                    TestID = statistic.TestID,
                    CorrectAnswer = statistic.CorrectAnswer,
                    Passed = statistic.Passed,
                    QuestionsTotal = statistic.QuestionsTotal
                };
            }
        }

        public IEnumerable<StatisticModel> GetAll()
        {
            return _statisticRepository.GetAll()
                   .Select(statistic => new StatisticModel
                   {
                       StatisticID = statistic.StatisticID,
                       UserID = statistic.UserID,
                       TestID = statistic.TestID,
                       CorrectAnswer = statistic.CorrectAnswer,
                       Passed = statistic.Passed,
                       QuestionsTotal = statistic.QuestionsTotal
                   }).AsEnumerable();
        }

        public bool Update(StatisticModel item)
        {
            bool updated;
            if (item != null || item.StatisticID < 0)
            {
                Statistic statistic = new Statistic()
                {
                    StatisticID = item.StatisticID,
                    UserID = item.UserID,
                    TestID = item.TestID,
                    CorrectAnswer = item.CorrectAnswer,
                    Passed = item.Passed,
                    QuestionsTotal = item.QuestionsTotal
                };

                _statisticRepository.Update(statistic);
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
