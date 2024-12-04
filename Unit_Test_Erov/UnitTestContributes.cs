using Microsoft.AspNetCore.Mvc;
using Project_Erov.Controllers;
using Project_Erov.Entities;
using Project_Erov.Services;

namespace Unit_Test_Erov
{
    public class UnitTestContributes
    {
        [Fact]
        public void GetOk()
        {
            var res = new ContributionsController(new ContributionsService(new TestContext())).Get();
            Assert.IsType<List<Contributions>>(res);
        }
        [Fact]
        public void GetByIdOk()
        {
            int id = -5;
            var res = new ContributionsController(new ContributionsService(new TestContext())).Get(id);
            Assert.IsType<NotFoundResult>(res);
        }
        [Fact]
        public void PostOk()
        {
            Contributions c = new Contributions();
            c.Sum = 100;
            var res = new ContributionsController(new ContributionsService(new TestContext())).Post(c);
            Assert.IsType<ActionResult<bool>>(res);
        }
        [Fact]
        public void PutOk()
        {
            Contributions c = new Contributions();
            c.Id = -5;
            var res = new ContributionsController(new ContributionsService(new TestContext())).Put(c.Id, c);
            Assert.IsType<NotFoundResult>(res);
        }

        [Fact]
        public void DeleteOk()
        {
            int id = -5;
            var res = new ContributionsController(new ContributionsService(new TestContext())).Delete(id);
            Assert.IsType<NotFoundResult>(res);
        }
    }
}