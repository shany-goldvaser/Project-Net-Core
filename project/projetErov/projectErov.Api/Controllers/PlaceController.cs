using Microsoft.AspNetCore.Mvc;
using projetErov.Core.Entities;
using projetErov.Core.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projectErov.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        readonly IPlaceService _placeService;

        public PlaceController(IPlaceService placeService)
        {
            _placeService = placeService;
        }

        // GET: api/<ErovController>
        [HttpGet]
        public ActionResult<IEnumerable<PlaceEntity>> Get()
        {
            return _placeService.GetAllPlace();
        }

        // GET api/<ErovController>/5
        [HttpGet("{id}")]
        public ActionResult<PlaceEntity> Get(int id)
        {
            var res = _placeService.GetPlaceById(id);
            if (res == null)
                return NotFound();
            return res;
        }

        // POST api/<ErovController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] PlaceEntity value)
        {
            bool b = _placeService.AddPlace(value);
            if (!b)
                return NotFound();
            return b;
        }

        // PUT api/<ErovController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] PlaceEntity value)
        {
            bool b = _placeService.UpdatePlace(id, value);
            if (!b)
                return NotFound();
            return b;
        }
        // DELETE api/<ErovController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = _placeService.DeletePlace(id);
            if (!b)
                return NotFound();
            return b;
        }

    }
}
