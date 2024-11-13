using Project_Erov.Dto;
using Project_Erov.Entities;

namespace Project_Erov.Services
{
    public class QuestionAnswerService
    {
        public List<QuestionAnswer> GetQuestionAnswer()
        {
            if (DataContextManager.DataContext.QuestionAnswerList == null)
            {
                DataContextManager.DataContext.QuestionAnswerList = new List<QuestionAnswer>();
            }
            return DataContextManager.DataContext.QuestionAnswerList;
        }
        public QuestionAnswer GetQuestionAnswerId(int id)
        {
            if (DataContextManager.DataContext.QuestionAnswerList == null)
                return null;
            return DataContextManager.DataContext.QuestionAnswerList.Find(e => e.Id == id);

        }
        public bool AddQuestionAnswer(QuestionAnswer e)
        {
            if (DataContextManager.DataContext.QuestionAnswerList == null)
            {
                DataContextManager.DataContext.QuestionAnswerList = new List<QuestionAnswer>();
            }
            DataContextManager.DataContext.QuestionAnswerList.Add(e);
            return true;
        }
        public bool UpdateQuestionAnswer(int id, QuestionAnswer e)
        {
            if (DataContextManager.DataContext.QuestionAnswerList == null)
                return false;
            var index = DataContextManager.DataContext.QuestionAnswerList.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                DataContextManager.DataContext.QuestionAnswerList[index] = e;
                return true;
            }
            return false;
        }
        public bool DeleteQuestionAnswer(int id)
        {
            if (DataContextManager.DataContext.QuestionAnswerList == null)
            {
                return false;
            }
            var item = DataContextManager.DataContext.QuestionAnswerList.Find(ev => ev.Id == id);
            if (item != null)
            {
                DataContextManager.DataContext.QuestionAnswerList.Remove(item);
                return true;
            }
            return false;
        }
    }
}

