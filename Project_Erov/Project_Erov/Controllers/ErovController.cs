using Microsoft.AspNetCore.Mvc;
using ShanyGoldvaserProject.Entities;
using ShanyGoldvaserProject.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShanyGoldvaserProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErovController : ControllerBase
    {
        readonly Services.ErovService _erovService = new();
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<Erov>> Get()
        {
            return _erovService.GetErov();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<Erov> Get(int id)
        {
            if (id < 0)
            {
               return NotFound();
            }
            var res = _erovService.GetErovId(id);
            if (res == null)
            {
                return NotFound(res);
            }
            return res;

        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Erov value)
        {
            bool res = _erovService.AddErov(value);

            if (res)
            {
                return res;
            }
            return NotFound(res);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Erov value)
        {
            bool res = _erovService.UpdateErov(id, value);

            if (res)
            {
                return res;
            }
            return NotFound(res);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (id < 0)
                return NotFound();
            bool res = _erovService.DeleteErov(id);

            if (res)
            {
                return Ok(res);
            }
            return NotFound(res);

        }
    }
}

