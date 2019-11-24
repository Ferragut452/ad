using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Users.Models;

namespace Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
       
    {
        AppDataBaseContext db;
        public UsersController(AppDataBaseContext context)
        {
            this.db = context;


                db.Users.Add(new User { Name = "bob", Age = 66, Phone = +3989879877 });
                db.Users.Add(new User { Name = "kolya", Age = 26, Phone = +39464665478 });
                db.Users.Add(new User { Name = "vasya", Age = 31, Phone = +394545455 });
                db.Users.Add(new User { Name = "ola", Age = 26, Phone = +3945454533 });
                db.Users.Add(new User { Name = "max", Age = 8, Phone = +345458794552 });

                db.SaveChanges();
            
        }
        
        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "some user";
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
