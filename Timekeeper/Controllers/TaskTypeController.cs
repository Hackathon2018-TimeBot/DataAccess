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
    [Route("api/TaskType")]
    public class TaskTypeController : Controller
    {
        private IConfiguration Configuration;
        private IDataAccess DAccess;
        private TaskTypeDA DATaskType;

        public TaskTypeController(IConfiguration Configuration, IDataAccess DAccess)
        {
            this.Configuration = Configuration;
            this.DAccess = DAccess;
            this.DATaskType = new TaskTypeDA(ref DAccess, "TaskType");
        }

        // GET: api/Task
        [HttpGet(Name ="GetAllTasks")]
        public IEnumerable<TaskType> Get()
        {
            return this.DATaskType.GetItems<TaskType>();
        }

        // GET: api/Task/5
        [HttpGet("{id}", Name = "GetTask")]
        public TaskType Get(string id)
        {
            return this.DATaskType.GetItem(id);
        }
        
        // POST: api/Task
        [HttpPost(Name ="PostTask")]
        public IActionResult Post([FromBody]TaskType value)
        {
            var result = this.DATaskType.Insert(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // PUT: api/Task/5
        [HttpPut("{id}",Name ="PutTask")]
        public IActionResult Put([FromBody]TaskType value)
        {
            var result = this.DATaskType.Update(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name ="DeleteTask")]
        public IActionResult Delete(string id)
        {
            var result = this.DATaskType.Delete(id);
            return StatusCode((int)result.StatusCode);
        }
    }
}
