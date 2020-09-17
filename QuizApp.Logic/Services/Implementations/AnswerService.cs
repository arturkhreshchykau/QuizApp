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
    public class AnswerService : IService<AnswerModel>
    {
        private readonly IGenericRepository<Answer> _answerRepository;
        public AnswerService()
        {
            _answerRepository = new GenericRepository<Answer>();
        }

        public bool Add(AnswerModel item)
        {
            bool added;
            if (item != null)
            {
                Answer answer = new Answer()
                {
                    QuestionID = item.QuestionID,
                    AnswerText = item.AnswerText,
                    isCorrect = item.isCorrect
                };

                _answerRepository.Add(answer);
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
                _answerRepository.Delete(id);
                deleted = true;
            }
            else
            {
                deleted = false;
            }
            return deleted;
        }

        public AnswerModel Get(int id)
        {
            if (id < 1)
            {
                return null;
            }
            else
            {
                var answer = _answerRepository.GetById(id);
                return new AnswerModel()
                {
                    AnswerID = answer.AnswerID,
                    QuestionID = answer.QuestionID,
                    AnswerText = answer.AnswerText,
                    isCorrect = answer.isCorrect
                };
            }
        }

        public IEnumerable<AnswerModel> GetAll()
        {
            return _answerRepository.GetAll()
                   .Select(answer => new AnswerModel()
                   {
                       AnswerID = answer.AnswerID,
                       QuestionID = answer.QuestionID,
                       AnswerText = answer.AnswerText,
                       isCorrect = answer.isCorrect
                   }).AsEnumerable();
        }

        public bool Update(AnswerModel item)
        {
            bool updated;
            if (item != null || item.QuestionID < 0)
            {
                Answer answer = new Answer()
                {
                    AnswerID = item.AnswerID,
                    QuestionID = item.QuestionID,
                    AnswerText = item.AnswerText,
                    isCorrect = item.isCorrect
                };

                _answerRepository.Update(answer);
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
