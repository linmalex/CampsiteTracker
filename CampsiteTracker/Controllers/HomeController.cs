using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CampsiteTracker.Models;
using CampsiteTracker.DAL;

namespace CampsiteTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Name, string Location, string TentType, string VehicleAccess,
                            string CampsiteType, string ToiletAccess, string DogFriendly)
        {
            using (CampsiteContext db = new CampsiteContext())
            {
                var campsite = new Campsite();

                campsite.Name = Name;
                campsite.Location = Location;
                campsite.TentType = TentType;
                campsite.VehicleAccess = VehicleAccess;
                campsite.CampsiteType = CampsiteType;
                campsite.ToiletAccess = ToiletAccess;
                campsite.DogFriendly = DogFriendly;

                db.Campsites.Add(campsite);
                db.SaveChanges();

                ViewBag.Message = "Your request has been submitted";
                return View();
            }
        }
    }
    }
