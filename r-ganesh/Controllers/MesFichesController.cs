using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace r_ganesh.Controllers
{
    public class MesFichesController : Controller
    {
        // GET: MesFiches
        public ActionResult Index()
        {
            return View();
        }

        public FileStreamResult GetFredi()
        {
            FileStream fsf = new FileStream(Server.MapPath(@"~\Models\Pdf\Fiche_E4_FREDI_2019.pdf"), FileMode.Open, FileAccess.Read);
            return File(fsf, "application/pdf");
        }

        public FileStreamResult GetValres()
        {
            FileStream fsf = new FileStream(Server.MapPath(@"~\Models\Pdf\Fiche_E4_VALRES_2019.pdf"), FileMode.Open, FileAccess.Read);
            return File(fsf, "application/pdf");
        }

        public FileStreamResult GetE6()
        {
            FileStream fs = new FileStream(Server.MapPath(@"~\Models\Pdf\Fiche_E6_2019.pdf"), FileMode.Open, FileAccess.Read);
            return File(fs, "application/pdf");
        }
        
    }
}