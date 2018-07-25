using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Timekeeper.DAL;
using Timekeeper.Models.DataModels;

namespace Timekeeper.Controllers
{
    [Produces("application/json")]
    [Route("api/Contract")]
    public class ContractController : Controller
    {
        private IConfiguration Configuration;
        private IDataAccess DAccess;
        private ContractDA DAContr;

        public ContractController(IConfiguration Configuration, IDataAccess DAccess)
        {
            this.Configuration = Configuration;
            this.DAccess = DAccess;
            this.DAContr = new ContractDA(ref this.DAccess, "Contract");
        }

        // GET: api/Contract
        
        [HttpGet(Name ="GetAllContracts")]
        public IEnumerable<Contract> Get()
        {
            return this.DAContr.GetItems<Contract>();
        }

        // GET: api/Contract/5
        [HttpGet("{id}", Name = "GetContract")]
        public Contract Get(string id)
        {
            return this.DAContr.GetItem(id);
        }

        // POST: api/Contract
        [HttpPost(Name ="PostContract")]
        public IActionResult Post([FromBody]Contract value)
        {
            var result = this.DAContr.Insert(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // PUT: api/Contract/
        [HttpPut(Name ="PutContract")]
        public IActionResult Put([FromBody]Contract value)
        {
            var result = this.DAContr.Update(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}",Name ="DeleteContract")]
        public IActionResult Delete(string id)
        {
            var result = this.DAContr.Delete(id);
            return StatusCode((int)result.StatusCode);
        }
    }
}
