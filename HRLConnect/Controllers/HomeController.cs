using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRLConnect.BAL;
using HRLConnect.Models;

namespace HRLConnect.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var BALObj = new SessionService();
            var UserDetails = new UserDetails();

            UserDetails = BALObj.getUserDetails("k.anil");

            ViewBag.obj = UserDetails;
            return ViewBag();

            

        }

       
    }
}