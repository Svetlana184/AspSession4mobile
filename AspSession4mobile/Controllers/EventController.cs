﻿using AspSession4mobile.Models;
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
        public IQueryable GetEvents()
        {
            var ev = from e in db.Events
                     select new
                     {
                         Title = e.EventName,
                         Date = e.DateOfEvent,
                         Description = e.EventDescription,
                         Author = e.EventManagers
                     };
            return ev.AsQueryable();

        }
    }
}
