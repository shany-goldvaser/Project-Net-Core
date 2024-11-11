using Microsoft.AspNetCore.Mvc;
using ShanyGoldvaserProject.Controllers;
using ShanyGoldvaserProject.Entities;

namespace Unit_Test_Erov
{
    public class UnitTestContributes
    {
        [Fact]
        public void GetOk()
        {
            var res = new ContributionsController().Get();
            Assert.IsType<List<Contributions>>(res);
        }
        [Fact]
        public void GetByIdOk()
        {
            int id = -5;
            var res = new ContributionsController().Get(id);
            Assert.IsType<NotFoundResult>(res);
        }
        [Fact]
        public void PostOk()
        {
            Contributions c = new Contributions();
            c.Sum = 100;
            var res = new ContributionsController().Post(c);
            Assert.Equal(true, res);
        }
        [Fact]
        public void PutOk()
        {
            Contributions c = new Contributions();
            c.Id = -5;
            var res = new ContributionsController().Put(c.Id, c);
            Assert.IsType<NotFoundResult>(res);
        }

        [Fact]
        public void DeleteOk()
        {
            int id = -5;
            var res = new ContributionsController().Delete(id);
            Assert.IsType<NotFoundResult>(res);
        }
    }
}