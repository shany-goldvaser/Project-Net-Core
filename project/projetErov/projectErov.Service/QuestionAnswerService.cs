using projetErov.Core.Entities;
using projetErov.Core.IRepository;
using projetErov.Core.IService;
using System.Collections.Generic;

namespace projectErov.Service
{
    public class QuestionAnswerService : IQuestionAnswerService
    {
       readonly IRepository<QuestionAnswerEntity> _repQuestionAnswer;

        public QuestionAnswerService(IRepository<QuestionAnswerEntity> repQuestionAnswer)
        {
            _repQuestionAnswer = repQuestionAnswer;
        }

        public bool AddQuestionAnswer(QuestionAnswerEntity questionAnswer)
        {
     
            if (GetQuestionAnswerByIdIndex(questionAnswer.Id) < 0)
                return _repQuestionAnswer.Add(questionAnswer);
            return false;
        }

        public bool DeleteQuestionAnswer(int id)
        {
            int i = GetQuestionAnswerByIdIndex(id);
            if (i >= 0)
                return _repQuestionAnswer.Delete(i);
            return false;
        }

        public List<QuestionAnswerEntity> GetAllQuestionAnswer()
        {
            return _repQuestionAnswer.GetAll();
        }

        public QuestionAnswerEntity GetQuestionAnswerById(int id)
        {
            return _repQuestionAnswer.GetById(id);
        }

        public int GetQuestionAnswerByIdIndex(int id)
        {
            return _repQuestionAnswer.GetIndexId(id);
        }

        public bool UpdateQuestionAnswer(int id, QuestionAnswerEntity questionAnswer)
        {
            int i = GetQuestionAnswerByIdIndex(id);
            if (i >= 0)
                return _repQuestionAnswer.Update(i, questionAnswer);
            return false;

        }
    }
}
