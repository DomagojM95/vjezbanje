using EdunovaApp.Data;
using EdunovaApp.Models;
using EdunovaApp.Models.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace EdunovaApp.Controllers
{

    /// <summary>
    /// Namjenjeno za CRUD operacije nad Grupom
    /// </summary>
    /// 
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GrupaController: ControllerBase
    {

        private readonly EdunovaContext _context;

        private ILogger<GrupaController> _logger;

        public GrupaController(EdunovaContext context,ILogger<GrupaController>logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            _logger.LogInformation("Dohvacam grupe");


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var grupe = _context.Grupa
                    .Include(g=>g.Polaznici)
                    .Include(g=>g.Smjer).ToList();

                if(grupe==null || grupe.Count == 0)
                {
                    return new EmptyResult();
                }

                List<GrupaDTO> vrati = new();

                grupe.ForEach(g =>
                {
                    vrati.Add(new GrupaDTO
                    {
                        Sifra=g.Sifra,
                        Naziv=g.Naziv,
                        Smjer=g.Smjer?.Naziv,
                        SifraSmjer=g.Smjer.Sifra,
                        DatumPocetka=g.DatumPocetka,
                        BrojPolaznika=g.Polaznici.Count

                    });

                });

                return Ok(vrati);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }

           
        }


        [HttpPost]
        public IActionResult Post(GrupaDTO grupaDTO)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(grupaDTO.SifraSmjer<=0) 
            {
                return BadRequest(ModelState);
            }
            try
            {

          
            var smjer=_context.Smjer.Find(grupaDTO.SifraSmjer);
            Grupa g = new()
            {
                Naziv = grupaDTO.Naziv,
                Smjer = smjer,
                DatumPocetka=grupaDTO.DatumPocetka,
            };

                _context.Grupa.Add(g);
                _context.SaveChanges();

                grupaDTO.Sifra = g.Sifra;
                grupaDTO.Smjer = g.Naziv;
                return Ok(grupaDTO);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);

            }

        }

    }
}
