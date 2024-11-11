using Microsoft.AspNetCore.Mvc;
using ShanyGoldvaserProject.Entities;
using ShanyGoldvaserProject.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShanyGoldvaserProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        readonly PlaceService _placeService = new ();
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<Place>> Get()
        {
            return _placeService.GetPlace();
        }
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<Place> Get(int id)
        {
            if(id<0)
            {
                return NotFound();
            }
            var res = _placeService.GetPlaceId(id);
            if (res == null)
            {
                return NotFound(res);
            }
            return res;
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Place value)
        {
            bool res = _placeService.AddPlace(value);
            if (res)
            {
                return res;
            }
            return NotFound(res);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Place value)
        {
            bool res = _placeService.UpdatePlace(id, value);
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
            if(id < 0)
            {
                return false;
            }
            bool res = _placeService.DeletePlace(id);
            if (res)
            {
                return res;
            }
            return NotFound(res);

        }
    }
}

