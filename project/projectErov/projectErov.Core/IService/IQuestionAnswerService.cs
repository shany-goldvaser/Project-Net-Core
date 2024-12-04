using projectErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Core.IService
{
    public interface IQuestionAnswerService
    {
        List<QuestionAnswerEntity> GetAllQuestionAnswer();
        QuestionAnswerEntity GetQuestionAnswerById(int id);
        bool AddQuestionAnswer(QuestionAnswerEntity questionAnswer);
        bool UpdateQuestionAnswer(int id, QuestionAnswerEntity questionAnswer);
        bool DeleteQuestionAnswer(int id);
    }
}

