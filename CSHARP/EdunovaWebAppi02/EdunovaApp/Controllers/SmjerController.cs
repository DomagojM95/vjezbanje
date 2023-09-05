using Microsoft.AspNetCore.Mvc;
using EdunovaApp.Models;
using EdunovaApp.Data;

namespace EdunovaApp.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController:ControllerBase
    {


        private readonly EdunovaContext _context;

        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
            
            return new JsonResult(_context.Smjer.ToList());
        }


        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {
            return Created("/api/v1/Smjer",smjer);
        }
        [HttpPut]
        [Route("{sifra:int}")]
        public IActionResult Put(int sifra,Smjer smjer)
        {
            return StatusCode(StatusCodes.Status200OK,smjer);
        }
        [HttpDelete]
        [Route("{sifra:int}")]
        public IActionResult Delete(int sifra)
        {
            return StatusCode(StatusCodes.Status200OK, "{\"obrisano\":true}");
        }
    }
}
