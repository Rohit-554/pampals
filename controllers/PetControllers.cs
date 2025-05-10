using Microsoft.AspNetCore.Mvc;
using Pampals.Models;
using System.Collections.Generic;

namespace Pampals.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetController : ControllerBase
    {
        private static List<Pet> pets = new List<Pet>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(pets);
        }

        [HttpPost]
        public IActionResult Add(Pet pet)
        {
            pet.Id = pets.Count + 1;
            pets.Add(pet);
            return CreatedAtAction(nameof(GetAll), new { id = pet.Id }, pet);
        }
    }
}
