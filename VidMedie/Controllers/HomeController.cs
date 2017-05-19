using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMRepo;

namespace VidMedie
{
    public class HomeController : Controller
    {
        VelkommenFac vf = new VelkommenFac();
        // GET: Home
        public ActionResult Index()
        {
            
            return View(vf.GetAll());
        }
    }
}