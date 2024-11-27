using projetErov.Core.Entities;
using projetErov.Core.IRepository;
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
        public bool Add(QuestionAnswerEntity t)
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

        public bool Delete(int index)
        {
            try
            {
                _dataContext.QuestionAnswerList.RemoveAt(index);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<QuestionAnswerEntity> GetAll()
        {
            return _dataContext.QuestionAnswerList;
        }

        public QuestionAnswerEntity GetById(int id)
        {
            return _dataContext.QuestionAnswerList.FirstOrDefault(t => t.Id == id);
        }

        public int GetIndexId(int id)
        {
           return _dataContext.QuestionAnswerList.FindIndex(t => t.Id == id);

        }

        public bool Update(int index, QuestionAnswerEntity t)
        {
            try
            {
                _dataContext.QuestionAnswerList[index]=t;
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
