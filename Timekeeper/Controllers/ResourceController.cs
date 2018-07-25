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
    [Route("api/Resource")]
    public class ResourceController : Controller
    {
        private IConfiguration Configuration;
        private IDataAccess DAccess;
        private ResourceDA DAResource;

        public ResourceController(IConfiguration Configuration, IDataAccess DAccess)
        {
            this.Configuration = Configuration;
            this.DAccess = DAccess;
            this.DAResource = new ResourceDA(ref DAccess, "Resource");
        }

        // GET: api/Resource
        [HttpGet(Name ="GetAllResources")]
        public IEnumerable<Resource> Get()
        {
            return this.DAResource.GetItems<Resource>();
        }

        // GET: api/Resource/5
        [HttpGet("{id}", Name = "GetResource")]
        public Resource Get(string id)
        {
            return this.DAResource.GetItem(id);
        }
        
        // POST: api/Resource
        [HttpPost(Name ="PostResource")]
        public IActionResult Post([FromBody]Resource value)
        {
            var result = this.DAResource.Insert(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // PUT: api/Resource/5
        [HttpPut(Name ="PutResource")]
        public IActionResult Put([FromBody]Resource value)
        {
            var result = this.DAResource.Update(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name="DeleteResource")]
        public IActionResult Delete(string id)
        {
            var result = this.DAResource.Delete(id);
            return StatusCode((int)result.StatusCode);
        }
    }
}
