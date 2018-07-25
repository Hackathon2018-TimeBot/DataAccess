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
    [Route("api/TimeBooking")]
    public class TimeBookingController : Controller
    {
        private IConfiguration Configuration;
        private IDataAccess DAccess;
        private TimeBookingDA DATimeBooking;

        public TimeBookingController(IConfiguration Configuration, IDataAccess DAccess)
        {
            this.Configuration = Configuration;
            this.DAccess = DAccess;
            this.DATimeBooking = new TimeBookingDA(ref DAccess, "TimeBooking");
        }

        // GET: api/TimeBooking
        [HttpGet(Name = "GetAllTimeBookings")]
        public IEnumerable<TimeBooking> Get()
        {
            return this.DATimeBooking.GetItems<TimeBooking>();
        }

        // GET: api/TimeBooking/5
        [HttpGet("{id}", Name = "GetTimeBooking")]
        public TimeBooking Get(string id)
        {
            return this.DATimeBooking.GetItem(id);
        }
        
        // POST: api/TimeBooking
        [HttpPost(Name = "PostTimeBooking")]
        public IActionResult Post([FromBody]TimeBooking value)
        {
            var result = this.DATimeBooking.Insert(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // PUT: api/TimeBooking/5
        [HttpPut("{id}", Name = "PutTimeBooking")]
        public IActionResult Put([FromBody]TimeBooking value)
        {
            var result = this.DATimeBooking.Update(value);
            return StatusCode((int)result.StatusCode);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name = "DeleteTimeBooking")]
        public IActionResult Delete(string id)
        {
            var result = this.DATimeBooking.Delete(id);
            return StatusCode((int)result.StatusCode);
        }
    }
}
