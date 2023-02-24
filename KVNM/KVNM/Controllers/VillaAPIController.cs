using KVNM.Models;
using KVNM.Models.VillaDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVNM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<VillaDto>> Get()
        {
            return Ok(VillaStore.villaDtos.ToList());
        }
        [HttpGet("{id:int}",Name ="Getvilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> Get(int id)
        {
            if (id==0)
            {
                return BadRequest();
            }
            var data = VillaStore.villaDtos.FirstOrDefault(x => x.Id == id);
            if (data==null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        [HttpPost]       
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDto> CreateVilla(VillaDto data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            bool datax=VillaStore.villaDtos.Any(x=>x.Id==data.Id);
            if (datax)
            {
                ModelState.AddModelError("Name", "data Alreday Exist");
                return BadRequest(ModelState);
            }
            {
               
            }
            if (data == null)
            {
                return BadRequest(data);
            }
            
            data.Id =VillaStore.villaDtos.OrderByDescending(x=>x.Id).FirstOrDefault().Id+1;
            VillaStore.villaDtos.Add(data);
            return CreatedAtRoute("Getvilla",new { data.Id} ,data);
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> DeleteVilla(int id )
        {
            var exist=VillaStore.villaDtos.Find(x=>x.Id==id);
            if (exist==null)
            {
                return NoContent();
            }
            VillaStore.villaDtos.Remove(exist);
            return Ok(exist);
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> Update(int id, [FromBody]VillaDto villaDto)
        {
            if (villaDto==null&& id!=villaDto.Id)
            {
                return BadRequest();
                
            }
            var exist = VillaStore.villaDtos.Find(x => x.Id == id);
           exist.Name=villaDto.Name;

            return NoContent();
        }
    }  
}
