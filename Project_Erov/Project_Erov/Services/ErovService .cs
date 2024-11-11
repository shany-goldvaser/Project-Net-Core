using ShanyGoldvaserProject.Entities;

namespace ShanyGoldvaserProject.Services
{
    public class ErovService
    {

        public List<Erov> GetErov()
        {
            if (DataContextManager.DataContext.ErovList == null)
            {
                DataContextManager.DataContext.ErovList = new List<Erov>();
            }
            return DataContextManager.DataContext.ErovList;
        }
        public Erov GetErovId(int id)
        {
            if (DataContextManager.DataContext.ErovList == null)
                return null;
            return DataContextManager.DataContext.ErovList.Find(e => e.Id == id);

        }
        public bool AddErov(Erov e)
        {
            if (DataContextManager.DataContext.ErovList == null)
            {
                DataContextManager.DataContext.ErovList = new List<Erov>();
            }
            DataContextManager.DataContext.ErovList.Add(e);
            return true;
        }
        public bool UpdateErov(int id, Erov e)
        {
            if (DataContextManager.DataContext.ErovList == null)
            {
                return false;
            }
            var index = DataContextManager.DataContext.ErovList.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                DataContextManager.DataContext.ErovList[index] = e;
                return true;
            }
            return false;
        }
        public bool DeleteErov(int id)
        {
            if (DataContextManager.DataContext.ErovList == null)
            {
                return false;
            }
            var item = DataContextManager.DataContext.ErovList.Find(ev => ev.Id == id);
            if (item != null)
            {
                DataContextManager.DataContext.ErovList.Remove(item);
                return true;
            }
            return false;
        }
    }
}

