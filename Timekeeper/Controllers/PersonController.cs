using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Timekeeper.DAL;
using Timekeeper.Models.DataModels;

namespace Timekeeper.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        private IConfiguration Configuration;
        private IDataAccess DAccess;
        private PersonDA DAPerson;

        public PersonController(IConfiguration Configuration, IDataAccess DAccess)
        {
            this.Configuration = Configuration;
            this.DAccess = DAccess;
            this.DAPerson = new PersonDA(ref DAccess, "Person");
        }


        // GET: api/Person
        [HttpGet(Name ="GetAllPersons")]
        public IEnumerable<Person> Get()
        {
            return this.DAPerson.GetItems<Person>();
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "GetPerson")]
        public Person Get(string id)
        {
            return this.DAPerson.GetItem(id);
        }
        
        // POST: api/Person
        [HttpPost(Name ="PostPerson")]
        public IActionResult Post([FromBody]Person value)
        {
            var result = this.DAPerson.Insert(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // PUT: api/Person/5
        [HttpPut(Name ="PutPerson")]
        public IActionResult Put([FromBody]Person value)
        {
            var result = this.DAPerson.Update(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}",Name ="DeletePerson")]
        public IActionResult Delete(string id)
        {
            var result = this.DAPerson.Delete(id);
            return StatusCode((int)result.StatusCode);
        }
    }
}
