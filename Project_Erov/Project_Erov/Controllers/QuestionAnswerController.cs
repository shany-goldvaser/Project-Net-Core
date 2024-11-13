using Microsoft.AspNetCore.Mvc;
using Project_Erov.Entities;
using Project_Erov.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project_Erov.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionAnswerController : ControllerBase
    {
        readonly QuestionAnswerService _questionAnswerService = new();
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<QuestionAnswer>> Get()
        {
            return _questionAnswerService.GetQuestionAnswer();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<QuestionAnswer> Get(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }
            var res = _questionAnswerService.GetQuestionAnswerId(id);
            if (res == null)
            {
                return NotFound(res);
            }
            return res;

        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] QuestionAnswer value)
        {
            bool res = _questionAnswerService.AddQuestionAnswer(value);

            if (res)
            {
                return res;
            }
            return NotFound(res);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] QuestionAnswer value)
        {
            bool res = _questionAnswerService.UpdateQuestionAnswer(id, value);

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
            bool res = _questionAnswerService.DeleteQuestionAnswer(id);
            if (id < 0)
                return NotFound();
            if (res)
            {
                return res;
            }
            return NotFound(res);

        }
    }
}

