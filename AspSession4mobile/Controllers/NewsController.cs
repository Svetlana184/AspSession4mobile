using AspSession4mobile.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspSession4mobile.Controllers
{
    [ApiController]
    public class NewsController : ControllerBase
    {
        private RoadOfRussiaContext db;

        public NewsController(RoadOfRussiaContext db)
        {
            this.db = db;
        }
        [Route("News")]
    }
}
