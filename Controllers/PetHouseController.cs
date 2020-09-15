using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetHouseDockerEg.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetHouseDockerEg.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PetHouseController : ControllerBase
    {
        public List<PetHouse> pet = new List<PetHouse>();
        
        public PetHouseController()
        {
            pet.Add(new PetHouse()
            {
                PetId = 1,
                PetType = "Puppy",
                Age = "3 months",
                Price = 2000

            }) ;
            pet.Add(new PetHouse()
            {
                PetId = 2,
                PetType = "cat",
                Age = "2 months",
                Price = 1000

            });
            pet.Add(new PetHouse()
            {
                PetId = 3,
                PetType = "Parrot",
                Age = "5 days",
                Price = 900

            });
            pet.Add(new PetHouse()
            {
                PetId =4,
                PetType = "Rabbit",
                Age = "10 days",
                Price = 500

            });

        }
        // GET: api/<PetHouseController>
        [HttpGet]
        public IEnumerable<PetHouse> Get()
        {
            return pet;
        }

        // GET api/<PetHouseController>/5
        [HttpGet("{id}")]
        public PetHouse Get(int id)
        {
            return pet.Where(x => x.PetId == id).FirstOrDefault();
        }

        // POST api/<PetHouseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PetHouseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetHouseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
