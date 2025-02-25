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
        [HttpGet]
        //public IQueryable GetNews()
        //{
        //    var news = new
        //    {
        //        Title,
        //        Date,
        //        Description,
        //        Image
        //    };
        //    return news.AsQuerable();
        //}
    }
}
