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
    public class QuestionService : IQuestionService
    {
        private readonly IGenericRepository<Question> _questionRepository;
        public QuestionService()
        {
            _questionRepository = new GenericRepository<Question>();
        }

        public bool Add(QuestionModel item)
        {
            bool added;
            if (item != null)
            {
                Question question  = new Question()
                {
                    TestID = item.TestID,
                    QuestionName = item.QuestionName,
                    isOpen = item.isOpen
                };

                _questionRepository.Add(question);
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
                _questionRepository.Delete(id);
                deleted = true;
            }
            else
            {
                deleted = false;
            }
            return deleted;
        }

        public QuestionModel Get(int id)
        {
            if (id < 1)
            {
                return null;
            }
            else
            {
                var question = _questionRepository.GetById(id);
                return new QuestionModel()
                {
                    QuestionID = question.QuestionID,
                    TestID = question.TestID,
                    QuestionName = question.QuestionName,
                    isOpen = question.isOpen
                };
            }
        }

        public IEnumerable<QuestionModel> GetAll()
        {
            return _questionRepository.GetAll()
                   .Select(question => new QuestionModel { 
                       QuestionID = question.QuestionID,
                       TestID = question.TestID, 
                       QuestionName = question.QuestionName,
                       isOpen = question.isOpen 
                   }).AsEnumerable();
        }

        public bool Update(QuestionModel item)
        {
            bool updated;
            if (item != null || item.QuestionID < 0)
            {
                Question question = new Question()
                {
                    QuestionID = item.QuestionID,
                    TestID = item.TestID,
                    QuestionName = item.QuestionName,
                    isOpen = item.isOpen
                };

                _questionRepository.Update(question);
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
