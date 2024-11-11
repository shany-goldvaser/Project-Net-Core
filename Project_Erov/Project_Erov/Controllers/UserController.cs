using Microsoft.AspNetCore.Mvc;
using ShanyGoldvaserProject.Entities;
using ShanyGoldvaserProject.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace ShanyGoldvaserProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly UserService _userService = new();
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return Ok(_userService.GetUsers());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var res = _userService.GetUsersId(id);
            if (res==null)
            {
               return NotFound(res); 
            }
            return res;

        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] User value)
        {
            bool res = _userService.AddUsers(value);
            if (res)
            {
                return Ok(res);
            }
            return NotFound(res);
        }
        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] User value)
        {
            if (id < 0)
                return false;
            bool res = _userService.UpdateUsers(id, value);

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
            bool res = _userService.DeleteUsers(id);

            if (res)
            {
                return res;
            }
            return NotFound(res);

        }
    }
}
