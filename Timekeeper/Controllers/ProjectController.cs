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
    [Route("api/Project")]
    public class ProjectController : Controller
    {
        private IConfiguration Configuration;
        private IDataAccess DAccess;
        private ProjectDA DAProject;

        public ProjectController(IConfiguration Configuration, IDataAccess DAccess)
        {
            this.Configuration = Configuration;
            this.DAccess = DAccess;
            this.DAProject = new ProjectDA(ref DAccess, "Project");
        }

        // GET: api/Project
        [HttpGet(Name ="GetAllProjects")]
        public IEnumerable<Project> Get()
        {
            return this.DAProject.GetItems<Project>();
        }

        // GET: api/Project/5
        [HttpGet("{id}", Name = "GetProject")]
        public Project Get(string id)
        {
            return this.DAProject.GetItem(id);
        }
        
        // POST: api/Project
        [HttpPost(Name ="PostProject")]
        public IActionResult Post([FromBody]Project value)
        {
            var result = this.DAProject.Insert(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // PUT: api/Project/5
        [HttpPut(Name ="PutProject")]
        public IActionResult Put([FromBody]Project value)
        {
            var result = this.DAProject.Update(value);
            return StatusCode((int)result.StatusCode);
            
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}",Name ="DeleteProject")]
        public IActionResult Delete(string id)
        {
            var result = this.DAProject.Delete(id);
            return StatusCode((int)result.StatusCode);
        }
    }
}
