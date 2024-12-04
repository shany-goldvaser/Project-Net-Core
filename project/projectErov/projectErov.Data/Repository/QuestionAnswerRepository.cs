using Microsoft.IdentityModel.Tokens;
using projectErov.Core.Entities;
using projectErov.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Data.Repository
{
    public class QuestionAnswerRepository : IRepository<QuestionAnswerEntity>
    {
        readonly DataContext _dataContext;
        public QuestionAnswerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool ToAdd(QuestionAnswerEntity t)
        {
            try
            {
                _dataContext.QuestionAnswerList.Add(t);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ToDelete(int id)
        {
            try
            {
                QuestionAnswerEntity q = _dataContext.QuestionAnswerList.Find(id);
                if (q == null)
                    return false;
                _dataContext.QuestionAnswerList.Remove(q);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<QuestionAnswerEntity> ToGetAll()
        {
            return _dataContext.QuestionAnswerList.ToList();
        }

        public QuestionAnswerEntity ToGetById(int id)
        {
            return _dataContext.QuestionAnswerList.FirstOrDefault(t => t.Id == id);
        }
        public bool ToUpdate(int id, QuestionAnswerEntity t)
        {
            try
            {
                QuestionAnswerEntity q = _dataContext.QuestionAnswerList.Find(id);
                if (q == null)
                    return false;
                q.Answer = t.Answer.IsNullOrEmpty() ? q.Answer : t.Answer;
                q.Question = t.Question.IsNullOrEmpty() ? q.Question : t.Question;
                q.NameAsker = t.NameAsker.IsNullOrEmpty() ? q.NameAsker : t.NameAsker;
                q.IdRav = t.IdRav == 0 ? q.IdRav : t.IdRav;
                q.DateUpdate = t.DateUpdate == null ? q.DateUpdate : t.DateUpdate;

				_dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
