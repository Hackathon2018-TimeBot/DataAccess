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
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private IConfiguration Configuration;
        private IDataAccess DAccess;
        private CustomerDA DACustomer;

        public CustomerController(IConfiguration Configuration, IDataAccess DAccess)
        {
            this.Configuration = Configuration;
            this.DAccess = DAccess;
            this.DACustomer = new CustomerDA(ref DAccess, "Customer");
        }

        // GET: api/Customer
        [HttpGet(Name ="GetAllCustomers")]
        public IEnumerable<Customer> Get()
        {
            return this.DACustomer.GetItems<Customer>();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "GetCustomer")]
        public Customer Get(string id)
        {
            return this.DACustomer.GetItem(id);
        }
        
        // POST: api/Customer
        [HttpPost(Name ="PostCustomer")]
        public IActionResult Post([FromBody]Customer value)
        {
            var result = this.DACustomer.Insert(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // PUT: api/Customer/5
        [HttpPut(Name ="PutCustomer")]
        public IActionResult Put([FromBody]Customer value)
        {
            var result = this.DACustomer.Update(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}",Name ="DeleteCustomer")]
        public IActionResult Delete(string id)
        {
            var result = this.DACustomer.Delete(id);
            return StatusCode((int)result.StatusCode);
        }
    }
}
