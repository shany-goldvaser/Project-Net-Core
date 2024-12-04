using projectErov.Core.Entities;
using projectErov.Core.IRepository;
using projectErov.Core.IService;
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
     
            if (GetQuestionAnswerById(questionAnswer.Id) ==null)
                return _repQuestionAnswer.ToAdd(questionAnswer);
            return false;
        }

        public bool DeleteQuestionAnswer(int id)
        {
            if (GetQuestionAnswerById(id)!=null)
                return _repQuestionAnswer.ToDelete(id);
            return false;
        }

        public List<QuestionAnswerEntity> GetAllQuestionAnswer()
        {
            return _repQuestionAnswer.ToGetAll();
        }

        public QuestionAnswerEntity GetQuestionAnswerById(int id)
        {
            return _repQuestionAnswer.ToGetById(id);
        }

        public bool UpdateQuestionAnswer(int id, QuestionAnswerEntity questionAnswer)
        {
			if (GetQuestionAnswerById(id) != null)
				return _repQuestionAnswer.ToUpdate(id, questionAnswer);
            return AddQuestionAnswer(questionAnswer);

        }
    }
}
