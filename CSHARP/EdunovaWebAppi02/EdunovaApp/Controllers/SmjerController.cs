using Microsoft.AspNetCore.Mvc;
using EdunovaApp.Models;

namespace EdunovaApp.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController:ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var lista = new List<Smjer>()
            {
                new (){Naziv="prvi"},
                new (){Naziv="Drugi"}
            };
            return new JsonResult(lista);
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
