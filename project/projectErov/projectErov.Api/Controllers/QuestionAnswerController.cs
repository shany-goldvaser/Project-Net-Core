using Microsoft.AspNetCore.Mvc;
using projectErov.Core.Entities;
using projectErov.Core.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectErov.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionAnswerController : ControllerBase
    {

        readonly IQuestionAnswerService _qAService;

        public QuestionAnswerController(IQuestionAnswerService questionAnswerService)
        {
            _qAService = questionAnswerService;
        }

        // GET: api/<ErovController>
        [HttpGet]
        public ActionResult<IEnumerable<QuestionAnswerEntity>> Get()
        {
            return _qAService.GetAllQuestionAnswer();
        }

        // GET api/<ErovController>/5
        [HttpGet("{id}")]
        public ActionResult<QuestionAnswerEntity> Get(int id)
        {
            var res = _qAService.GetQuestionAnswerById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<ErovController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] QuestionAnswerEntity value)
        {
            bool b = _qAService.AddQuestionAnswer(value);
            if (!b)
                return NotFound();
            return b;
        }

        // PUT api/<ErovController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] QuestionAnswerEntity value)
        {
            bool b = _qAService.UpdateQuestionAnswer(id, value);
            if (!b)
                return NotFound();
            return b;
        }
        // DELETE api/<ErovController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = _qAService.DeleteQuestionAnswer(id);
            if (!b)
                return NotFound();
            return b;
        }
    }
}
