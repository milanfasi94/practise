using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webaruhaz.Models;

namespace Webaruhaz.Controllers
{
    public class KosarController : Controller
    {
        private Model1 db = new Model1();
        // GET: Kosar
        public ActionResult Index()
        {
            return View(db.ShoppingCart.ToList());
        }
    }
}