using Microsoft.AspNetCore.Mvc;
using EdunovaApp.Models;
using EdunovaApp.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;

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

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var smjerovi = _context.Smjer.ToList();
                if (smjerovi == null || smjerovi.Count == 0)
                {
                    return new EmptyResult();
                }
                return new JsonResult(_context.Smjer.ToList());
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }
            
            
        }


        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _context.Smjer.Add(smjer);
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, smjer);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }
            

        }



        [HttpPut]
        [Route("{sifra:int}")]
        public IActionResult Put(int sifra,Smjer smjer)
        {
            if (sifra <= 0 || smjer==null)
            {
                return BadRequest();
            }

            try
            {
                var smjerBaza = _context.Smjer.Find(sifra);
                if (smjerBaza == null)
                {
                    return BadRequest();
                }

                smjerBaza.Naziv = smjer.Naziv;
                smjerBaza.Trajanje= smjer.Trajanje;
                smjerBaza.Cijena=smjer.Cijena;
                smjerBaza.Upisnina=smjer.Upisnina;
                smjerBaza.Verificiran = smjer.Verificiran;

                _context.Smjer.Update(smjerBaza);
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, smjerBaza);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex);

            }
            
        }






        [HttpDelete]
        [Route("{sifra:int}")]
        public IActionResult Delete(int sifra)
        {
            if (sifra == 0)
            {
                return BadRequest();
            }
            try
            {
                var smjerBaza=_context.Smjer.Find(sifra);
                if (smjerBaza == null)
                {
                    return BadRequest();
                }
                _context.Smjer.Remove(smjerBaza);
                _context.SaveChanges();

                return new JsonResult("{\"poruka\":\"Obrisano\"}");
            }
            catch (Exception ex)
            {

                try
                {
                    SqlException sqle=(SqlException)ex;
                    return StatusCode(StatusCodes.Status503ServiceUnavailable, sqle);
                }
                catch (Exception e)
                {

                    
                }

                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex);
            }
        }
        [HttpGet]
        [Route("unosubazu")]

        public string UnosUbazu()
        {
            Smjer s;
            for(int i = 0; i < 1000; i++)
            {
                //s = new()
                //{
                //    Naziv = "iz koda" + i,
                //    Trajanje = i
                //};

                s = new()
                {
                    Naziv = Faker.Company.Name(),
                    Trajanje=Faker.RandomNumber.Next(130,320),
                    Cijena=Faker.Finance.Coupon(),
                    Upisnina=Faker.Finance.Coupon(),
                    Verificiran=Faker.Boolean.Random()
                    
                };
                _context.Smjer.Add(s);
            }
            _context.SaveChanges();
            return "OK";
        }

        [HttpGet]
        [Route("unosubazuV2")]

        public string parni()
        {
            var smjerovi = _context.Smjer.ToList();

            foreach(var s in smjerovi)
            {
                if (s.Sifra % 2 == 0)
                {
                    s.Naziv += "Mjenjao";
                    _context.Smjer.Update(s);
                }
            }
            _context.SaveChanges();

            return "OK";

        }

        [HttpGet]
        [Route("zadatak3")]
        public string suma()
        {
            var  smjerovi=_context.Smjer.ToList();

            for(int i = 0; i < smjerovi.Count; i++)
            {
                var suma = i + i;

                return suma.ToString();

            }
            
        }
    }

}
