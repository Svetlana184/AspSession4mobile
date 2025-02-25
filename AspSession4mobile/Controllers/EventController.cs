using AspSession4mobile.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspSession4mobile.Controllers
{
    [ApiController]
    public class EventController : ControllerBase
    {
        private RoadOfRussiaContext db;
        public EventController(RoadOfRussiaContext db)
        {
            this.db = db;
        }
        [HttpGet]
        [Route("Events")]
        //public IQueryable GetEvents()
        //{
        //    var ev = new
        //    {
        //        Title,
        //        Date,
        //        Description,
        //        Author
        //    }
        //    return ev.AsQueryable();

        //}
    }
}
