using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace r_ganesh.Controllers
{
    public class VeilleTechnoController : Controller
    {
        // GET: VeilleTechno
        public ActionResult Index()
        {
            return View();
        }

        public void SelectPicture()
        {
            WebImage img = new WebImage("~/Views/VeilleTechno/VeilleTechno_GA.PNG");
            img.Resize(600,350);
            img.FileName = "VeilleTechno_GA.PNG";
            img.Write();
        }
    }
}