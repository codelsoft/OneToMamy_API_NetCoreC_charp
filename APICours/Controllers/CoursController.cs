using APICours.Service;
using APICours.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using APICours.Dtos;

namespace APICours.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursController : ControllerBase
    {
        private readonly Icours _cousrepos;
        private readonly IMapper _mapper;

        public CoursController(Icours cousrepos, IMapper mapper) 
        {
          _cousrepos = cousrepos;
          _mapper = mapper;
        }


        [HttpPost]
        public ActionResult   postCours(CoursDto cours) 
        {
            try 
            {
                if (cours == null)
                {
                    return BadRequest();
                }
                   
                var newCours = _mapper.Map<Cours>(cours);

                _cousrepos.createCours(newCours);

               // return Created($"/{newCours.Id}", newCours);
               
            }
            catch(Exception)
            {
               return NotFound();
            }



            return Ok(cours);

        }
    }
}
