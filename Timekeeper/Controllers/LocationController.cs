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
    [Route("api/Location")]
    public class LocationController : Controller
    {
        private IConfiguration Configuration;
        private IDataAccess DAccess;
        private LocationDA DALocation;

        public LocationController(IConfiguration Configuration, IDataAccess DAccess)
        {
            this.Configuration = Configuration;
            this.DAccess = DAccess;
            this.DALocation = new LocationDA(ref DAccess, "Location");
        }

        // GET: api/Location
        [HttpGet(Name ="GetAllLocations")]
        public IEnumerable<Location> Get()
        {
            return this.DALocation.GetItems<Location>();
        }

        // GET: api/Location/5
        [HttpGet("{id}", Name = "GetLocation")]
        public Location Get(string id)
        {
            Guid Id = new Guid(id);
            return this.DALocation.GetItem(id);
        }
        
        // POST: api/Location
        [HttpPost(Name ="PostLocation")]
        public IActionResult Post([FromBody]Location value)
        {
            var result = this.DALocation.Insert(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // PUT: api/Location/5
        [HttpPut(Name ="PutLocation")]
        public IActionResult Put([FromBody]Location value)
        {
            var result = this.DALocation.Update(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name ="DeleteLocation")]
        public IActionResult Delete(string id)
        {
            var result = this.DALocation.Delete(id);
            return StatusCode((int)result.StatusCode);
        }
    }
}
