using Microsoft.AspNetCore.Mvc;
using projetErov.Core.Entities;
using projetErov.Core.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectErov.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErovController : ControllerBase
    {
        readonly IErovService _erovService;

        public ErovController(IErovService erovService)
        {
            _erovService = erovService;
        }

        // GET: api/<ErovController>
        [HttpGet]
        public ActionResult<IEnumerable<ErovEntity>> Get()
        {
            return _erovService.GetAllErov();
        }

        // GET api/<ErovController>/5
        [HttpGet("{id}")]
        public ActionResult<ErovEntity> Get(int id)
        {
            var res = _erovService.GetErovById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<ErovController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] ErovEntity value)
        {
            bool b = _erovService.AddErov(value);
            if (!b)
                return NotFound();
            return b;
        }

        // PUT api/<ErovController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] ErovEntity value)
        {
            bool b = _erovService.UpdateErov(id,value);
            if (!b)
                return NotFound();
            return b;
        }

        // DELETE api/<ErovController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = _erovService.DeleteErov(id);
            if (!b)
                return NotFound();
            return b;
        }
    }
}
