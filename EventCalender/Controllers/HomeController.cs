using EventCalender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventCalender.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            DataBase.DataContext Db = new DataBase.DataContext();
            var events = Db.Events.ToList();

            return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpPost]
        public JsonResult SaveEvent(Event newEvent)
        {
            var status = false;
            DataBase.DataContext Db = new DataBase.DataContext();
            if (newEvent.Id > 0)
            {
                //Update the event
                var eventtoEdit = Db.Events.FirstOrDefault(a => a.Id == newEvent.Id);
                if (eventtoEdit != null)
                {
                    eventtoEdit.Title = newEvent.Title;
                    eventtoEdit.Start = newEvent.Start;
                    eventtoEdit.End = newEvent.End;
                    eventtoEdit.Description = newEvent.Description;
                }
            }
            else
            {
                Db.Events.Add(newEvent);
            }
             Db.SaveChanges();
             status = true;
     
            return new JsonResult { Data = new { status = status } };

        }

        [HttpPost]
        public JsonResult DeleteEvent(int id)
        {
            var status = false;
            DataBase.DataContext Db = new DataBase.DataContext();

            var eventToDelete = Db.Events.FirstOrDefault(a => a.Id == id);
                if (eventToDelete != null)
                {
                    Db.Events.Remove(eventToDelete);
                    Db.SaveChanges();
                    status = true;
                }
            
            return new JsonResult { Data = new { status = status } };
        }
    }
}   