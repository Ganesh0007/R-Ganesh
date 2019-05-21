using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace r_ganesh.Controllers
{
    public class QuiSuisJeController : Controller
    {
        // GET: QuiSuisJe
        public ActionResult Index()
        {
            return View();
        }

        public FileStreamResult GetCV()
        {
            FileStream fs = new FileStream(Server.MapPath(@"~\Models\Pdf\CV_Ganesh_RADJE.pdf"), FileMode.Open, FileAccess.Read);
            return File(fs, "application/pdf");
        }
    }
}