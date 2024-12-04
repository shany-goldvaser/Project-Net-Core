using Microsoft.AspNetCore.Mvc;
using projectErov.Core.Entities;
using projectErov.Core.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectErov.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<ErovController>
        [HttpGet]
        public ActionResult<IEnumerable<UserEntity>> Get()
        {
            return _userService.GetAllUser();
        }

        // GET api/<ErovController>/5
        [HttpGet("{id}")]
        public ActionResult<UserEntity> Get(int id)
        {
            var res = _userService.GetUserById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<ErovController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] UserEntity value)
        {
            bool b = _userService.AddUser(value);
            if (!b)
                return NotFound();
            return b;
        }

        // PUT api/<ErovController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] UserEntity value)
        {
            bool b = _userService.UpdateUser(id, value);
            if (!b)
                return NotFound();
            return b;
        }
        // DELETE api/<ErovController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = _userService.DeleteUser(id);
            if (!b)
                return NotFound();
            return b;
        }
    }
}
