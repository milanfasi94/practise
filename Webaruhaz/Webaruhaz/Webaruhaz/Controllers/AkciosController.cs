using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webaruhaz.Models;

namespace Webaruhaz.Controllers
{
    public class AkciosController : Controller
    {
        private Model1 db = new Model1();
        // GET: Akcios
        public ActionResult Index()
        {
            return View(db.Parfum.ToList());
        }
    }
}