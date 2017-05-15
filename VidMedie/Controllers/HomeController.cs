using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMRepo;

namespace VidMedie.Controllers
{
    public class HomeController : Controller
    {
        ForsideFac ff = new ForsideFac();
        // GET: Home
        public ActionResult Index()
        {
            return View(ff.GetAll());
        }
    }
}