using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMRepo;
using VidMedie.ViewModels;


namespace VidMedie
{
    public class HomeController : Controller
    {
        VelkommenFac vf = new VelkommenFac();
        // GET: Home
        public ActionResult Index()
        {
            // set up view model for index view
            VelkommenFac vf = new VelkommenFac();
            UddannelseFac uf = new UddannelseFac();
            VejledningOgStotteFac vsf = new VejledningOgStotteFac();
            var viewmodel = new ForsideVM();

            viewmodel.velkommentext = vf.Get(1);
            viewmodel.uddannelsetext = uf.Get(1);
            viewmodel.Vejledningogstottetext = vsf.Get(1);

            //@{
            //     VelkommenFac vf = new VelkommenFac();
            //     // GET: Home
            //     var mod = vf.GetAll();
            //     Velkommen velkommen = new Velkommen();
            //     foreach (var m in mod)
            //     {
            //         velkommen = m;
            //     }
            //     Html.RenderPartial("VelkomstText", velkommen);
            // }

            return View(viewmodel);

            // return View(vf.GetAll());
        }
    }
}