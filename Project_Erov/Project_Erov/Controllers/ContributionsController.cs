using Microsoft.AspNetCore.Mvc;
using ShanyGoldvaserProject.Entities;
using ShanyGoldvaserProject.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShanyGoldvaserProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContributionsController : ControllerBase
    {
        readonly ContributionsService _contributionsService = new();
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<Contributions>> Get()
        {
            return _contributionsService.GetContributions();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<Contributions> Get(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }
            var res = _contributionsService.GetContributionsId(id);
            if (res == null)
            {
                return NotFound(res);
            }
            return res;

        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Contributions value)
        {
            bool res = _contributionsService.AddContributions(value);
            if (res)
            {
                return res;
            }
            return NotFound(res);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Contributions value)
        {
            bool res = _contributionsService.UpdateContributions(id, value);

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
            bool res = _contributionsService.DeleteContributions(id);

            if (res)
            {
                return res;
            }
            return NotFound(res);
        }
    }
}


