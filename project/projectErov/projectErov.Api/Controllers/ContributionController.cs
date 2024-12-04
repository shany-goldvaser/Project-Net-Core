using Microsoft.AspNetCore.Mvc;
using projectErov.Core.Entities;
using projectErov.Core.IService;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectErov.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContributionController : ControllerBase
    {
        readonly IContributeService _contributeService;
        public ContributionController(IContributeService contributeService)
        {
            _contributeService = contributeService;
        }
        // GET: api/<ContributionController>
        [HttpGet]
        public ActionResult<IEnumerable<ContributionsEntity>> Get()
        {
            return _contributeService.GetAllContributions();
        }

        // GET api/<ErovController>/5
        [HttpGet("{id}")]
        public ActionResult<ContributionsEntity> Get(int id)
        {
            var res = _contributeService.GetContributionsById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<ErovController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] ContributionsEntity value)
        {
            bool b = _contributeService.AddContributions(value);
            if (!b)
                return NotFound();
            return b;
        }

        // PUT api/<ErovController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] ContributionsEntity value)
        {
            bool b = _contributeService.UpdateContributions(id, value);
            if (!b)
                return NotFound();
            return b;
        }

        // DELETE api/<ErovController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = _contributeService.DeleteContributions(id);
            if (!b)
                return NotFound();
            return b;
        }
    }
}
