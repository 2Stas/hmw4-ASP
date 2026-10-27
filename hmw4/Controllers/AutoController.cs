using AutoApi.Models;
using AutoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutoController : ControllerBase
    {
        private readonly AutoService _service;

        public AutoController(AutoService service)
        {
            _service = service;
        }

        [HttpPost("createDB")]
        public IActionResult CreateAuto()
        {
            _service.CreateAuto();

            return Ok("DB was created!");
        }

        [HttpPost]
        public IActionResult AddAuto([FromBody] Auto auto)
        {
            Auto result = _service.AddAuto(auto);

            return Ok(new
            {
                Message = "Auto added successfully!",
                Id = result.Id,
                Name = result.Name,
                Year = result.Year
            });
        }

        [HttpGet("{id:int}")]
        public IActionResult ReturnAuto(int id)
        {
            Auto? auto = _service.ReturnAuto(id);

            if (auto == null)
            {
                return NotFound("Auto was not found!");
            }

            return Ok(auto);
        }

        [HttpGet("byName")]
        public IActionResult ReturnByName(string name)
        {
            List<Auto> autos = _service.ReturnByName(name);

            return Ok(autos);
        }

        [HttpGet("byYear")]
        public IActionResult ReturnByYear(int year)
        {
            List<Auto> autos = _service.ReturnByYear(year);

            return Ok(autos);
        }

        [HttpGet]
        public IActionResult ShowAll()
        {
            List<Auto> autos = _service.ShowAll();

            return Ok(autos);
        }
    }
}